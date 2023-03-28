using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder builder;
        public Form2()
        {
            InitializeComponent();
            builder = new SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString);
            edAddress.Text = builder.DataSource;
            cbAsynchronousProcessing.Checked = builder.AsynchronousProcessing;
            rbWindows.Checked = builder.IntegratedSecurity;
            if (!builder.IntegratedSecurity)
            {
                edLogin.Text = builder.UserID;
                edPassword.Text = builder.Password;
            }
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            grSQL.Enabled = !rbWindows.Checked;
            if (rbSQL.Checked)
            {
                edLogin.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edAddress.Text))
                return;

            builder.DataSource = edAddress.Text;
            if (rbWindows.Checked)
                builder.IntegratedSecurity = true;
            else
            {
                builder.UserID = edLogin.Text;
                builder.Password = edPassword.Text;
            }

            builder.AsynchronousProcessing = cbAsynchronousProcessing.Checked;

            SqlConnection sqlConnection = new SqlConnection(builder.ToString());
            try
            {
                sqlConnection.Open();
                Form1 dbViewForm = new Form1(sqlConnection);
                Hide();
                dbViewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Show();
                sqlConnection?.Close();
            }
        }
    }
}

