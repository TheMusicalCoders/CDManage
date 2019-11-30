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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginPnl = new System.Windows.Forms.Panel();
            this.InvLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswdBx = new System.Windows.Forms.TextBox();
            this.UsrBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNewUsrEmail = new System.Windows.Forms.TextBox();
            this.txtNewUsrPwd = new System.Windows.Forms.TextBox();
            this.txtNewUsrName = new System.Windows.Forms.TextBox();
            this.cdEditPnl = new System.Windows.Forms.Panel();
            this.SongListView = new System.Windows.Forms.ListView();
            this.SongNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clrBtn = new System.Windows.Forms.Button();
            this.searchBtN = new System.Windows.Forms.Button();
            this.ResultsList = new System.Windows.Forms.ListView();
            this.ArtistCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArtistComboBx = new System.Windows.Forms.ComboBox();
            this.searchBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreComboBx = new System.Windows.Forms.ComboBox();
            this.addCdPnl = new System.Windows.Forms.Panel();
            this.AddSongBx = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TrackNumBx = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddCDBtn = new System.Windows.Forms.Button();
            this.addGenreBx = new System.Windows.Forms.TextBox();
            this.addArtistBx = new System.Windows.Forms.TextBox();
            this.addAlbumBx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SignUpPnl = new System.Windows.Forms.Panel();
            this.newUsrLbl = new System.Windows.Forms.Label();
            this.AdminPnl = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.RemovePermissionBtn = new System.Windows.Forms.Button();
            this.AddPermissionBtn = new System.Windows.Forms.Button();
            this.SelectedUserBx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UserListBx = new System.Windows.Forms.ListBox();
            this.cdManagermns = new System.Windows.Forms.MenuStrip();
            this.switchToCdeditPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchToAddCdPanleTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.SwtichToLoginPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToAdminPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPnl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.cdEditPnl.SuspendLayout();
            this.addCdPnl.SuspendLayout();
            this.SignUpPnl.SuspendLayout();
            this.AdminPnl.SuspendLayout();
            this.cdManagermns.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPnl
            // 
            this.loginPnl.Controls.Add(this.InvLbl);
            this.loginPnl.Controls.Add(this.LoginBtn);
            this.loginPnl.Controls.Add(this.PasswdBx);
            this.loginPnl.Controls.Add(this.UsrBx);
            this.loginPnl.Controls.Add(this.label9);
            this.loginPnl.Controls.Add(this.label8);
            this.loginPnl.Location = new System.Drawing.Point(732, 393);
            this.loginPnl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Size = new System.Drawing.Size(273, 219);
            this.loginPnl.TabIndex = 0;
            // 
            // InvLbl
            // 
            this.InvLbl.AutoSize = true;
            this.InvLbl.ForeColor = System.Drawing.Color.Red;
            this.InvLbl.Location = new System.Drawing.Point(86, 147);
            this.InvLbl.Name = "InvLbl";
            this.InvLbl.Size = new System.Drawing.Size(0, 17);
            this.InvLbl.TabIndex = 7;
            this.InvLbl.Visible = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(118, 124);
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
            this.PasswdBx.Location = new System.Drawing.Point(118, 77);
            this.PasswdBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswdBx.Name = "PasswdBx";
            this.PasswdBx.PasswordChar = '*';
            this.PasswdBx.Size = new System.Drawing.Size(100, 22);
            this.PasswdBx.TabIndex = 4;
            this.PasswdBx.UseSystemPasswordChar = true;
            this.PasswdBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswdBx_KeyPress);
            // 
            // UsrBx
            // 
            this.UsrBx.Location = new System.Drawing.Point(118, 39);
            this.UsrBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsrBx.Name = "UsrBx";
            this.UsrBx.Size = new System.Drawing.Size(100, 22);
            this.UsrBx.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(174, 129);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 33);
            this.signUpBtn.TabIndex = 15;
            this.signUpBtn.Text = "Sign Up!";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(53, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(53, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Password:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Username:";
            // 
            // txtNewUsrEmail
            // 
            this.txtNewUsrEmail.Location = new System.Drawing.Point(174, 101);
            this.txtNewUsrEmail.Name = "txtNewUsrEmail";
            this.txtNewUsrEmail.Size = new System.Drawing.Size(100, 22);
            this.txtNewUsrEmail.TabIndex = 10;
            // 
            // txtNewUsrPwd
            // 
            this.txtNewUsrPwd.Location = new System.Drawing.Point(174, 73);
            this.txtNewUsrPwd.Name = "txtNewUsrPwd";
            this.txtNewUsrPwd.Size = new System.Drawing.Size(100, 22);
            this.txtNewUsrPwd.TabIndex = 9;
            // 
            // txtNewUsrName
            // 
            this.txtNewUsrName.Location = new System.Drawing.Point(174, 45);
            this.txtNewUsrName.Name = "txtNewUsrName";
            this.txtNewUsrName.Size = new System.Drawing.Size(100, 22);
            this.txtNewUsrName.TabIndex = 8;
            // 
            // cdEditPnl
            // 
            this.cdEditPnl.Controls.Add(this.SongListView);
            this.cdEditPnl.Controls.Add(this.clrBtn);
            this.cdEditPnl.Controls.Add(this.searchBtN);
            this.cdEditPnl.Controls.Add(this.ResultsList);
            this.cdEditPnl.Controls.Add(this.label3);
            this.cdEditPnl.Controls.Add(this.label2);
            this.cdEditPnl.Controls.Add(this.ArtistComboBx);
            this.cdEditPnl.Controls.Add(this.searchBx);
            this.cdEditPnl.Controls.Add(this.label1);
            this.cdEditPnl.Controls.Add(this.GenreComboBx);
            this.cdEditPnl.Location = new System.Drawing.Point(12, 42);
            this.cdEditPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cdEditPnl.Name = "cdEditPnl";
            this.cdEditPnl.Size = new System.Drawing.Size(700, 550);
            this.cdEditPnl.TabIndex = 3;
            // 
            // SongListView
            // 
            this.SongListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SongNameCol,
            this.TrackNum});
            this.SongListView.HideSelection = false;
            this.SongListView.Location = new System.Drawing.Point(434, 138);
            this.SongListView.Name = "SongListView";
            this.SongListView.Size = new System.Drawing.Size(261, 349);
            this.SongListView.TabIndex = 9;
            this.SongListView.UseCompatibleStateImageBehavior = false;
            // 
            // SongNameCol
            // 
            this.SongNameCol.Text = "Song Name";
            // 
            // TrackNum
            // 
            this.TrackNum.Text = "Track";
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(537, 46);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(100, 34);
            this.clrBtn.TabIndex = 4;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // searchBtN
            // 
            this.searchBtN.Location = new System.Drawing.Point(413, 46);
            this.searchBtN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtN.Name = "searchBtN";
            this.searchBtN.Size = new System.Drawing.Size(100, 33);
            this.searchBtN.TabIndex = 3;
            this.searchBtN.Text = "Search";
            this.searchBtN.UseVisualStyleBackColor = true;
            this.searchBtN.Click += new System.EventHandler(this.searchBtN_Click);
            // 
            // ResultsList
            // 
            this.ResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArtistCol,
            this.AlbumCol,
            this.GenreCol,
            this.DateCol});
            this.ResultsList.HideSelection = false;
            this.ResultsList.Location = new System.Drawing.Point(19, 138);
            this.ResultsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultsList.MultiSelect = false;
            this.ResultsList.Name = "ResultsList";
            this.ResultsList.Size = new System.Drawing.Size(413, 349);
            this.ResultsList.TabIndex = 8;
            this.ResultsList.UseCompatibleStateImageBehavior = false;
            this.ResultsList.SelectedIndexChanged += new System.EventHandler(this.ResultsList_SelectedIndexChanged);
            // 
            // ArtistCol
            // 
            this.ArtistCol.DisplayIndex = 1;
            this.ArtistCol.Text = "Artist";
            // 
            // AlbumCol
            // 
            this.AlbumCol.DisplayIndex = 0;
            this.AlbumCol.Text = "Album";
            // 
            // GenreCol
            // 
            this.GenreCol.Text = "Genre";
            // 
            // DateCol
            // 
            this.DateCol.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // ArtistComboBx
            // 
            this.ArtistComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArtistComboBx.FormattingEnabled = true;
            this.ArtistComboBx.Location = new System.Drawing.Point(261, 70);
            this.ArtistComboBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArtistComboBx.Name = "ArtistComboBx";
            this.ArtistComboBx.Size = new System.Drawing.Size(121, 24);
            this.ArtistComboBx.TabIndex = 2;
            // 
            // searchBx
            // 
            this.searchBx.Location = new System.Drawing.Point(69, 29);
            this.searchBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBx.Name = "searchBx";
            this.searchBx.Size = new System.Drawing.Size(313, 22);
            this.searchBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // GenreComboBx
            // 
            this.GenreComboBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.GenreComboBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GenreComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBx.FormattingEnabled = true;
            this.GenreComboBx.Location = new System.Drawing.Point(69, 70);
            this.GenreComboBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreComboBx.Name = "GenreComboBx";
            this.GenreComboBx.Size = new System.Drawing.Size(121, 24);
            this.GenreComboBx.Sorted = true;
            this.GenreComboBx.TabIndex = 1;
            // 
            // addCdPnl
            // 
            this.addCdPnl.Controls.Add(this.AddSongBx);
            this.addCdPnl.Controls.Add(this.dateTimePicker1);
            this.addCdPnl.Controls.Add(this.TrackNumBx);
            this.addCdPnl.Controls.Add(this.label15);
            this.addCdPnl.Controls.Add(this.label13);
            this.addCdPnl.Controls.Add(this.AddCDBtn);
            this.addCdPnl.Controls.Add(this.addGenreBx);
            this.addCdPnl.Controls.Add(this.addArtistBx);
            this.addCdPnl.Controls.Add(this.addAlbumBx);
            this.addCdPnl.Controls.Add(this.label14);
            this.addCdPnl.Controls.Add(this.label10);
            this.addCdPnl.Controls.Add(this.label11);
            this.addCdPnl.Controls.Add(this.label12);
            this.addCdPnl.Location = new System.Drawing.Point(732, 30);
            this.addCdPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCdPnl.Name = "addCdPnl";
            this.addCdPnl.Size = new System.Drawing.Size(453, 359);
            this.addCdPnl.TabIndex = 5;
            // 
            // AddSongBx
            // 
            this.AddSongBx.Location = new System.Drawing.Point(318, 191);
            this.AddSongBx.Name = "AddSongBx";
            this.AddSongBx.Size = new System.Drawing.Size(100, 96);
            this.AddSongBx.TabIndex = 26;
            this.AddSongBx.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // TrackNumBx
            // 
            this.TrackNumBx.Location = new System.Drawing.Point(331, 79);
            this.TrackNumBx.Margin = new System.Windows.Forms.Padding(4);
            this.TrackNumBx.Name = "TrackNumBx";
            this.TrackNumBx.Size = new System.Drawing.Size(101, 22);
            this.TrackNumBx.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Total Tracks ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Album Year";
            // 
            // AddCDBtn
            // 
            this.AddCDBtn.Location = new System.Drawing.Point(106, 188);
            this.AddCDBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCDBtn.Name = "AddCDBtn";
            this.AddCDBtn.Size = new System.Drawing.Size(103, 28);
            this.AddCDBtn.TabIndex = 19;
            this.AddCDBtn.Text = "Add CD";
            this.AddCDBtn.UseVisualStyleBackColor = true;
            this.AddCDBtn.Click += new System.EventHandler(this.AddCDBtn_Click);
            // 
            // addGenreBx
            // 
            this.addGenreBx.Location = new System.Drawing.Point(109, 125);
            this.addGenreBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addGenreBx.Name = "addGenreBx";
            this.addGenreBx.Size = new System.Drawing.Size(100, 22);
            this.addGenreBx.TabIndex = 17;
            // 
            // addArtistBx
            // 
            this.addArtistBx.Location = new System.Drawing.Point(109, 79);
            this.addArtistBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addArtistBx.Name = "addArtistBx";
            this.addArtistBx.Size = new System.Drawing.Size(100, 22);
            this.addArtistBx.TabIndex = 16;
            // 
            // addAlbumBx
            // 
            this.addAlbumBx.Location = new System.Drawing.Point(109, 36);
            this.addAlbumBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAlbumBx.Name = "addAlbumBx";
            this.addAlbumBx.Size = new System.Drawing.Size(100, 22);
            this.addAlbumBx.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Album Genre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Artist\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 41);
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
            // SignUpPnl
            // 
            this.SignUpPnl.Controls.Add(this.newUsrLbl);
            this.SignUpPnl.Controls.Add(this.label21);
            this.SignUpPnl.Controls.Add(this.signUpBtn);
            this.SignUpPnl.Controls.Add(this.label20);
            this.SignUpPnl.Controls.Add(this.txtNewUsrName);
            this.SignUpPnl.Controls.Add(this.label19);
            this.SignUpPnl.Controls.Add(this.txtNewUsrPwd);
            this.SignUpPnl.Controls.Add(this.txtNewUsrEmail);
            this.SignUpPnl.Location = new System.Drawing.Point(1529, 31);
            this.SignUpPnl.Name = "SignUpPnl";
            this.SignUpPnl.Size = new System.Drawing.Size(312, 347);
            this.SignUpPnl.TabIndex = 13;
            // 
            // newUsrLbl
            // 
            this.newUsrLbl.AutoSize = true;
            this.newUsrLbl.Location = new System.Drawing.Point(53, 161);
            this.newUsrLbl.Name = "newUsrLbl";
            this.newUsrLbl.Size = new System.Drawing.Size(0, 17);
            this.newUsrLbl.TabIndex = 16;
            // 
            // AdminPnl
            // 
            this.AdminPnl.Controls.Add(this.label17);
            this.AdminPnl.Controls.Add(this.RemovePermissionBtn);
            this.AdminPnl.Controls.Add(this.AddPermissionBtn);
            this.AdminPnl.Controls.Add(this.SelectedUserBx);
            this.AdminPnl.Controls.Add(this.label16);
            this.AdminPnl.Controls.Add(this.UserListBx);
            this.AdminPnl.Location = new System.Drawing.Point(1211, 30);
            this.AdminPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPnl.Name = "AdminPnl";
            this.AdminPnl.Size = new System.Drawing.Size(312, 347);
            this.AdminPnl.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Selected User:";
            // 
            // RemovePermissionBtn
            // 
            this.RemovePermissionBtn.Location = new System.Drawing.Point(110, 222);
            this.RemovePermissionBtn.Name = "RemovePermissionBtn";
            this.RemovePermissionBtn.Size = new System.Drawing.Size(180, 23);
            this.RemovePermissionBtn.TabIndex = 6;
            this.RemovePermissionBtn.Text = "Remove Edit Permissions";
            this.RemovePermissionBtn.UseVisualStyleBackColor = true;
            this.RemovePermissionBtn.Click += new System.EventHandler(this.RemovePermissionBtn_Click_1);
            // 
            // AddPermissionBtn
            // 
            this.AddPermissionBtn.Location = new System.Drawing.Point(110, 193);
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
            this.SelectedUserBx.Location = new System.Drawing.Point(110, 157);
            this.SelectedUserBx.Name = "SelectedUserBx";
            this.SelectedUserBx.Size = new System.Drawing.Size(180, 22);
            this.SelectedUserBx.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Users:";
            // 
            // UserListBx
            // 
            this.UserListBx.FormattingEnabled = true;
            this.UserListBx.ItemHeight = 16;
            this.UserListBx.Location = new System.Drawing.Point(110, 46);
            this.UserListBx.Name = "UserListBx";
            this.UserListBx.Size = new System.Drawing.Size(180, 84);
            this.UserListBx.TabIndex = 2;
            this.UserListBx.SelectedIndexChanged += new System.EventHandler(this.UserListBx_SelectedIndexChanged);
            // 
            // cdManagermns
            // 
            this.cdManagermns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cdManagermns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToCdeditPanelTsr,
            this.SwitchToAddCdPanleTsr,
            this.SwtichToLoginPanelTsr,
            this.currentUserTsr,
            this.exitTsr});
            this.cdManagermns.Location = new System.Drawing.Point(0, 0);
            this.cdManagermns.Name = "cdManagermns";
            this.cdManagermns.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.cdManagermns.Size = new System.Drawing.Size(1924, 28);
            this.cdManagermns.TabIndex = 12;
            this.cdManagermns.Text = "CDmns";
            // 
            // switchToCdeditPanelTsr
            // 
            this.switchToCdeditPanelTsr.Name = "switchToCdeditPanelTsr";
            this.switchToCdeditPanelTsr.Size = new System.Drawing.Size(65, 24);
            this.switchToCdeditPanelTsr.Text = "Search";
            this.switchToCdeditPanelTsr.Click += new System.EventHandler(this.SwitchToCdeditPanelTsr_Click);
            // 
            // SwitchToAddCdPanleTsr
            // 
            this.SwitchToAddCdPanleTsr.Name = "SwitchToAddCdPanleTsr";
            this.SwitchToAddCdPanleTsr.Size = new System.Drawing.Size(73, 24);
            this.SwitchToAddCdPanleTsr.Text = "Add CD";
            this.SwitchToAddCdPanleTsr.Click += new System.EventHandler(this.SwitchToAddCdPnl_Click);
            // 
            // SwtichToLoginPanelTsr
            // 
            this.SwtichToLoginPanelTsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.signUpToolStripMenuItem});
            this.SwtichToLoginPanelTsr.Name = "SwtichToLoginPanelTsr";
            this.SwtichToLoginPanelTsr.Size = new System.Drawing.Size(58, 24);
            this.SwtichToLoginPanelTsr.Text = "Login";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.signUpToolStripMenuItem.Text = "Sign Up";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // currentUserTsr
            // 
            this.currentUserTsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToAdminPanelTsr,
            this.logoutTsr});
            this.currentUserTsr.Name = "currentUserTsr";
            this.currentUserTsr.Size = new System.Drawing.Size(102, 24);
            this.currentUserTsr.Text = "Current User";
            // 
            // switchToAdminPanelTsr
            // 
            this.switchToAdminPanelTsr.Name = "switchToAdminPanelTsr";
            this.switchToAdminPanelTsr.Size = new System.Drawing.Size(190, 26);
            this.switchToAdminPanelTsr.Text = "Edit Permissions";
            this.switchToAdminPanelTsr.Click += new System.EventHandler(this.switchToAdminPanelTsr_Click);
            // 
            // logoutTsr
            // 
            this.logoutTsr.Name = "logoutTsr";
            this.logoutTsr.Size = new System.Drawing.Size(190, 26);
            this.logoutTsr.Text = "Logout";
            this.logoutTsr.Click += new System.EventHandler(this.logoutTsr_Click);
            // 
            // exitTsr
            // 
            this.exitTsr.Name = "exitTsr";
            this.exitTsr.Size = new System.Drawing.Size(45, 24);
            this.exitTsr.Text = "Exit";
            this.exitTsr.Click += new System.EventHandler(this.exitTsr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1924, 724);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.loginPnl);
            this.Controls.Add(this.SignUpPnl);
            this.Controls.Add(this.addCdPnl);
            this.Controls.Add(this.cdManagermns);
            this.Controls.Add(this.AdminPnl);
            this.Controls.Add(this.cdEditPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.cdManagermns;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CD Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPnl.ResumeLayout(false);
            this.loginPnl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.cdEditPnl.ResumeLayout(false);
            this.cdEditPnl.PerformLayout();
            this.addCdPnl.ResumeLayout(false);
            this.addCdPnl.PerformLayout();
            this.SignUpPnl.ResumeLayout(false);
            this.SignUpPnl.PerformLayout();
            this.AdminPnl.ResumeLayout(false);
            this.AdminPnl.PerformLayout();
            this.cdManagermns.ResumeLayout(false);
            this.cdManagermns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPnl;
        private System.Windows.Forms.Panel cdEditPnl;
        private System.Windows.Forms.Button searchBtN;
        private System.Windows.Forms.ListView ResultsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ArtistComboBx;
        private System.Windows.Forms.TextBox searchBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenreComboBx;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswdBx;
        private System.Windows.Forms.TextBox UsrBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel addCdPnl;
        private System.Windows.Forms.Button AddCDBtn;
        private System.Windows.Forms.TextBox addGenreBx;
        private System.Windows.Forms.TextBox addArtistBx;
        private System.Windows.Forms.TextBox addAlbumBx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TrackNumBx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel AdminPnl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button RemovePermissionBtn;
        private System.Windows.Forms.Button AddPermissionBtn;
        private System.Windows.Forms.TextBox SelectedUserBx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox UserListBx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label InvLbl;
        private System.Windows.Forms.ColumnHeader ArtistCol;
        private System.Windows.Forms.ColumnHeader GenreCol;
        private System.Windows.Forms.ColumnHeader AlbumCol;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNewUsrEmail;
        private System.Windows.Forms.TextBox txtNewUsrPwd;
        private System.Windows.Forms.TextBox txtNewUsrName;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.ColumnHeader DateCol;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ListView SongListView;
        private System.Windows.Forms.ColumnHeader SongNameCol;
        private System.Windows.Forms.ColumnHeader TrackNum;
        private System.Windows.Forms.RichTextBox AddSongBx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip cdManagermns;
        private System.Windows.Forms.ToolStripMenuItem switchToCdeditPanelTsr;
        private System.Windows.Forms.ToolStripMenuItem SwtichToLoginPanelTsr;
        private System.Windows.Forms.ToolStripMenuItem exitTsr;
        private System.Windows.Forms.ToolStripMenuItem SwitchToAddCdPanleTsr;
        private System.Windows.Forms.ToolStripMenuItem currentUserTsr;
        private System.Windows.Forms.ToolStripMenuItem switchToAdminPanelTsr;
        private System.Windows.Forms.ToolStripMenuItem logoutTsr;
        private System.Windows.Forms.Panel SignUpPnl;
        private System.Windows.Forms.Label newUsrLbl;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
    }
}

