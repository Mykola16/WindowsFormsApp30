namespace WindowsFormsApp30
{
    partial class Form2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.edAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grSQL = new System.Windows.Forms.GroupBox();
            this.edPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbAsynchronousProcessing = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address (Data Source)";
            // 
            // edAddress
            // 
            this.edAddress.Location = new System.Drawing.Point(133, 6);
            this.edAddress.Name = "edAddress";
            this.edAddress.Size = new System.Drawing.Size(337, 20);
            this.edAddress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAsynchronousProcessing);
            this.groupBox1.Controls.Add(this.grSQL);
            this.groupBox1.Controls.Add(this.rbSQL);
            this.groupBox1.Controls.Add(this.rbWindows);
            this.groupBox1.Location = new System.Drawing.Point(11, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type authentication";
            // 
            // grSQL
            // 
            this.grSQL.Controls.Add(this.edPassword);
            this.grSQL.Controls.Add(this.label3);
            this.grSQL.Controls.Add(this.edLogin);
            this.grSQL.Controls.Add(this.label2);
            this.grSQL.Enabled = false;
            this.grSQL.Location = new System.Drawing.Point(29, 79);
            this.grSQL.Name = "grSQL";
            this.grSQL.Size = new System.Drawing.Size(430, 94);
            this.grSQL.TabIndex = 2;
            this.grSQL.TabStop = false;
            this.grSQL.Text = "User info";
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(107, 53);
            this.edPassword.Name = "edPassword";
            this.edPassword.PasswordChar = '*';
            this.edPassword.Size = new System.Drawing.Size(317, 20);
            this.edPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // edLogin
            // 
            this.edLogin.Location = new System.Drawing.Point(107, 27);
            this.edLogin.Name = "edLogin";
            this.edLogin.Size = new System.Drawing.Size(317, 20);
            this.edLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Id (Login)";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(30, 49);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(80, 17);
            this.rbSQL.TabIndex = 1;
            this.rbSQL.Text = "SQL Server";
            this.rbSQL.UseVisualStyleBackColor = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(30, 26);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(69, 17);
            this.rbWindows.TabIndex = 0;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows";
            this.rbWindows.UseVisualStyleBackColor = true;
            this.rbWindows.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(41, 280);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAsynchronousProcessing
            // 
            this.cbAsynchronousProcessing.AutoSize = true;
            this.cbAsynchronousProcessing.Location = new System.Drawing.Point(29, 196);
            this.cbAsynchronousProcessing.Name = "cbAsynchronousProcessing";
            this.cbAsynchronousProcessing.Size = new System.Drawing.Size(170, 17);
            this.cbAsynchronousProcessing.TabIndex = 3;
            this.cbAsynchronousProcessing.Text = "Use Asynchronous Processing";
            this.cbAsynchronousProcessing.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 316);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test SqlBuilder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grSQL.ResumeLayout(false);
            this.grSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grSQL;
        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbAsynchronousProcessing;
    }
}