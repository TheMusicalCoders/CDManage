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
            this.label4 = new System.Windows.Forms.Label();
            this.AdminPnL = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.usrPnL = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guestPnL = new System.Windows.Forms.Panel();
            this.ArtistTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.CDList = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreCB = new System.Windows.Forms.ComboBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.uLoginBtn = new System.Windows.Forms.Button();
            this.loginPnL.SuspendLayout();
            this.AdminPnL.SuspendLayout();
            this.usrPnL.SuspendLayout();
            this.guestPnL.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPnL
            // 
            this.loginPnL.Controls.Add(this.uLoginBtn);
            this.loginPnL.Controls.Add(this.passwordBox);
            this.loginPnL.Controls.Add(this.label8);
            this.loginPnL.Controls.Add(this.UsernameLbl);
            this.loginPnL.Controls.Add(this.usernameBox);
            this.loginPnL.Controls.Add(this.label4);
            this.loginPnL.Location = new System.Drawing.Point(493, 27);
            this.loginPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPnL.Name = "loginPnL";
            this.loginPnL.Size = new System.Drawing.Size(396, 151);
            this.loginPnL.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login Panel";
            // 
            // AdminPnL
            // 
            this.AdminPnL.Controls.Add(this.label5);
            this.AdminPnL.Location = new System.Drawing.Point(493, 192);
            this.AdminPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPnL.Name = "AdminPnL";
            this.AdminPnL.Size = new System.Drawing.Size(396, 239);
            this.AdminPnL.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Admin Panel";
            // 
            // usrPnL
            // 
            this.usrPnL.Controls.Add(this.label6);
            this.usrPnL.Location = new System.Drawing.Point(493, 444);
            this.usrPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrPnL.Name = "usrPnL";
            this.usrPnL.Size = new System.Drawing.Size(396, 205);
            this.usrPnL.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "User Panel";
            // 
            // guestPnL
            // 
            this.guestPnL.Controls.Add(this.ArtistTB);
            this.guestPnL.Controls.Add(this.label7);
            this.guestPnL.Controls.Add(this.LoginBtn);
            this.guestPnL.Controls.Add(this.searchBtn);
            this.guestPnL.Controls.Add(this.CDList);
            this.guestPnL.Controls.Add(this.label3);
            this.guestPnL.Controls.Add(this.label2);
            this.guestPnL.Controls.Add(this.SearchBox);
            this.guestPnL.Controls.Add(this.label1);
            this.guestPnL.Controls.Add(this.GenreCB);
            this.guestPnL.Location = new System.Drawing.Point(0, 0);
            this.guestPnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guestPnL.Name = "guestPnL";
            this.guestPnL.Size = new System.Drawing.Size(453, 554);
            this.guestPnL.TabIndex = 3;
            // 
            // ArtistTB
            // 
            this.ArtistTB.Location = new System.Drawing.Point(263, 54);
            this.ArtistTB.Name = "ArtistTB";
            this.ArtistTB.Size = new System.Drawing.Size(100, 22);
            this.ArtistTB.TabIndex = 11;
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
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(19, 150);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(103, 28);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(283, 150);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 33);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // CDList
            // 
            this.CDList.HideSelection = false;
            this.CDList.Location = new System.Drawing.Point(19, 192);
            this.CDList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CDList.Name = "CDList";
            this.CDList.Size = new System.Drawing.Size(413, 349);
            this.CDList.TabIndex = 7;
            this.CDList.UseCompatibleStateImageBehavior = false;
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
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(69, 12);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(313, 22);
            this.SearchBox.TabIndex = 2;
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
            // GenreCB
            // 
            this.GenreCB.FormattingEnabled = true;
            this.GenreCB.Items.AddRange(new object[] {
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
            this.GenreCB.Location = new System.Drawing.Point(69, 53);
            this.GenreCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreCB.Name = "GenreCB";
            this.GenreCB.Size = new System.Drawing.Size(121, 24);
            this.GenreCB.TabIndex = 0;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(83, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 22);
            this.usernameBox.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(4, 4);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(73, 17);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(83, 39);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 22);
            this.passwordBox.TabIndex = 4;
            // 
            // uLoginBtn
            // 
            this.uLoginBtn.Location = new System.Drawing.Point(83, 76);
            this.uLoginBtn.Name = "uLoginBtn";
            this.uLoginBtn.Size = new System.Drawing.Size(75, 30);
            this.uLoginBtn.TabIndex = 5;
            this.uLoginBtn.Text = "Login";
            this.uLoginBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 675);
            this.Controls.Add(this.guestPnL);
            this.Controls.Add(this.usrPnL);
            this.Controls.Add(this.AdminPnL);
            this.Controls.Add(this.loginPnL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView CDList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenreCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ArtistTB;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Button uLoginBtn;
    }
}

