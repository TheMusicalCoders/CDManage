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
            this.addCdPnL = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCDBtn = new System.Windows.Forms.Button();
            this.addGenreBx = new System.Windows.Forms.TextBox();
            this.addArtistBx = new System.Windows.Forms.TextBox();
            this.addAlbumBx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lgoutBtn = new System.Windows.Forms.Button();
            this.AdminPnL = new System.Windows.Forms.Panel();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.RemovePermissionBtn = new System.Windows.Forms.Button();
            this.AddPermissionBtn = new System.Windows.Forms.Button();
            this.SelectedUserBx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UserListBx = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SwitchToAdminPnlBtn = new System.Windows.Forms.Button();
            this.loginPnL.SuspendLayout();
            this.guestPnL.SuspendLayout();
            this.addCdPnL.SuspendLayout();
            this.AdminPnL.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPnL
            // 
            this.loginPnL.Controls.Add(this.SwitchToAdminPnlBtn);
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
            this.CancelBtn.Location = new System.Drawing.Point(197, 313);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 30);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswdBx
            // 
            this.PasswdBx.Location = new System.Drawing.Point(197, 160);
            this.PasswdBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswdBx.Name = "PasswdBx";
            this.PasswdBx.PasswordChar = '*';
            this.PasswdBx.Size = new System.Drawing.Size(100, 22);
            this.PasswdBx.TabIndex = 4;
            this.PasswdBx.UseSystemPasswordChar = true;
            // 
            // UsrBx
            // 
            this.UsrBx.Location = new System.Drawing.Point(197, 123);
            this.UsrBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsrBx.Name = "UsrBx";
            this.UsrBx.Size = new System.Drawing.Size(100, 22);
            this.UsrBx.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login Panel";
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
            this.switchToLoginPnlBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // addCdPnL
            // 
            this.addCdPnL.Controls.Add(this.textBox3);
            this.addCdPnL.Controls.Add(this.textBox2);
            this.addCdPnL.Controls.Add(this.label15);
            this.addCdPnL.Controls.Add(this.label13);
            this.addCdPnL.Controls.Add(this.label6);
            this.addCdPnL.Controls.Add(this.AddCDBtn);
            this.addCdPnL.Controls.Add(this.addGenreBx);
            this.addCdPnL.Controls.Add(this.addArtistBx);
            this.addCdPnL.Controls.Add(this.addAlbumBx);
            this.addCdPnL.Controls.Add(this.label14);
            this.addCdPnL.Controls.Add(this.label10);
            this.addCdPnL.Controls.Add(this.label11);
            this.addCdPnL.Controls.Add(this.label12);
            this.addCdPnL.Controls.Add(this.lgoutBtn);
            this.addCdPnL.Location = new System.Drawing.Point(988, 150);
            this.addCdPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCdPnL.Name = "addCdPnL";
            this.addCdPnL.Size = new System.Drawing.Size(453, 194);
            this.addCdPnL.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 55);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 22);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 22);
            this.textBox2.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 59);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Total Tracks ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Album Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Add CD Panel";
            // 
            // AddCDBtn
            // 
            this.AddCDBtn.Location = new System.Drawing.Point(104, 145);
            this.AddCDBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCDBtn.Name = "AddCDBtn";
            this.AddCDBtn.Size = new System.Drawing.Size(103, 28);
            this.AddCDBtn.TabIndex = 19;
            this.AddCDBtn.Text = "Add CD";
            this.AddCDBtn.UseVisualStyleBackColor = true;
            // 
            // addGenreBx
            // 
            this.addGenreBx.Location = new System.Drawing.Point(109, 101);
            this.addGenreBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addGenreBx.Name = "addGenreBx";
            this.addGenreBx.Size = new System.Drawing.Size(100, 22);
            this.addGenreBx.TabIndex = 17;
            // 
            // addArtistBx
            // 
            this.addArtistBx.Location = new System.Drawing.Point(109, 55);
            this.addArtistBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addArtistBx.Name = "addArtistBx";
            this.addArtistBx.Size = new System.Drawing.Size(100, 22);
            this.addArtistBx.TabIndex = 16;
            // 
            // addAlbumBx
            // 
            this.addAlbumBx.Location = new System.Drawing.Point(109, 12);
            this.addAlbumBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAlbumBx.Name = "addAlbumBx";
            this.addAlbumBx.Size = new System.Drawing.Size(100, 22);
            this.addAlbumBx.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Album Genre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Artist\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Add Album";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Add CD Panel";
            // 
            // lgoutBtn
            // 
            this.lgoutBtn.Location = new System.Drawing.Point(229, 145);
            this.lgoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lgoutBtn.Name = "lgoutBtn";
            this.lgoutBtn.Size = new System.Drawing.Size(103, 28);
            this.lgoutBtn.TabIndex = 9;
            this.lgoutBtn.Text = "Cancel";
            this.lgoutBtn.UseVisualStyleBackColor = true;
            this.lgoutBtn.Click += new System.EventHandler(this.LgoutBtn_Click);
            // 
            // AdminPnL
            // 
            this.AdminPnL.Controls.Add(this.ReturnBtn);
            this.AdminPnL.Controls.Add(this.label17);
            this.AdminPnL.Controls.Add(this.RemovePermissionBtn);
            this.AdminPnL.Controls.Add(this.AddPermissionBtn);
            this.AdminPnL.Controls.Add(this.SelectedUserBx);
            this.AdminPnL.Controls.Add(this.label16);
            this.AdminPnL.Controls.Add(this.UserListBx);
            this.AdminPnL.Controls.Add(this.label5);
            this.AdminPnL.Location = new System.Drawing.Point(988, 371);
            this.AdminPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPnL.Name = "AdminPnL";
            this.AdminPnL.Size = new System.Drawing.Size(312, 347);
            this.AdminPnL.TabIndex = 6;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(6, 312);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Selected User:";
            // 
            // RemovePermissionBtn
            // 
            this.RemovePermissionBtn.Location = new System.Drawing.Point(110, 291);
            this.RemovePermissionBtn.Name = "RemovePermissionBtn";
            this.RemovePermissionBtn.Size = new System.Drawing.Size(180, 23);
            this.RemovePermissionBtn.TabIndex = 6;
            this.RemovePermissionBtn.Text = "Remove Edit Permissions";
            this.RemovePermissionBtn.UseVisualStyleBackColor = true;
            this.RemovePermissionBtn.Click += new System.EventHandler(this.RemovePermissionBtn_Click_1);
            // 
            // AddPermissionBtn
            // 
            this.AddPermissionBtn.Location = new System.Drawing.Point(110, 262);
            this.AddPermissionBtn.Name = "AddPermissionBtn";
            this.AddPermissionBtn.Size = new System.Drawing.Size(180, 23);
            this.AddPermissionBtn.TabIndex = 5;
            this.AddPermissionBtn.Text = "Give Edit Permissions";
            this.AddPermissionBtn.UseVisualStyleBackColor = true;
            this.AddPermissionBtn.Click += new System.EventHandler(this.AddPermissionBtn_Click_1);
            // 
            // SelectedUserBx
            // 
            this.SelectedUserBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SelectedUserBx.Location = new System.Drawing.Point(110, 234);
            this.SelectedUserBx.Name = "SelectedUserBx";
            this.SelectedUserBx.Size = new System.Drawing.Size(180, 22);
            this.SelectedUserBx.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Users:";
            // 
            // UserListBx
            // 
            this.UserListBx.FormattingEnabled = true;
            this.UserListBx.ItemHeight = 16;
            this.UserListBx.Items.AddRange(new object[] {
            "User1",
            "User2",
            "User3"});
            this.UserListBx.Location = new System.Drawing.Point(110, 128);
            this.UserListBx.Name = "UserListBx";
            this.UserListBx.Size = new System.Drawing.Size(180, 84);
            this.UserListBx.TabIndex = 2;
            this.UserListBx.SelectedIndexChanged += new System.EventHandler(this.UserListBx_SelectedIndexChanged);
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
            // SwitchToAdminPnlBtn
            // 
            this.SwitchToAdminPnlBtn.Location = new System.Drawing.Point(197, 272);
            this.SwitchToAdminPnlBtn.Name = "SwitchToAdminPnlBtn";
            this.SwitchToAdminPnlBtn.Size = new System.Drawing.Size(75, 23);
            this.SwitchToAdminPnlBtn.TabIndex = 7;
            this.SwitchToAdminPnlBtn.Text = "button1";
            this.SwitchToAdminPnlBtn.UseVisualStyleBackColor = true;
            this.SwitchToAdminPnlBtn.Click += new System.EventHandler(this.SwitchToAdminPnlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 706);
            this.Controls.Add(this.AdminPnL);
            this.Controls.Add(this.addCdPnL);
            this.Controls.Add(this.guestPnL);
            this.Controls.Add(this.loginPnL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CD Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPnL.ResumeLayout(false);
            this.loginPnL.PerformLayout();
            this.guestPnL.ResumeLayout(false);
            this.guestPnL.PerformLayout();
            this.addCdPnL.ResumeLayout(false);
            this.addCdPnL.PerformLayout();
            this.AdminPnL.ResumeLayout(false);
            this.AdminPnL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPnL;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswdBx;
        private System.Windows.Forms.TextBox UsrBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button switchToLoginPnlBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel addCdPnL;
        private System.Windows.Forms.Button AddCDBtn;
        private System.Windows.Forms.TextBox addGenreBx;
        private System.Windows.Forms.TextBox addArtistBx;
        private System.Windows.Forms.TextBox addAlbumBx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button lgoutBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel AdminPnL;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button RemovePermissionBtn;
        private System.Windows.Forms.Button AddPermissionBtn;
        private System.Windows.Forms.TextBox SelectedUserBx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox UserListBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SwitchToAdminPnlBtn;
    }
}

