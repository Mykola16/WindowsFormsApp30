using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        private const string sqlTovarSelect = "select * from Tovar";
        private const string sqlVendorSelect = "select * from Vendor";
  
        private SqlConnection sqlConnection;

        public Form1(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;

            InitializeComponent();
            dgvT.MultiSelect = false;
            dgvT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvT.AllowUserToAddRows = false;
            dgvT.AllowUserToDeleteRows = false;
            dgvT.ReadOnly = true;

        }

        private void UpdateTechersView()
        {
            dgvT.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlTovarSelect, sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvT.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTechersView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            string sql = "WAITFOR DELAY '00:00:05'; INSERT INTO[Tovar]([Id],[Name],[Type],[Number]) VALUES(@Id,@Name,@Type,@Number)";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            try
            {
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Name", edFirstname.Text));
                command.Parameters.Add(new SqlParameter("@Type", edLastname.Text));
                command.Parameters.Add(new SqlParameter("@Number", textBox1.Text));


                SqlParameter dep = new SqlParameter("@Id", SqlDbType.Int);
                dep.Value = (int)edDepartment.Value;
                command.Parameters.Add(dep);

                var state = command.BeginExecuteNonQuery(ExecuteQueryCallback, command);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAdd.Enabled = true;
                
            }
        }

        private void ExecuteQueryCallback(IAsyncResult result)
        {
            
            SqlCommand command = result.AsyncState as SqlCommand;
            if (command == null)
                return;

            int rowcount = command.EndExecuteNonQuery(result);

            Action a = () =>
            {
                btnAdd.Enabled = true;
                UpdateTechersView();
            };
            if (InvokeRequired)
            {
                Invoke(a);
            }
            else
            {
                a();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            int idToDelete = Convert.ToInt32(textBox5.Text);


            string query = "DELETE FROM Tovar WHERE Id = @id";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {

                command.Parameters.AddWithValue("@id", idToDelete);


                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись удалена успешно.");
                    UpdateTechersView();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись.");
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlVendorSelect, sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string sql = "WAITFOR DELAY '00:00:05'; INSERT INTO[Vendor]([ID],[Nazva_Vendor]) VALUES(@ID,@Nazva_Vendor)";

            button3.Enabled = false;
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            command.Parameters.Add(new SqlParameter("@Nazva_Vendor", textBox3.Text));
            


            SqlParameter dep1 = new SqlParameter("@ID", SqlDbType.Int);
            dep1.Value = (int)numericUpDown1.Value;
            command.Parameters.Add(dep1);




            try
            {
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                button3.Enabled = true;
                button4_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idToDelete = Convert.ToInt32(textBox2.Text);


            string query = "DELETE FROM Vendor WHERE Id = @id";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {

                command.Parameters.AddWithValue("@id", idToDelete);


                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись удалена успешно.");
                    button4_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись.");
                }

            }
        }

        //1)
        //Показати інформацію про постачальника, в якого
        //кількість товарів на складі найбільша.

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 1 v.Nazva_Vendor, s.Number " +
                   "FROM Supply s " +
                   "JOIN Vendor v ON s.Supplier_ID = v.ID " +
                   "ORDER BY s.Number DESC";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }

        }


        //2)
        //Показати інформацію про постачальника, в якого
        //кількість товарів на складі найменша.

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 1 v.Nazva_Vendor, s.Number " +
                   "FROM Supply s " +
                   "JOIN Vendor v ON s.Supplier_ID = v.ID " +
                   "ORDER BY s.Number ASC";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
        }

        //3)
        //Показати інформацію про тип товару з найбільшою
        //кількістю одиниць на складі.

        private void button13_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT TOP 1 Type, MAX(Number) AS Number " +
                   "FROM Tovar " +
                   "GROUP BY Type " +
                   "ORDER BY Number DESC";
                   

            using (SqlCommand command = new SqlCommand(query1, sqlConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
        }

        //4)
        //Показати інформацію про тип товарів з найменшою
        //кількістю товарів на складі.

        private void button5_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT TOP 1 Type, MIN(Number) AS Number " +
                   "FROM Tovar " +
                   "GROUP BY Type " +
                   "ORDER BY Number DESC";


            using (SqlCommand command = new SqlCommand(query1, sqlConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
        }

        //5)
        //Показати товари, з постачання яких минула задана
        //кількість днів


        private void button12_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Tovar.Name, Tovar.Type, Supply.Number, Supply.Date " +
                  "FROM Tovar, Supply " +
                  "WHERE  DATEDIFF(day, Supply.Date, GETDATE()) > 20; ";
                  


            using (SqlCommand command = new SqlCommand(query1, sqlConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}

