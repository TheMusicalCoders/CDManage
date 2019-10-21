namespace CDManage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPnL = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswdBx = new System.Windows.Forms.TextBox();
            this.UsrBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminPnL = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.usrPnL = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guestPnL = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.searchBtN = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.switchToLoginPnlBtn = new System.Windows.Forms.Button();
            this.loginPnL.SuspendLayout();
            this.AdminPnL.SuspendLayout();
            this.usrPnL.SuspendLayout();
            this.guestPnL.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPnL
            // 
            this.loginPnL.Controls.Add(this.LoginBtn);
            this.loginPnL.Controls.Add(this.PasswdBx);
            this.loginPnL.Controls.Add(this.UsrBx);
            this.loginPnL.Controls.Add(this.label9);
            this.loginPnL.Controls.Add(this.label8);
            this.loginPnL.Controls.Add(this.label4);
            this.loginPnL.Location = new System.Drawing.Point(493, 27);
            this.loginPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPnL.Name = "loginPnL";
            this.loginPnL.Size = new System.Drawing.Size(523, 119);
            this.loginPnL.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(95, 87);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswdBx
            // 
            this.PasswdBx.Location = new System.Drawing.Point(95, 58);
            this.PasswdBx.Name = "PasswdBx";
            this.PasswdBx.PasswordChar = '*';
            this.PasswdBx.Size = new System.Drawing.Size(100, 22);
            this.PasswdBx.TabIndex = 4;
            this.PasswdBx.UseSystemPasswordChar = true;
            // 
            // UsrBx
            // 
            this.UsrBx.Location = new System.Drawing.Point(95, 24);
            this.UsrBx.Name = "UsrBx";
            this.UsrBx.Size = new System.Drawing.Size(100, 22);
            this.UsrBx.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login Panel";
            // 
            // AdminPnL
            // 
            this.AdminPnL.Controls.Add(this.label5);
            this.AdminPnL.Location = new System.Drawing.Point(493, 150);
            this.AdminPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPnL.Name = "AdminPnL";
            this.AdminPnL.Size = new System.Drawing.Size(200, 100);
            this.AdminPnL.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Admin Panel";
            // 
            // usrPnL
            // 
            this.usrPnL.Controls.Add(this.label6);
            this.usrPnL.Location = new System.Drawing.Point(493, 256);
            this.usrPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrPnL.Name = "usrPnL";
            this.usrPnL.Size = new System.Drawing.Size(200, 100);
            this.usrPnL.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "User Panel";
            // 
            // guestPnL
            // 
            this.guestPnL.Controls.Add(this.switchToLoginPnlBtn);
            this.guestPnL.Controls.Add(this.label7);
            this.guestPnL.Controls.Add(this.searchBtN);
            this.guestPnL.Controls.Add(this.listView1);
            this.guestPnL.Controls.Add(this.label3);
            this.guestPnL.Controls.Add(this.label2);
            this.guestPnL.Controls.Add(this.comboBox2);
            this.guestPnL.Controls.Add(this.textBox1);
            this.guestPnL.Controls.Add(this.label1);
            this.guestPnL.Controls.Add(this.comboBox1);
            this.guestPnL.Location = new System.Drawing.Point(0, 0);
            this.guestPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guestPnL.Name = "guestPnL";
            this.guestPnL.Size = new System.Drawing.Size(453, 554);
            this.guestPnL.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Guest Panel Read Only";
            // 
            // searchBtN
            // 
            this.searchBtN.Location = new System.Drawing.Point(283, 150);
            this.searchBtN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtN.Name = "searchBtN";
            this.searchBtN.Size = new System.Drawing.Size(100, 33);
            this.searchBtN.TabIndex = 8;
            this.searchBtN.Text = "SEARCH";
            this.searchBtN.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 192);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 349);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(261, 53);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 53);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // switchToLoginPnlBtn
            // 
            this.switchToLoginPnlBtn.Location = new System.Drawing.Point(69, 155);
            this.switchToLoginPnlBtn.Name = "switchToLoginPnlBtn";
            this.switchToLoginPnlBtn.Size = new System.Drawing.Size(75, 23);
            this.switchToLoginPnlBtn.TabIndex = 11;
            this.switchToLoginPnlBtn.Text = "Login";
            this.switchToLoginPnlBtn.UseVisualStyleBackColor = true;
            this.switchToLoginPnlBtn.Click += new System.EventHandler(this.switchToLoginPnlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 553);
            this.Controls.Add(this.guestPnL);
            this.Controls.Add(this.usrPnL);
            this.Controls.Add(this.AdminPnL);
            this.Controls.Add(this.loginPnL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CD Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPnL.ResumeLayout(false);
            this.loginPnL.PerformLayout();
            this.AdminPnL.ResumeLayout(false);
            this.AdminPnL.PerformLayout();
            this.usrPnL.ResumeLayout(false);
            this.usrPnL.PerformLayout();
            this.guestPnL.ResumeLayout(false);
            this.guestPnL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPnL;
        private System.Windows.Forms.Panel AdminPnL;
        private System.Windows.Forms.Panel usrPnL;
        private System.Windows.Forms.Panel guestPnL;
        private System.Windows.Forms.Button searchBtN;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswdBx;
        private System.Windows.Forms.TextBox UsrBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button switchToLoginPnlBtn;
    }
}

