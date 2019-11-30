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
            this.InvalidLoginLbl = new System.Windows.Forms.Label();
            this.InvLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswdBx = new System.Windows.Forms.TextBox();
            this.UsrBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cdEditPnl = new System.Windows.Forms.Panel();
            this.SongListView = new System.Windows.Forms.DataGridView();
            this.ResultsList = new System.Windows.Forms.DataGridView();
            this.clrBtn = new System.Windows.Forms.Button();
            this.searchBtN = new System.Windows.Forms.Button();
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
            this.AdminPnl = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.RemovePermissionBtn = new System.Windows.Forms.Button();
            this.AddPermissionBtn = new System.Windows.Forms.Button();
            this.SelectedUserBx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UserListBx = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cdManagermns = new System.Windows.Forms.MenuStrip();
            this.switchToCdeditPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchToAddCdPanleTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.SwtichToLoginPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.loginTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToRegisterPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToAdminPanelTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTsr = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPnl = new System.Windows.Forms.Panel();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.newUsrLbl = new System.Windows.Forms.Label();
            this.txtNewUsrEmail = new System.Windows.Forms.TextBox();
            this.txtNewUsrPwd = new System.Windows.Forms.TextBox();
            this.txtNewUsrName = new System.Windows.Forms.TextBox();
            this.AlbumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.loginPnl.SuspendLayout();
            this.cdEditPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsList)).BeginInit();
            this.addCdPnl.SuspendLayout();
            this.AdminPnl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.cdManagermns.SuspendLayout();
            this.registerPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPnl
            // 
            this.loginPnl.BackColor = System.Drawing.Color.Transparent;
            this.loginPnl.Controls.Add(this.InvalidLoginLbl);
            this.loginPnl.Controls.Add(this.InvLbl);
            this.loginPnl.Controls.Add(this.LoginBtn);
            this.loginPnl.Controls.Add(this.PasswdBx);
            this.loginPnl.Controls.Add(this.UsrBx);
            this.loginPnl.Controls.Add(this.label9);
            this.loginPnl.Controls.Add(this.label8);
            this.loginPnl.Location = new System.Drawing.Point(205, 526);
            this.loginPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Size = new System.Drawing.Size(525, 399);
            this.loginPnl.TabIndex = 0;
            // 
            // InvalidLoginLbl
            // 
            this.InvalidLoginLbl.AutoSize = true;
            this.InvalidLoginLbl.Location = new System.Drawing.Point(202, 221);
            this.InvalidLoginLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvalidLoginLbl.Name = "InvalidLoginLbl";
            this.InvalidLoginLbl.Size = new System.Drawing.Size(31, 13);
            this.InvalidLoginLbl.TabIndex = 16;
            this.InvalidLoginLbl.Text = "Sorry";
            // 
            // InvLbl
            // 
            this.InvLbl.AutoSize = true;
            this.InvLbl.ForeColor = System.Drawing.Color.Red;
            this.InvLbl.Location = new System.Drawing.Point(189, 190);
            this.InvLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InvLbl.Name = "InvLbl";
            this.InvLbl.Size = new System.Drawing.Size(0, 13);
            this.InvLbl.TabIndex = 7;
            this.InvLbl.Visible = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(232, 190);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(56, 24);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswdBx
            // 
            this.PasswdBx.Location = new System.Drawing.Point(232, 164);
            this.PasswdBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswdBx.Name = "PasswdBx";
            this.PasswdBx.PasswordChar = '*';
            this.PasswdBx.Size = new System.Drawing.Size(76, 20);
            this.PasswdBx.TabIndex = 4;
            this.PasswdBx.UseSystemPasswordChar = true;
            this.PasswdBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswdBx_KeyPress);
            // 
            // UsrBx
            // 
            this.UsrBx.Location = new System.Drawing.Point(232, 134);
            this.UsrBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsrBx.Name = "UsrBx";
            this.UsrBx.Size = new System.Drawing.Size(76, 20);
            this.UsrBx.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username:";
            // 
            // cdEditPnl
            // 
            this.cdEditPnl.Controls.Add(this.SongListView);
            this.cdEditPnl.Controls.Add(this.ResultsList);
            this.cdEditPnl.Controls.Add(this.clrBtn);
            this.cdEditPnl.Controls.Add(this.searchBtN);
            this.cdEditPnl.Controls.Add(this.label3);
            this.cdEditPnl.Controls.Add(this.label2);
            this.cdEditPnl.Controls.Add(this.ArtistComboBx);
            this.cdEditPnl.Controls.Add(this.searchBx);
            this.cdEditPnl.Controls.Add(this.label1);
            this.cdEditPnl.Controls.Add(this.GenreComboBx);
            this.cdEditPnl.Location = new System.Drawing.Point(9, 34);
            this.cdEditPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cdEditPnl.Name = "cdEditPnl";
            this.cdEditPnl.Size = new System.Drawing.Size(525, 447);
            this.cdEditPnl.TabIndex = 3;
            // 
            // SongListView
            // 
            this.SongListView.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.SongListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.TrackNumCol});
            this.SongListView.Location = new System.Drawing.Point(331, 112);
            this.SongListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SongListView.Name = "SongListView";
            this.SongListView.RowHeadersVisible = false;
            this.SongListView.RowTemplate.Height = 24;
            this.SongListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SongListView.Size = new System.Drawing.Size(188, 287);
            this.SongListView.TabIndex = 12;
            // 
            // ResultsList
            // 
            this.ResultsList.AllowUserToAddRows = false;
            this.ResultsList.AllowUserToDeleteRows = false;
            this.ResultsList.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.ResultsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumCol,
            this.ArtistCol,
            this.GenreCol,
            this.DateCol});
            this.ResultsList.Location = new System.Drawing.Point(6, 112);
            this.ResultsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultsList.MultiSelect = false;
            this.ResultsList.Name = "ResultsList";
            this.ResultsList.RowHeadersVisible = false;
            this.ResultsList.RowTemplate.Height = 24;
            this.ResultsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsList.Size = new System.Drawing.Size(319, 287);
            this.ResultsList.TabIndex = 11;
            this.ResultsList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultsList_CellContentClick);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(403, 37);
            this.clrBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 28);
            this.clrBtn.TabIndex = 4;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // searchBtN
            // 
            this.searchBtN.Location = new System.Drawing.Point(310, 37);
            this.searchBtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBtN.Name = "searchBtN";
            this.searchBtN.Size = new System.Drawing.Size(75, 27);
            this.searchBtN.TabIndex = 3;
            this.searchBtN.Text = "SEARCH";
            this.searchBtN.UseVisualStyleBackColor = true;
            this.searchBtN.Click += new System.EventHandler(this.searchBtN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // ArtistComboBx
            // 
            this.ArtistComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArtistComboBx.FormattingEnabled = true;
            this.ArtistComboBx.Location = new System.Drawing.Point(196, 57);
            this.ArtistComboBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArtistComboBx.Name = "ArtistComboBx";
            this.ArtistComboBx.Size = new System.Drawing.Size(92, 21);
            this.ArtistComboBx.TabIndex = 2;
            // 
            // searchBx
            // 
            this.searchBx.Location = new System.Drawing.Point(52, 24);
            this.searchBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBx.Name = "searchBx";
            this.searchBx.Size = new System.Drawing.Size(236, 20);
            this.searchBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // GenreComboBx
            // 
            this.GenreComboBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.GenreComboBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GenreComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBx.FormattingEnabled = true;
            this.GenreComboBx.Location = new System.Drawing.Point(52, 57);
            this.GenreComboBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenreComboBx.Name = "GenreComboBx";
            this.GenreComboBx.Size = new System.Drawing.Size(92, 21);
            this.GenreComboBx.Sorted = true;
            this.GenreComboBx.TabIndex = 1;
            // 
            // addCdPnl
            // 
            this.addCdPnl.Controls.Add(this.label4);
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
            this.addCdPnl.Location = new System.Drawing.Point(681, 507);
            this.addCdPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCdPnl.Name = "addCdPnl";
            this.addCdPnl.Size = new System.Drawing.Size(525, 399);
            this.addCdPnl.TabIndex = 5;
            // 
            // AddSongBx
            // 
            this.AddSongBx.Location = new System.Drawing.Point(73, 164);
            this.AddSongBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddSongBx.Name = "AddSongBx";
            this.AddSongBx.Size = new System.Drawing.Size(207, 150);
            this.AddSongBx.TabIndex = 26;
            this.AddSongBx.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // TrackNumBx
            // 
            this.TrackNumBx.Location = new System.Drawing.Point(248, 83);
            this.TrackNumBx.Name = "TrackNumBx";
            this.TrackNumBx.Size = new System.Drawing.Size(32, 20);
            this.TrackNumBx.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(179, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Total Tracks ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Album Year";
            // 
            // AddCDBtn
            // 
            this.AddCDBtn.Location = new System.Drawing.Point(315, 157);
            this.AddCDBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCDBtn.Name = "AddCDBtn";
            this.AddCDBtn.Size = new System.Drawing.Size(77, 23);
            this.AddCDBtn.TabIndex = 19;
            this.AddCDBtn.Text = "Add CD";
            this.AddCDBtn.UseVisualStyleBackColor = true;
            this.AddCDBtn.Click += new System.EventHandler(this.AddCDBtn_Click);
            // 
            // addGenreBx
            // 
            this.addGenreBx.Location = new System.Drawing.Point(82, 117);
            this.addGenreBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGenreBx.Name = "addGenreBx";
            this.addGenreBx.Size = new System.Drawing.Size(76, 20);
            this.addGenreBx.TabIndex = 17;
            // 
            // addArtistBx
            // 
            this.addArtistBx.Location = new System.Drawing.Point(82, 79);
            this.addArtistBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addArtistBx.Name = "addArtistBx";
            this.addArtistBx.Size = new System.Drawing.Size(76, 20);
            this.addArtistBx.TabIndex = 16;
            // 
            // addAlbumBx
            // 
            this.addAlbumBx.Location = new System.Drawing.Point(82, 44);
            this.addAlbumBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAlbumBx.Name = "addAlbumBx";
            this.addAlbumBx.Size = new System.Drawing.Size(76, 20);
            this.addAlbumBx.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 117);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Album Genre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Artist\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Add Album";
            // 
            // AdminPnl
            // 
            this.AdminPnl.Controls.Add(this.label17);
            this.AdminPnl.Controls.Add(this.RemovePermissionBtn);
            this.AdminPnl.Controls.Add(this.AddPermissionBtn);
            this.AdminPnl.Controls.Add(this.SelectedUserBx);
            this.AdminPnl.Controls.Add(this.label16);
            this.AdminPnl.Controls.Add(this.UserListBx);
            this.AdminPnl.Location = new System.Drawing.Point(436, 509);
            this.AdminPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminPnl.Name = "AdminPnl";
            this.AdminPnl.Size = new System.Drawing.Size(525, 447);
            this.AdminPnl.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(99, 198);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Selected User:";
            // 
            // RemovePermissionBtn
            // 
            this.RemovePermissionBtn.Location = new System.Drawing.Point(179, 244);
            this.RemovePermissionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemovePermissionBtn.Name = "RemovePermissionBtn";
            this.RemovePermissionBtn.Size = new System.Drawing.Size(195, 19);
            this.RemovePermissionBtn.TabIndex = 6;
            this.RemovePermissionBtn.Text = "Remove Edit Permissions";
            this.RemovePermissionBtn.UseVisualStyleBackColor = true;
            this.RemovePermissionBtn.Click += new System.EventHandler(this.RemovePermissionBtn_Click_1);
            // 
            // AddPermissionBtn
            // 
            this.AddPermissionBtn.Location = new System.Drawing.Point(179, 221);
            this.AddPermissionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPermissionBtn.Name = "AddPermissionBtn";
            this.AddPermissionBtn.Size = new System.Drawing.Size(195, 19);
            this.AddPermissionBtn.TabIndex = 5;
            this.AddPermissionBtn.Text = "Give Edit Permissions";
            this.AddPermissionBtn.UseVisualStyleBackColor = true;
            this.AddPermissionBtn.Click += new System.EventHandler(this.AddPermissionBtn_Click_1);
            // 
            // SelectedUserBx
            // 
            this.SelectedUserBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SelectedUserBx.Location = new System.Drawing.Point(179, 198);
            this.SelectedUserBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectedUserBx.Name = "SelectedUserBx";
            this.SelectedUserBx.Size = new System.Drawing.Size(195, 20);
            this.SelectedUserBx.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(138, 112);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Users:";
            // 
            // UserListBx
            // 
            this.UserListBx.FormattingEnabled = true;
            this.UserListBx.Location = new System.Drawing.Point(179, 112);
            this.UserListBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserListBx.Name = "UserListBx";
            this.UserListBx.Size = new System.Drawing.Size(195, 69);
            this.UserListBx.TabIndex = 2;
            this.UserListBx.SelectedIndexChanged += new System.EventHandler(this.UserListBx_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Edit";
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
            this.cdManagermns.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.cdManagermns.Size = new System.Drawing.Size(1156, 24);
            this.cdManagermns.TabIndex = 12;
            this.cdManagermns.Text = "CDmns";
            // 
            // switchToCdeditPanelTsr
            // 
            this.switchToCdeditPanelTsr.Name = "switchToCdeditPanelTsr";
            this.switchToCdeditPanelTsr.Size = new System.Drawing.Size(54, 20);
            this.switchToCdeditPanelTsr.Text = "Search";
            this.switchToCdeditPanelTsr.Click += new System.EventHandler(this.SwitchToCdeditPanelTsr_Click);
            // 
            // SwitchToAddCdPanleTsr
            // 
            this.SwitchToAddCdPanleTsr.Name = "SwitchToAddCdPanleTsr";
            this.SwitchToAddCdPanleTsr.Size = new System.Drawing.Size(60, 20);
            this.SwitchToAddCdPanleTsr.Text = "Add CD";
            this.SwitchToAddCdPanleTsr.Click += new System.EventHandler(this.SwitchToAddCdPnl_Click);
            // 
            // SwtichToLoginPanelTsr
            // 
            this.SwtichToLoginPanelTsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginTsr,
            this.switchToRegisterPanelTsr});
            this.SwtichToLoginPanelTsr.Name = "SwtichToLoginPanelTsr";
            this.SwtichToLoginPanelTsr.Size = new System.Drawing.Size(49, 20);
            this.SwtichToLoginPanelTsr.Text = "Login";
            // 
            // loginTsr
            // 
            this.loginTsr.Name = "loginTsr";
            this.loginTsr.Size = new System.Drawing.Size(116, 22);
            this.loginTsr.Text = "Login";
            this.loginTsr.Click += new System.EventHandler(this.SwtichToLoginPanelTsr_Click);
            // 
            // switchToRegisterPanelTsr
            // 
            this.switchToRegisterPanelTsr.Name = "switchToRegisterPanelTsr";
            this.switchToRegisterPanelTsr.Size = new System.Drawing.Size(116, 22);
            this.switchToRegisterPanelTsr.Text = "Register";
            this.switchToRegisterPanelTsr.Click += new System.EventHandler(this.switchToRegisterPanelTsr_Click);
            // 
            // currentUserTsr
            // 
            this.currentUserTsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToAdminPanelTsr,
            this.logoutTsr});
            this.currentUserTsr.Name = "currentUserTsr";
            this.currentUserTsr.Size = new System.Drawing.Size(85, 20);
            this.currentUserTsr.Text = "Current User";
            // 
            // switchToAdminPanelTsr
            // 
            this.switchToAdminPanelTsr.Name = "switchToAdminPanelTsr";
            this.switchToAdminPanelTsr.Size = new System.Drawing.Size(160, 22);
            this.switchToAdminPanelTsr.Text = "Edit Permissions";
            this.switchToAdminPanelTsr.Click += new System.EventHandler(this.switchToAdminPanelTsr_Click);
            // 
            // logoutTsr
            // 
            this.logoutTsr.Name = "logoutTsr";
            this.logoutTsr.Size = new System.Drawing.Size(160, 22);
            this.logoutTsr.Text = "Logout";
            this.logoutTsr.Click += new System.EventHandler(this.logoutTsr_Click);
            // 
            // exitTsr
            // 
            this.exitTsr.Name = "exitTsr";
            this.exitTsr.Size = new System.Drawing.Size(38, 20);
            this.exitTsr.Text = "Exit";
            this.exitTsr.Click += new System.EventHandler(this.exitTsr_Click);
            // 
            // registerPnl
            // 
            this.registerPnl.Controls.Add(this.signUpBtn);
            this.registerPnl.Controls.Add(this.label21);
            this.registerPnl.Controls.Add(this.label20);
            this.registerPnl.Controls.Add(this.label19);
            this.registerPnl.Controls.Add(this.newUsrLbl);
            this.registerPnl.Controls.Add(this.txtNewUsrEmail);
            this.registerPnl.Controls.Add(this.txtNewUsrPwd);
            this.registerPnl.Controls.Add(this.txtNewUsrName);
            this.registerPnl.Location = new System.Drawing.Point(548, 34);
            this.registerPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerPnl.Name = "registerPnl";
            this.registerPnl.Size = new System.Drawing.Size(525, 399);
            this.registerPnl.TabIndex = 13;
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(243, 233);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(56, 27);
            this.signUpBtn.TabIndex = 23;
            this.signUpBtn.Text = "Sign Up!";
            this.signUpBtn.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(171, 208);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(171, 177);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Password:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 144);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Username:";
            // 
            // newUsrLbl
            // 
            this.newUsrLbl.AutoSize = true;
            this.newUsrLbl.Location = new System.Drawing.Point(201, 114);
            this.newUsrLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newUsrLbl.Name = "newUsrLbl";
            this.newUsrLbl.Size = new System.Drawing.Size(116, 13);
            this.newUsrLbl.TabIndex = 19;
            this.newUsrLbl.Text = "Create A New Account";
            // 
            // txtNewUsrEmail
            // 
            this.txtNewUsrEmail.Location = new System.Drawing.Point(243, 207);
            this.txtNewUsrEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewUsrEmail.Name = "txtNewUsrEmail";
            this.txtNewUsrEmail.Size = new System.Drawing.Size(76, 20);
            this.txtNewUsrEmail.TabIndex = 18;
            // 
            // txtNewUsrPwd
            // 
            this.txtNewUsrPwd.Location = new System.Drawing.Point(243, 175);
            this.txtNewUsrPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewUsrPwd.Name = "txtNewUsrPwd";
            this.txtNewUsrPwd.Size = new System.Drawing.Size(76, 20);
            this.txtNewUsrPwd.TabIndex = 17;
            // 
            // txtNewUsrName
            // 
            this.txtNewUsrName.Location = new System.Drawing.Point(243, 142);
            this.txtNewUsrName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewUsrName.Name = "txtNewUsrName";
            this.txtNewUsrName.Size = new System.Drawing.Size(76, 20);
            this.txtNewUsrName.TabIndex = 16;
            // 
            // AlbumCol
            // 
            this.AlbumCol.HeaderText = "Album";
            this.AlbumCol.Name = "AlbumCol";
            this.AlbumCol.Width = 140;
            // 
            // ArtistCol
            // 
            this.ArtistCol.HeaderText = "Artist";
            this.ArtistCol.Name = "ArtistCol";
            this.ArtistCol.Width = 60;
            // 
            // GenreCol
            // 
            this.GenreCol.HeaderText = "Genre";
            this.GenreCol.Name = "GenreCol";
            this.GenreCol.Width = 50;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Song Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 130;
            // 
            // TrackNumCol
            // 
            this.TrackNumCol.HeaderText = "Track#";
            this.TrackNumCol.Name = "TrackNumCol";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Songs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1156, 666);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.cdManagermns);
            this.Controls.Add(this.addCdPnl);
            this.Controls.Add(this.AdminPnl);
            this.Controls.Add(this.loginPnl);
            this.Controls.Add(this.cdEditPnl);
            this.Controls.Add(this.registerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.cdManagermns;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CD Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPnl.ResumeLayout(false);
            this.loginPnl.PerformLayout();
            this.cdEditPnl.ResumeLayout(false);
            this.cdEditPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsList)).EndInit();
            this.addCdPnl.ResumeLayout(false);
            this.addCdPnl.PerformLayout();
            this.AdminPnl.ResumeLayout(false);
            this.AdminPnl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.cdManagermns.ResumeLayout(false);
            this.cdManagermns.PerformLayout();
            this.registerPnl.ResumeLayout(false);
            this.registerPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPnl;
        private System.Windows.Forms.Panel cdEditPnl;
        private System.Windows.Forms.Button searchBtN;
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
        private System.Windows.Forms.Button clrBtn;
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
        private System.Windows.Forms.Label InvalidLoginLbl;
        private System.Windows.Forms.Panel registerPnl;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label newUsrLbl;
        private System.Windows.Forms.TextBox txtNewUsrEmail;
        private System.Windows.Forms.TextBox txtNewUsrPwd;
        private System.Windows.Forms.TextBox txtNewUsrName;
        private System.Windows.Forms.ToolStripMenuItem loginTsr;
        private System.Windows.Forms.ToolStripMenuItem switchToRegisterPanelTsr;
        private System.Windows.Forms.DataGridView ResultsList;
        private System.Windows.Forms.DataGridView SongListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNumCol;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

