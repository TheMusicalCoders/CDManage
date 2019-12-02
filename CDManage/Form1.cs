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
using System.Net;
using CSFreeDB;
using System.Text.RegularExpressions;

//D:\C#\CDProjects\CDManage-DatabaseConn
namespace CDManage
{

    public partial class Form1 : Form
    {
        //connection path strings for each of the three databases

        static string dirStr = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString();
        string pathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirStr + @"\Database\Cddtb.accdb";
        string userPathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirStr + @"\Database\LoginCheckDTB.accdb";
        string songPathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirStr + @"\Database\SongListDB.accdb";
        int nextID = 0;


        //string pathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\autov\Documents\Temp\CDManage\CDManage\Database\CDdtb.accdb";
        const string invalidLogin = "Invalid Username/password combination";
        //linked list to hold cd information
        LinkedList<Cd> CdList = new LinkedList<Cd>();
        //guest user instantiation
        static User guestUsr = new User(1);
        User currUsr = new User(guestUsr);

        public Form1()
        {
            InitializeComponent();
            AutoCompleteNewCD();
        }

        //functions to clear textboxes in form
        //to be called when switching panels
        /// <summary>
        /// cleanup function calls clearFields function to 
        /// recursively clear textboxes throughout form
        /// </summary>
        private void Cleanup()
        {
            ClearFields(this);
        }
        private void ClearFields(Control control)
        {
            foreach (Control cont in control.Controls)
            {
                if (cont is TextBoxBase)
                {
                    ((TextBoxBase)cont).Text = String.Empty;
                }
                else if (cont is ComboBox)
                {
                    ((ComboBox)cont).SelectedIndex = -1;
                }
                else if (cont is ListView)
                {
                    ((ListView)cont).Items.Clear();
                }
                else if (cont is DataGridView)
                {
                    ((DataGridView)cont).Rows.Clear();
                }

                if (cont.Controls.Count > 0)
                {
                    ClearFields(cont);
                }
            }
        }
        private void StandardizeText(ref string text)
        {
            text = text.ToLower();
            text = Regex.Replace(text, @"(^\w)|(\s\w)", ch => ch.Value.ToUpper());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * Add load in CDs from the database [X]
             * Fill in the genre and artist combo boxes based on details from CDs [X]
             * Set user level to guess [x]
             * Set Display to match user level [x]
             * Clean up 
             */
            //newUsrLbl.Text = "HEYYYYYY";
            //newUsrLbl.Visible = true;
            this.Size = new Size(550, 450);
            foreach (Control myPnl in this.Controls)
            {
                var temp = myPnl.GetType();
                if (myPnl.Name == "cdManagemns") //Not a panel
                {
                    continue;
                }
                myPnl.Location = new Point(0, 10);
                myPnl.Size = new Size(700, 550);
            }
            loginPnl.Enabled = false;
            loginPnl.Visible = false;
            AdminPnl.Enabled = false;
            AdminPnl.Visible = false;
            addCdPnl.Enabled = false;
            addCdPnl.Visible = false;
            //ResultsList.View = View.Details;
            //ResultsList.GridLines = true;

            ResultsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // SongListView.View = View.Details;
            //SongListView.GridLines = true;
            //SongListView.FullRowSelect = true;

            //Default Menu Strip View [Guess View]
            currentUserTsr.Visible = false;
            SwitchToAddCdPanleTsr.Visible = false;

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
                            int temp = (int)reader["AlbumID"];
                            Cd newCd = new Cd();
                            newCd.setAlbum((string)reader["Album"]);
                            newCd.setArtist((string)reader["Artist"]);
                            newCd.setGenre((string)reader["Genre"]);
                            newCd.setDate((DateTime)reader["DateStr"]);
                            newCd.setId(temp.ToString());
                            CdList.AddLast(newCd);

                            if (temp > nextID)
                            {
                                nextID = temp;
                            }
                        }
                        nextID++;

                    }


                    // string nextAlbumID = CdList.L
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error reading from database\n" + ex.StackTrace.ToString());
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
                    AutoCompleteSearchTB();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    Debug.WriteLine(ex.Message);

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
                                temp = (string)reader["Song_Name"];
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
                //todo Add a promp to tell user if password failed
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
                            int.TryParse(usrLvlStr, out usrLvl); //Todo add catch

                            currUsr.setUserLevel(usrLvl);
                            currentUserTsr.Text = UsrBx.Text.Trim();
                            if (currUsr.getUserLevel() > 0)
                            {

                                currentUserTsr.Visible = true;
                                SwtichToLoginPanelTsr.Visible = false;
                                switchToAdminPanelTsr.Visible = false;
                            }
                            if (currUsr.getUserLevel() > 1)
                            {
                                SwitchToAddCdPanleTsr.Visible = true;
                            }
                            if (currUsr.getUserLevel() > 2)
                            {
                                switchToAdminPanelTsr.Visible = true;
                            }

                            PanelSwitch(cdEditPnl.Name);

                        }
                        else
                        {
                            InvLbl.Text = invalidLogin;
                            InvLbl.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file\n" + ex.StackTrace.ToString());
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        /// <summary>
        /// fill selected user text box with selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                            catch (Exception ex)
                            {
                                Debug.WriteLine("Error: Cannot connect to database\n" + ex.StackTrace.ToString());
                            }
                            try
                            {
                                UpdCmd.Parameters.AddWithValue("@Username", this.SelectedUserBx.Text.Trim());
                                UpdCmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine("Error: Unable to update user level\n" + ex.StackTrace.ToString());
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
                            catch (Exception ex)
                            {
                                Debug.WriteLine("Unable to update\n" + ex.StackTrace.ToString());
                            }
                        }

                        catch (Exception ex)
                        {
                            Debug.WriteLine("unable to connect to database\n" + ex.StackTrace.ToString());
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

        private void AddCDBtn_Click(object sender, EventArgs e)
        {
            //TODO Add in a confirmation button

            bool canAdd = true;
            string sqlQuery = @"INSERT INTO CDdtb (`Album`,`Artist`,`Genre`,`DateStr`) values (?,?,?,?)";
            string addSongs = @"INSERT INTO SongListDTB ( `Album`, `Artist`,`Song_Name`, `AlbumID`) values (?,?,?,?)";
            string newAlbum = addAlbumBx.Text.Trim();
            StandardizeText(ref newAlbum);
            string newArtist = addArtistBx.Text.Trim();
            StandardizeText(ref newArtist);
            string newGenre = addGenreBx.Text.Trim();
            StandardizeText(ref newGenre);
            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    foreach (Cd x in CdList)
                    {
                        if (newAlbum == x.getAlbum() &&
                            newArtist == x.getArtist())
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

                            cmd.Parameters.AddWithValue("@Album", newAlbum);
                            cmd.Parameters.AddWithValue("@Artist", newArtist);
                            cmd.Parameters.AddWithValue("@Genre", newGenre);
                            cmd.Parameters.AddWithValue("@DateStr", this.dateTimePicker1.Value.Date);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();

                            conn.Close();
                            Cd x = new Cd();
                            x.setAlbum(newAlbum);
                            x.setArtist(newArtist);
                            x.setDate(this.dateTimePicker1.Value.Date);
                            x.setGenre(newGenre);

                            CdList.AddLast(x);
                            if (newGenre != "")
                            {
                                if (!GenreComboBx.Items.Contains(newGenre))
                                {
                                    GenreComboBx.Items.Add(newGenre);
                                }
                            }

                            if (newArtist != "")
                            {
                                if (!ArtistComboBx.Items.Contains(newArtist))
                                {
                                    ArtistComboBx.Items.Add(newArtist);
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
                                            StandardizeText(ref z);
                                            songCmd.Parameters["@SongName"].Value = z;
                                            songCmd.Parameters.AddWithValue("@AlbumID", nextID);
                                            songCmd.ExecuteNonQuery();
                                            tmpSngLst.Add(y);

                                        }
                                        nextID++;

                                        x.setSongName(tmpSngLst);

                                        //foreach(string x in AddSongBx.Text)

                                    }
                                    catch (Exception ex)
                                    {
                                        Debug.WriteLine(ex.StackTrace);
                                    }
                                    finally
                                    {
                                        songConn.Close();
                                    }
                                }
                            }

                        }

                        catch (Exception ex)
                        {
                            Debug.WriteLine("Error opening file" + ex.StackTrace);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }

                }
            }
        }

        private void searchBtN_Click(object sender, EventArgs e)
        {
            ResultsList.Rows.Clear();
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
                ;
                DataGridViewRow derp = new DataGridViewRow();
                derp.CreateCells(ResultsList, arrayStr);

                ResultsList.Rows.Add(derp);

                //displayStr += x.getAlbum() + " by " + x.getArtist() + "(" + x.getGenre() + ")\n\n";
            }

            ResultsList.CurrentCell = null;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string sqlIns = @"INSERT INTO LoginDTB (`Username`,`Password`,`UserLevel`, `EmailAddress`) values (?,?,?,?)";
            string sqlQuery = @"SELECT * FROM LoginDTB";
            const int noEditPms = 0;
            bool canAddUser = true;
            using (OleDbConnection connLg = new OleDbConnection(userPathStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, connLg))
                {


                    try
                    {
                        //OleDbCommand InsertCmd = new OleDbCommand(sqlIns, connLg);

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
                        cmd.Dispose();
                        connLg.Close();
                    }

                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error opening file.\n" + ex.StackTrace);
                    }


                    if (canAddUser == true)
                    {

                        try
                        {


                            using (OleDbCommand InsertCmd = new OleDbCommand(sqlIns, connLg))
                            {


                                connLg.Open();

                                InsertCmd.Parameters.AddWithValue("@Username", this.txtNewUsrName.Text.Trim());
                                InsertCmd.Parameters.AddWithValue("@Password", this.txtNewUsrPwd.Text.Trim());
                                InsertCmd.Parameters.AddWithValue("@UserLevel", noEditPms.ToString());
                                InsertCmd.Parameters.AddWithValue("@EmailAddress", this.txtNewUsrEmail.Text.Trim());

                                InsertCmd.ExecuteNonQuery();


                                InsertCmd.Dispose();

                                newUsrLbl.Text = "New user? Sign up here!";
                            }
                            Cleanup();
                            PanelSwitch(loginPnl.Name);
                        }

                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.StackTrace);
                        }
                    }
                }
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            Cleanup();
        }

        private void exitTsr_Click(object sender, EventArgs e)
        {
            //Cleanup();
            this.Close();
        }

        private void SwitchToLoginPanelTsr_Click(object sender, EventArgs e)
        {
            //Switch to login Panel
            PanelSwitch(loginPnl.Name);
        }

        private void SwitchToCdeditPanelTsr_Click(object sender, EventArgs e)
        {
            PanelSwitch(cdEditPnl.Name);
        }

        ///<param name="passPanel"> Used to determine want visible </param>
        ///<summary>Makes all panels invivble except for the one with the same name as the passed in value</summary>
        private void PanelSwitch(string passPanel)
        {
            string currentPanel;
            string ignorePanel = passPanel;
            foreach (Control pnl in this.Controls)
            {
                currentPanel = pnl.Name;
                if (currentPanel == "cdManagermns") //Not a panel
                {
                    continue;
                }
                if (currentPanel == ignorePanel)
                {
                    pnl.Visible = true;
                    pnl.Enabled = true;
                    continue;
                }
                pnl.Visible = false;
                pnl.Enabled = false;
            }

            Cleanup();
        }

        private void SwitchToAddCdPnl_Click(object sender, EventArgs e)
        {
            int x = currUsr.getUserLevel();
            if (currUsr.getUserLevel() >= 2)
            {
                PanelSwitch(addCdPnl.Name);
            }
        }

        private void PasswdBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LoginBtn_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Changes Userlevel to 1 [Guess]
        /// Edits the menu strip to reflect the user level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutTsr_Click(object sender, EventArgs e)
        {
            //todo make sure the user is sure in loging out
            currUsr.setUserLevel(1);
            SwtichToLoginPanelTsr.Visible = true;
            currentUserTsr.Visible = false;
            SwitchToAddCdPanleTsr.Visible = false;
            PanelSwitch(loginPnl.Name);
        }

        private void switchToAdminPanelTsr_Click(object sender, EventArgs e)
        {
            PanelSwitch(AdminPnl.Name);
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
                            UserListBx.Items.Add((string)reader["Username"]);

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

        private void switchToRegisterPanelTsr_Click(object sender, EventArgs e)
        {
            PanelSwitch(registerPnl.Name);
        }

        private void ResultsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (ResultsList.SelectedCells.Count == 0)
            {
                return;
            }
            else
            {
               
                string tempArtist = "";
                string tmpAlbum = "";
                try
                {

                    tmpAlbum = ResultsList.SelectedRows[0].Cells["AlbumCol"].Value.ToString();
                    tempArtist = ResultsList.SelectedRows[0].Cells["ArtistCol"].Value.ToString();

                            foreach (Cd x in CdList)
                            {
                                if (x.getAlbum() == tmpAlbum)
                                {
                                    SongListView.Rows.Clear();
                                    foreach (string y in x.getSongName())
                                    {
                                        int indx = 0;
                                        indx = x.getSongName().IndexOf(y) + 1;
                                        string tmp = indx.ToString();
                                        string[] newrow = { y, tmp};
                                        DataGridViewRow newItem = new DataGridViewRow();
                                        newItem.CreateCells(SongListView, newrow);
                                        SongListView.Rows.Add(newItem);

                                    }
                                    break;
                                }
                            }
                             
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                }

            }
        }
        void AutoCompleteSearchTB()
        {
            string album;
            searchBx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchBx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();

            foreach (Cd x in CdList)
            {
                album = x.getAlbum();
                collect.Add(album);
            }
            searchBx.AutoCompleteCustomSource = collect;
        }
        void AutoCompleteNewCD()
        {
            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                string pAlbum;
                string pArtist;
                string pGenre;
                string sqlQuery = "SELECT `Album`,`Artist`,`Genre` FROM CDdtb";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                addAlbumBx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                addAlbumBx.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection collectA = new AutoCompleteStringCollection();
                AutoCompleteStringCollection collectArt = new AutoCompleteStringCollection();
                AutoCompleteStringCollection collectG = new AutoCompleteStringCollection();

                try
                {
                    conn.Open();

                    try
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pAlbum = ((string)reader["Album"]);
                            pArtist = ((string)reader["Artist"]);
                            pGenre = ((string)reader["Genre"]);
                            collectA.Add(pAlbum);
                            collectArt.Add(pArtist);
                            collectG.Add(pGenre);
                        }
                        addAlbumBx.AutoCompleteCustomSource = collectA;
                        addArtistBx.AutoCompleteCustomSource = collectArt;
                        addGenreBx.AutoCompleteCustomSource = collectG;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error reading from database\n" + ex.StackTrace.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error opening database file\n" + ex.StackTrace.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            ResultsList.Rows.Clear();
            foreach (Cd x in CdList)
            {
                String[] arrayStr;
                string tmpDate = x.getDate().ToShortDateString();
                arrayStr = new String[5] { x.getAlbum(), x.getArtist(), x.getGenre(), tmpDate, x.getID() };

                DataGridViewRow derp = new DataGridViewRow();
                derp.CreateCells(ResultsList, arrayStr);

                ResultsList.Rows.Add(derp);


            }
            ResultsList.CurrentCell = null;
        }

        private void ResultsList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ResultsList.ClearSelection();
            return;
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResultsList.CurrentCell == null)
            {
                return;
            }
            else
            {
                ResultsList.ReadOnly = false;
                ResultsList.SelectedRows[0].ReadOnly = false;
                foreach (DataGridViewRow x in ResultsList.Rows)
                {
                    if (x != ResultsList.SelectedRows[0])
                    {
                        x.ReadOnly = true;
                    }

                }
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResultsList.CurrentCell == null)
            {
                return;
            }
            else
            {
                string SongDeleteStr = @"DELETE FROM SongListDTB WHERE AlbumID = @AlbumID";

                using (OleDbConnection conn = new OleDbConnection(songPathStr))
                {
                    using (OleDbCommand DelCmd = new OleDbCommand(SongDeleteStr, conn))
                    {
                        DelCmd.Parameters.AddWithValue("@AlbumID", ResultsList.SelectedRows[0].Cells["IdCol"].Value);
                        conn.Open();
                        DelCmd.ExecuteNonQuery();
                        conn.Close();

                        SongListView.Rows.Clear();
                    }
                }
                string DeleteStr = @"DELETE FROM CDdtb WHERE AlbumID = @AlbumID";

                using (OleDbConnection conn = new OleDbConnection(pathStr))
                {
                    using (OleDbCommand DelCmd = new OleDbCommand(DeleteStr, conn))
                    {
                        DelCmd.Parameters.AddWithValue("@AlbumID", ResultsList.SelectedRows[0].Cells["IdCol"].Value);
                        conn.Open();
                        DelCmd.ExecuteNonQuery();
                        conn.Close();

                        for (int i = 0; i < CdList.Count; i++)
                        {
                            if (CdList.ElementAt<Cd>(i).getID() == ResultsList.SelectedRows[0].Cells["IdCol"].Value.ToString())
                            {
                                CdList.Remove(CdList.ElementAt<Cd>(i));
                                break;
                            }
                        }

                        ResultsList.Rows.Remove(ResultsList.SelectedRows[0]);
                    }
                }




            }
        }

        private void applyChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedList<Cd> EditCdList = new LinkedList<Cd>();
            foreach (DataGridViewRow x in ResultsList.Rows)
            {
                string tempAlbum = (x.Cells["AlbumCol"].Value.ToString());
                string tempArtist = (x.Cells["ArtistCol"].Value.ToString());
                string tempGenre = (x.Cells["GenreCol"].Value.ToString());
                string tempId = (x.Cells["IdCol"].Value.ToString());
                StandardizeText(ref tempAlbum);
                StandardizeText(ref tempArtist);
                StandardizeText(ref tempGenre);

                Cd tempCd = new Cd();
                tempCd.setAlbum(tempAlbum);
                tempCd.setArtist(tempArtist);
                tempCd.setGenre(tempGenre);
                tempCd.setId(tempId);

                if (!CdList.Contains(tempCd))
                {
                    EditCdList.AddLast(tempCd);
                }


            }

            string UpdCmdStr = @"UPDATE CDdtb SET Album = @Album, Artist = @Artist, Genre = @Genre, DateStr = @DateStr Where AlbumID = @AlbumID";
            string SongListUpdCmdStr = "UPDATE SongListDTB SET Album = @Album, Artist = @Artist Where AlbumID = @AlbumID";
            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                using (OleDbCommand UpdCmd = new OleDbCommand(UpdCmdStr, conn))
                {

                    conn.Open();
                    foreach (Cd x in EditCdList)
                    {
                        UpdCmd.Parameters.Clear();
                        UpdCmd.Parameters.AddWithValue("@Album", x.getAlbum());
                        UpdCmd.Parameters.AddWithValue("@Artist", x.getArtist());
                        UpdCmd.Parameters.AddWithValue("@Genre", x.getGenre());
                        UpdCmd.Parameters.AddWithValue("@DateStr", x.getDate());
                        UpdCmd.Parameters.AddWithValue("@AlbumID", x.getID());
                        UpdCmd.ExecuteNonQuery();


                        foreach (Cd y in CdList)
                        {
                            if (y.getID() == x.getID())
                            {
                                y.setAlbum(x.getAlbum());
                                y.setArtist(x.getArtist());
                                y.setGenre(x.getGenre());
                                break;

                            }
                        }
                    }
                }
                conn.Close();
                //List<string> tmpLst = new List<string>();

                using (OleDbConnection SongListConn = new OleDbConnection(songPathStr))
                {
                    using (OleDbCommand SongUpdCmd = new OleDbCommand(SongListUpdCmdStr, SongListConn))
                    {
                        SongListConn.Open();
                        foreach (Cd x in EditCdList)
                        {

                            SongUpdCmd.Parameters.Clear();
                            SongUpdCmd.Parameters.AddWithValue("@Album", x.getAlbum());
                            SongUpdCmd.Parameters.AddWithValue("@Artist", x.getArtist());
                            SongUpdCmd.ExecuteNonQuery();
                        }
                        SongListConn.Close();


                    }
                }
            }
        }

        private void SongListToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (SongListView.CurrentCell == null || SongListView.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                SongListView.ReadOnly = false;
                SongListView.SelectedRows[0].ReadOnly = false;
                foreach (DataGridViewRow x in SongListView.Rows)
                {
                    if (x != SongListView.SelectedRows[0])
                    {
                        x.ReadOnly = true;
                    }

                }
            }
        }

        private void SongListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ResultsList.SelectedCells.Count == 0)
            {
                return;
            }
        }

        private void SongListToolStripMenuItemApplyChanges_Click(object sender, EventArgs e)
        {

        }
    }
}


