using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

//D:\C#\CDProjects\CDManage-DatabaseConn
namespace CDManage
{
    public partial class Form1 : Form
    {
        string pathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../CDdtb.accdb");
        string userPathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../LoginCheckDTB.accdb");
        string songPathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../SongListDB.accdb");

        string invalidLogin = "Invalid Username/password combination";


        LinkedList<Cd> CdList = new LinkedList<Cd>();
        static User guestUsr = new User(1);
        User currUsr = new User(guestUsr);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * Todo add load in CDs from the database
             * Fill in the genre and artist combo boxes based on details from CDs
             * Set user level to guess
             * Set Display to match user level
             */


            this.Size = new Size(600, 500);
            foreach (Panel myPnl in this.Controls)
            {
                myPnl.Location = new Point(0, 0);
                myPnl.Size = new Size(600, 500);
            }
            loginPnL.Enabled = false;
            loginPnL.Visible = false;
            AdminPnL.Enabled = false;
            AdminPnL.Visible = false;
            addCdPnL.Enabled = false;
            addCdPnL.Visible = false;
            ResultsList.View = View.Details;
            ResultsList.GridLines = true;
            ResultsList.FullRowSelect = true;
            SongListView.View = View.Details;
            SongListView.GridLines = true;
            SongListView.FullRowSelect = true;




            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                string sqlQuery = "SELECT * FROM CDdtb";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);

                try
                {


                    conn.Open();

                    try
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Cd newCd = new Cd();
                            newCd.setAlbum((string)reader["Album"]);
                            newCd.setArtist((string)reader["Artist"]);
                            newCd.setGenre((string)reader["Genre"]);
                            newCd.setDate((DateTime)reader["DateStr"]);
                            CdList.AddLast(newCd);
                        }
                    }
                    catch
                    {

                    }


                    foreach (Cd x in CdList)
                    {
                        if (x.getGenre().Trim() != "")
                        {
                            if (!GenreComboBx.Items.Contains(x.getGenre()))
                            {
                                GenreComboBx.Items.Add(x.getGenre());
                            }
                        }
                        if (x.getArtist().Trim() != "")
                        {
                            if (!ArtistComboBx.Items.Contains(x.getArtist()))
                            {
                                ArtistComboBx.Items.Add(x.getArtist());
                            }
                        }


                    }

                }
                catch
                {
                    MessageBox.Show("Error opening file");
                }

                finally { conn.Close(); }
            }


            using (OleDbConnection songConn = new OleDbConnection(songPathStr))
            {
                foreach (Cd x in CdList)
                {
                    string sqlQuery = @"SELECT * FROM SongListDTB where Album like @album and Artist like @artist";
                    OleDbCommand cmd = new OleDbCommand(sqlQuery, songConn);
                    cmd.Parameters.AddWithValue("@album", x.getAlbum());
                    cmd.Parameters.AddWithValue("@artist", x.getArtist());
                    try
                    {
                        songConn.Open();
                        try
                        {
                            OleDbDataReader reader = cmd.ExecuteReader();
                            List<string> tmpLst = new List<string>();
                            string temp = "";
                            while (reader.Read())
                            {
                                temp = (string)reader["Song Name"];
                                temp = temp.Trim();
                                tmpLst.Add(temp);
                            }
                            x.setSongName(tmpLst);
                        }
                        catch
                        {

                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        songConn.Close();
                    }
                }

            }


            switchToAddCdPanelBtn.Visible = false;
            switchToAdminPanelBtn.Visible = false;
        }

        private void switchToLoginPnlBtn_Click(object sender, EventArgs e)
        {
            //Switch to the Login Panel
            cdEditPnl.Enabled = false;
            cdEditPnl.Visible = false;
            loginPnL.Enabled = true;
            loginPnL.Visible = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            /** Login Button order of operations
             * Determines if the log in attempt is in the database. If not return error
             * Make the buttons enabled based on the users level
             * Change login button with a logout button
             * Switch back to the cd edit panel
             */

            //Compare the username and password of that witch is in the database
            //Change Userlevel according


            //Enable the correct buttons. Determined by User Level

            //Switch to the Panels


            using (OleDbConnection conn = new OleDbConnection(userPathStr))
            {

                try
                {
                    string sqlQuery = "select * from LoginDTB where Username like @username and Password = @password";
                    OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@username", this.UsrBx.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", this.PasswdBx.Text.Trim());

                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {



                        if (reader.HasRows)
                        {

                            int usrLvl = 0;
                            string usrLvlStr = "";
                            usrLvlStr = (string)reader["UserLevel"];
                            usrLvl = int.Parse(usrLvlStr);

                            currUsr.setUserLevel(usrLvl);

                            if (currUsr.getUserLevel() == 1)
                            {
                                switchToAddCdPanelBtn.Visible = false;
                                switchToAddCdPanelBtn.Enabled = false;
                                switchToAdminPanelBtn.Visible = false;
                                switchToAdminPanelBtn.Enabled = false;
                            }

                            if (currUsr.getUserLevel() > 1)
                            {
                                switchToAddCdPanelBtn.Visible = true;
                                switchToAddCdPanelBtn.Enabled = true;
                            }
                            if (currUsr.getUserLevel() > 2)
                            {
                                switchToAdminPanelBtn.Visible = true;
                                switchToAdminPanelBtn.Enabled = true;
                            }
                            cdEditPnl.Enabled = true;
                            cdEditPnl.Visible = true;
                            loginPnL.Visible = false;
                            InvLbl.Visible = false;



                        }
                        else
                        {
                            InvLbl.Text = invalidLogin;
                            InvLbl.Visible = true;
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Error opening file");
                    {

                    }
                }

                finally
                {
                    conn.Close();
                }
            }



        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //Swicth to the CD Edit Panel
            cdEditPnl.Enabled = true;
            cdEditPnl.Visible = true;
            loginPnL.Enabled = false;
            loginPnL.Visible = false;
        }



        private void LgoutBtn_Click(object sender, EventArgs e)
        {
            //Sets the user level to Guess
            addCdPnL.Enabled = false;
            addCdPnL.Visible = false;
            loginPnL.Enabled = true;
            loginPnL.Visible = true;
        }




        private void UserListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserListBx.SelectedItem != null)
            {
                SelectedUserBx.Text = UserListBx.SelectedItem.ToString();
            }

        }


        private void AddPermissionBtn_Click_1(object sender, EventArgs e)
        {
            if (SelectedUserBx.Text.Trim() != "")
            {
                string AddCptn = "Confirmation";
                string AddMsg = "Are you sure you want to give " + SelectedUserBx.Text.Trim() + " edit permissions?";
                DialogResult dialog = MessageBox.Show(AddMsg, AddCptn, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (OleDbConnection connLg = new OleDbConnection(userPathStr))
                    {
                        string sqlUpd = @"UPDATE LoginDTB SET UserLevel = 2 WHERE Username like @Username";
                        using (OleDbCommand UpdCmd = new OleDbCommand(sqlUpd, connLg))
                        {


                            try
                            {
                                connLg.Open();
                            }

                            catch
                            {

                            }
                            try
                            {
                                UpdCmd.Parameters.AddWithValue("@Username", this.SelectedUserBx.Text.Trim());
                                UpdCmd.ExecuteNonQuery();
                            }
                            catch
                            {

                            }
                            finally
                            {
                                UpdCmd.Dispose();
                                connLg.Close();
                            }
                        }
                    }
                }
            }
            else { MessageBox.Show("Please Select a user"); }
        }

        private void RemovePermissionBtn_Click_1(object sender, EventArgs e)
        {
            if (SelectedUserBx.Text.Trim() != "")
            {
                string RemoveCptn = "Confirmation";
                string RemoveMsg = "Are you sure you want to remove " + SelectedUserBx.Text.Trim() + "'s edit permissions?";
                DialogResult dialog = MessageBox.Show(RemoveMsg, RemoveCptn, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (OleDbConnection connLg = new OleDbConnection(userPathStr))
                    {
                        string sqlUpd = @"UPDATE LoginDTB SET UserLevel = 1 WHERE Username like @Username";
                        OleDbCommand UpdCmd = new OleDbCommand(sqlUpd, connLg);

                        try
                        {
                            connLg.Open();

                            try
                            {
                                UpdCmd.Parameters.AddWithValue("@Username", this.SelectedUserBx.Text.Trim());
                                UpdCmd.ExecuteNonQuery();
                            }
                            catch
                            {
                                MessageBox.Show("Unable to update");
                            }
                        }

                        catch
                        {
                            MessageBox.Show("unable to connect");
                        }
                        finally
                        {
                            connLg.Close();
                            UpdCmd.Dispose();
                        }


                    }
                }
            }
            else { MessageBox.Show("Please Select a user"); }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            //Switch to the Login Panel
            AdminPnL.Enabled = false;
            AdminPnL.Visible = false;
            loginPnL.Enabled = true;
            loginPnL.Visible = true;
        }

        private void switchToCdPanelBtn_Click(object sender, EventArgs e)
        {
            //Switch to the Add CD Panel
            addCdPnL.Visible = true;
            addCdPnL.Enabled = true;
            addCdPnL.BringToFront();
        }

        private void switchToAdminPanelBtn_Click(object sender, EventArgs e)
        {
            //Switch to the admin Panel
            AdminPnL.BringToFront();
            AdminPnL.Visible = true;
            AdminPnL.Enabled = true;
            UserListBx.Items.Clear();
            using (OleDbConnection connLg = new OleDbConnection(userPathStr))
            {


                string sqlQuery = @"SELECT * from LoginDTB";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, connLg);

                try
                {
                    connLg.Open();

                    try
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            UserListBx.Items.Add((string)reader["Username"]);// + " (" + (string)reader["UserLevel"] + ")");
                        }
                    }
                    catch
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Error: Could not connect to database");
                }
            }
        }

        private void AddCDBtn_Click(object sender, EventArgs e)
        {
            bool canAdd = true;
            string sqlQuery = @"INSERT INTO CDdtb (`Album`,`Artist`,`Genre`,`DateStr`) values (?,?,?,?)";
            string addSongs = @"INSERT INTO SongListDTB ( `Album`, `Artist`,`Song Name`) values (?,?,?)";



            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    foreach (Cd x in CdList)
                    {
                        if (this.addAlbumBx.Text.Trim() == x.getAlbum() &&
                            this.addArtistBx.Text.Trim() == x.getArtist() &&
                            this.addGenreBx.Text.Trim() == x.getGenre())
                        {
                            MessageBox.Show("CD already exists.");
                            canAdd = false;
                            break;
                        }

                    }
                    if (canAdd)
                    {


                        try
                        {
                            conn.Open();

                            cmd.Parameters.AddWithValue("@Album", this.addAlbumBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@Artist", this.addArtistBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@Genre", this.addGenreBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@DateStr", this.dateTimePicker1.Value.Date);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();

                            conn.Close();
                            Cd x = new Cd();
                            x.setAlbum(this.addAlbumBx.Text.Trim());
                            x.setArtist(this.addArtistBx.Text.Trim());
                            x.setDate(this.dateTimePicker1.Value.Date);
                            x.setGenre(this.addGenreBx.Text.Trim());
                            
                            CdList.AddLast(x);
                            if (this.addGenreBx.Text.Trim() != "")
                            {
                                if (!GenreComboBx.Items.Contains(this.addGenreBx.Text.Trim()))
                                {
                                    GenreComboBx.Items.Add(this.addGenreBx.Text.Trim());
                                }
                            }

                            if (this.addArtistBx.Text.Trim() != "")
                            {
                                if (!ArtistComboBx.Items.Contains(this.addArtistBx.Text.Trim()))
                                {
                                    ArtistComboBx.Items.Add(this.addArtistBx.Text.Trim());
                                }
                            }

                            using (OleDbConnection songConn = new OleDbConnection(songPathStr))
                            {
                                using (OleDbCommand songCmd = new OleDbCommand(addSongs, songConn))
                                {
                                    try
                                    {
                                        songConn.Open();
                                        songCmd.Parameters.AddWithValue("@Album", x.getAlbum());
                                        songCmd.Parameters.AddWithValue("@Artist", x.getArtist());
                                        List<string> tmpSngLst = new List<string>();
                                        string z = "";
                                        songCmd.Parameters.AddWithValue("@SongName", z);
                                        foreach (string y in AddSongBx.Lines)
                                        {
                                            z = y.Trim();
                                            songCmd.Parameters["@SongName"].Value = z;
                                            songCmd.ExecuteNonQuery();
                                            tmpSngLst.Add(y);
                                           
                                        }
                                        
                                        x.setSongName(tmpSngLst);

                                        //foreach(string x in AddSongBx.Text)

                                    }
                                    catch
                                    {

                                    }
                                    finally
                                    {
                                        songConn.Close();
                                    }
                                }
                            }

                        }

                        catch { MessageBox.Show("Error opening file"); }





                    }

                }
            }





        }





        private void searchBtN_Click(object sender, EventArgs e)
        {
            ResultsList.Items.Clear();
            const int nonexisting = -1;
            LinkedList<Cd> SearchResults = new LinkedList<Cd>();
            string album = searchBx.Text.Trim();
            string genre = "";
            string artist = "";

            if (GenreComboBx.SelectedIndex > nonexisting)
            {
                genre = GenreComboBx.SelectedItem.ToString();
            }
            if (ArtistComboBx.SelectedIndex > nonexisting)
            {
                artist = ArtistComboBx.SelectedItem.ToString();
            }

            foreach (Cd x in CdList)
            {
                if ((GenreComboBx.SelectedIndex > nonexisting) || (ArtistComboBx.SelectedIndex > nonexisting) || (album != ""))
                {
                    if (x.getAlbum() == album || album == "")
                    {
                        if (x.getGenre() == genre || genre == "")
                        {
                            if (x.getArtist() == artist || artist == "")
                            {
                                SearchResults.AddLast(x);
                            }
                        }
                    }
                }

            }

            foreach (Cd x in SearchResults)
            {
                String[] arrayStr;
                string tmpDate = x.getDate().ToShortDateString();
                arrayStr = new String[4] { x.getAlbum(), x.getArtist(), x.getGenre(), tmpDate };
                ListViewItem item = new ListViewItem(arrayStr);
                ResultsList.Items.Add(item);

                //displayStr += x.getAlbum() + " by " + x.getArtist() + "(" + x.getGenre() + ")\n\n";
            }


        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connLg = new OleDbConnection(userPathStr))
            {
                try
                {
                    const int noEditPms = 0;
                    bool canAddUser = true;
                    string sqlIns = @"INSERT INTO LoginDTB (`Username`,`EmailAddress`,`Password`) values (?,?,?)";
                    string sqlQuery = @"SELECT * FROM LoginDTB";
                    OleDbCommand cmd = new OleDbCommand(sqlQuery, connLg);
                    OleDbCommand InsertCmd = new OleDbCommand(sqlIns, connLg);


                    connLg.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        if (txtNewUsrName.Text.Trim() == reader["Username"].ToString())
                        {
                            newUsrLbl.Text = "Sorry, that Username is already taken.";
                            canAddUser = false;
                            break;
                        }
                        else if (txtNewUsrEmail.Text.Trim() == reader["EmailAddress"].ToString())
                        {
                            newUsrLbl.Text = "Sorry, that email is already associated with a user.";
                            canAddUser = false;
                            break;
                        }
                    }

                    if (canAddUser == true)
                    {
                        InsertCmd.Parameters.AddWithValue("@Username", this.txtNewUsrName.Text.Trim());
                        InsertCmd.Parameters.AddWithValue("@EmailAddress", this.txtNewUsrEmail.Text.Trim());
                        InsertCmd.Parameters.AddWithValue("@Password", this.txtNewUsrPwd.Text.Trim());
                        InsertCmd.Parameters.AddWithValue("UserLevel", noEditPms);

                        InsertCmd.ExecuteNonQuery();

                        cmd.Dispose();
                        InsertCmd.Dispose();

                        newUsrLbl.Text = "New user? Sign up here!";
                    }
                }

                catch
                {
                    MessageBox.Show("Error opening file.");
                }
                finally
                {
                    connLg.Close();
                }
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            GenreComboBx.SelectedIndex = -1;
            ArtistComboBx.SelectedIndex = -1;
            searchBx.Clear();
        }

        private void ResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultsList.FocusedItem == null)
            {
                return;
            }
            else
            {
                string tmpAlbum = ResultsList.SelectedItems[0].Text;
                foreach (Cd x in CdList)
                {
                    if (x.getAlbum() == tmpAlbum)
                    {
                        SongListView.Items.Clear();
                        foreach (string y in x.getSongName())
                        {
                            int indx = 0;
                            indx = x.getSongName().IndexOf(y) + 1;
                            string tmp = indx.ToString();
                            string[] newrow = { y, tmp };
                            ListViewItem newItem = new ListViewItem(newrow);
                            SongListView.Items.Add(newItem);
                        }



                    }
                    //string songName = "";

                }
            }

        }
    }
}


