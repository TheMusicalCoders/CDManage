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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswdBx = new System.Windows.Forms.TextBox();
            this.UsrBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminPnL = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guestPnL = new System.Windows.Forms.Panel();
            this.switchToLoginPnlBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.searchBtN = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usrPnL = new System.Windows.Forms.Panel();
            this.AddCDBtn = new System.Windows.Forms.Button();
            this.uArtistCB = new System.Windows.Forms.ComboBox();
            this.addGenreBx = new System.Windows.Forms.TextBox();
            this.addArtistBx = new System.Windows.Forms.TextBox();
            this.addAlbumBx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lgoutBtn = new System.Windows.Forms.Button();
            this.uSearchBtn = new System.Windows.Forms.Button();
            this.uCDList = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.uSearchBx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.uGenreCB = new System.Windows.Forms.ComboBox();
            this.loginPnL.SuspendLayout();
            this.AdminPnL.SuspendLayout();
            this.guestPnL.SuspendLayout();
            this.usrPnL.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPnL
            // 
            this.loginPnL.Controls.Add(this.CancelBtn);
            this.loginPnL.Controls.Add(this.LoginBtn);
            this.loginPnL.Controls.Add(this.PasswdBx);
            this.loginPnL.Controls.Add(this.UsrBx);
            this.loginPnL.Controls.Add(this.label9);
            this.loginPnL.Controls.Add(this.label8);
            this.loginPnL.Controls.Add(this.label4);
            this.loginPnL.Location = new System.Drawing.Point(493, 27);
            this.loginPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPnL.Name = "loginPnL";
            this.loginPnL.Size = new System.Drawing.Size(453, 554);
            this.loginPnL.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(197, 312);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(197, 223);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 29);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswdBx
            // 
            this.PasswdBx.Location = new System.Drawing.Point(197, 160);
            this.PasswdBx.Name = "PasswdBx";
            this.PasswdBx.PasswordChar = '*';
            this.PasswdBx.Size = new System.Drawing.Size(100, 22);
            this.PasswdBx.TabIndex = 4;
            this.PasswdBx.UseSystemPasswordChar = true;
            // 
            // UsrBx
            // 
            this.UsrBx.Location = new System.Drawing.Point(197, 123);
            this.UsrBx.Name = "UsrBx";
            this.UsrBx.Size = new System.Drawing.Size(100, 22);
            this.UsrBx.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login Panel";
            // 
            // AdminPnL
            // 
            this.AdminPnL.Controls.Add(this.label5);
            this.AdminPnL.Location = new System.Drawing.Point(182, 595);
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
            // usrPnL
            // 
            this.usrPnL.Controls.Add(this.AddCDBtn);
            this.usrPnL.Controls.Add(this.uArtistCB);
            this.usrPnL.Controls.Add(this.addGenreBx);
            this.usrPnL.Controls.Add(this.addArtistBx);
            this.usrPnL.Controls.Add(this.addAlbumBx);
            this.usrPnL.Controls.Add(this.label14);
            this.usrPnL.Controls.Add(this.label10);
            this.usrPnL.Controls.Add(this.label11);
            this.usrPnL.Controls.Add(this.label12);
            this.usrPnL.Controls.Add(this.lgoutBtn);
            this.usrPnL.Controls.Add(this.uSearchBtn);
            this.usrPnL.Controls.Add(this.uCDList);
            this.usrPnL.Controls.Add(this.label13);
            this.usrPnL.Controls.Add(this.label15);
            this.usrPnL.Controls.Add(this.uSearchBx);
            this.usrPnL.Controls.Add(this.label16);
            this.usrPnL.Controls.Add(this.uGenreCB);
            this.usrPnL.Location = new System.Drawing.Point(952, 12);
            this.usrPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrPnL.Name = "usrPnL";
            this.usrPnL.Size = new System.Drawing.Size(453, 665);
            this.usrPnL.TabIndex = 5;
            // 
            // AddCDBtn
            // 
            this.AddCDBtn.Location = new System.Drawing.Point(283, 186);
            this.AddCDBtn.Name = "AddCDBtn";
            this.AddCDBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCDBtn.TabIndex = 19;
            this.AddCDBtn.Text = "Add CD";
            this.AddCDBtn.UseVisualStyleBackColor = true;
            // 
            // uArtistCB
            // 
            this.uArtistCB.FormattingEnabled = true;
            this.uArtistCB.Location = new System.Drawing.Point(263, 51);
            this.uArtistCB.Name = "uArtistCB";
            this.uArtistCB.Size = new System.Drawing.Size(121, 24);
            this.uArtistCB.TabIndex = 18;
            // 
            // addGenreBx
            // 
            this.addGenreBx.Location = new System.Drawing.Point(118, 231);
            this.addGenreBx.Name = "addGenreBx";
            this.addGenreBx.Size = new System.Drawing.Size(100, 22);
            this.addGenreBx.TabIndex = 17;
            // 
            // addArtistBx
            // 
            this.addArtistBx.Location = new System.Drawing.Point(118, 186);
            this.addArtistBx.Name = "addArtistBx";
            this.addArtistBx.Size = new System.Drawing.Size(100, 22);
            this.addArtistBx.TabIndex = 16;
            // 
            // addAlbumBx
            // 
            this.addAlbumBx.Location = new System.Drawing.Point(118, 143);
            this.addAlbumBx.Name = "addAlbumBx";
            this.addAlbumBx.Size = new System.Drawing.Size(100, 22);
            this.addAlbumBx.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Album Genre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Artist\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Add Album";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "User Panel";
            // 
            // lgoutBtn
            // 
            this.lgoutBtn.Location = new System.Drawing.Point(18, 282);
            this.lgoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lgoutBtn.Name = "lgoutBtn";
            this.lgoutBtn.Size = new System.Drawing.Size(103, 28);
            this.lgoutBtn.TabIndex = 9;
            this.lgoutBtn.Text = "Logout";
            this.lgoutBtn.UseVisualStyleBackColor = true;
            this.lgoutBtn.Click += new System.EventHandler(this.LgoutBtn_Click);
            // 
            // uSearchBtn
            // 
            this.uSearchBtn.Location = new System.Drawing.Point(176, 81);
            this.uSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uSearchBtn.Name = "uSearchBtn";
            this.uSearchBtn.Size = new System.Drawing.Size(100, 33);
            this.uSearchBtn.TabIndex = 8;
            this.uSearchBtn.Text = "SEARCH";
            this.uSearchBtn.UseVisualStyleBackColor = true;
            // 
            // uCDList
            // 
            this.uCDList.HideSelection = false;
            this.uCDList.Location = new System.Drawing.Point(19, 314);
            this.uCDList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uCDList.Name = "uCDList";
            this.uCDList.Size = new System.Drawing.Size(413, 349);
            this.uCDList.TabIndex = 7;
            this.uCDList.UseCompatibleStateImageBehavior = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Artist";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Genre";
            // 
            // uSearchBx
            // 
            this.uSearchBx.Location = new System.Drawing.Point(69, 12);
            this.uSearchBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uSearchBx.Name = "uSearchBx";
            this.uSearchBx.Size = new System.Drawing.Size(313, 22);
            this.uSearchBx.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Search";
            // 
            // uGenreCB
            // 
            this.uGenreCB.FormattingEnabled = true;
            this.uGenreCB.Items.AddRange(new object[] {
            "Rock",
            "Rock Alternative",
            "Heavy Metal",
            "Classical",
            "Blues",
            "Jazz",
            "Instrumental",
            "Techno",
            "Country",
            "Pop",
            "Hip-Hop",
            "Gospel"});
            this.uGenreCB.Location = new System.Drawing.Point(69, 53);
            this.uGenreCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uGenreCB.Name = "uGenreCB";
            this.uGenreCB.Size = new System.Drawing.Size(121, 24);
            this.uGenreCB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 706);
            this.Controls.Add(this.usrPnL);
            this.Controls.Add(this.guestPnL);
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
            this.guestPnL.ResumeLayout(false);
            this.guestPnL.PerformLayout();
            this.usrPnL.ResumeLayout(false);
            this.usrPnL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPnL;
        private System.Windows.Forms.Panel AdminPnL;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswdBx;
        private System.Windows.Forms.TextBox UsrBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button switchToLoginPnlBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel usrPnL;
        private System.Windows.Forms.Button AddCDBtn;
        private System.Windows.Forms.ComboBox uArtistCB;
        private System.Windows.Forms.TextBox addGenreBx;
        private System.Windows.Forms.TextBox addArtistBx;
        private System.Windows.Forms.TextBox addAlbumBx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button lgoutBtn;
        private System.Windows.Forms.Button uSearchBtn;
        private System.Windows.Forms.ListView uCDList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox uSearchBx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uGenreCB;
    }
}

