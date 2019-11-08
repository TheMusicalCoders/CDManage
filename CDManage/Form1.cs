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


namespace CDManage
{
    public partial class Form1 : Form
    {
        string pathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../CDdtb.accdb");
        string userPathStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../LoginCheckDTB.accdb");
        string invalidLogin = "Invalid Username/password combination";


        LinkedList<Cd> CdList = new LinkedList<Cd>();


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


            this.Size = new Size(360, 500);
            foreach (Panel myPnl in this.Controls)
            {
                myPnl.Location = new Point(0, 0);
                myPnl.Size = new Size(360, 450);
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



            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM CDdtb";
                    OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);

                    conn.Open();
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
                    conn.Close();





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
                catch { MessageBox.Show("Error opening file"); }
            }


            //switchToAddCdPanelBtn.Visible = false;
            //swithToAdminPanelBtn.Visible = false;
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


                    if (reader.HasRows)
                    {
                        //read/assign userlevel here?
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
                    conn.Close();
                }
                catch { MessageBox.Show("Error opening file"); }
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

        private void SwitchToAdminPnlBtn_Click(object sender, EventArgs e)
        {
            //Switch to the admin Panel
            AdminPnL.Enabled = true;
            AdminPnL.Visible = true;
            loginPnL.Enabled = false;
            loginPnL.Visible = false;
        }


        private void UserListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedUserBx.Text = UserListBx.SelectedItem.ToString();
        }


        private void AddPermissionBtn_Click_1(object sender, EventArgs e)
        {
            if (SelectedUserBx.Text.Trim() != "")
            {
                string AddCptn = "Confirmation";
                string AddMsg = "Are you sure you want to give " + SelectedUserBx.Text.Trim() + " edit permissions?";
                MessageBox.Show(AddMsg, AddCptn, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else { MessageBox.Show("Please Select a user"); }
        }

        private void RemovePermissionBtn_Click_1(object sender, EventArgs e)
        {
            if (SelectedUserBx.Text.Trim() != "")
            {
                string RemoveCptn = "Confirmation";
                string RemoveMsg = "Are you sure you want to remove " + SelectedUserBx.Text.Trim() + "'s edit permissions?";
                MessageBox.Show(RemoveMsg, RemoveCptn, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void swithToAdminPanelBtn_Click(object sender, EventArgs e)
        {
            //Switch to the admin Panel
            AdminPnL.BringToFront();
            AdminPnL.Visible = true;
            AdminPnL.Enabled = true;
        }

        private void AddCDBtn_Click(object sender, EventArgs e)
        {

            string sqlQuery = @"INSERT INTO CDdtb (`Album`,`Artist`,`Genre`,`DateStr`) values (?,?,?,?)";
            using (OleDbConnection conn = new OleDbConnection(pathStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
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



                    }

                    catch { MessageBox.Show("Error opening file"); }


                }
            }

        }

        private void searchBtN_Click(object sender, EventArgs e)
        {
            LinkedList<Cd> SearchResults = new LinkedList<Cd>();
            string album = searchBx.Text.Trim();
            string genre = "";
            string artist = "";
            string displayStr = "";
            if (GenreComboBx.SelectedIndex > -1)
            {
                genre = GenreComboBx.SelectedItem.ToString();
            }
            if (ArtistComboBx.SelectedIndex > -1)
            {
                artist = ArtistComboBx.SelectedItem.ToString();
            }

            foreach (Cd x in CdList)
            {
                if ((GenreComboBx.SelectedIndex > -1) || (ArtistComboBx.SelectedIndex > -1) || (album != ""))
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

            foreach(Cd x in SearchResults)
            {
                String[] arrayStr;
                arrayStr = new String[3] { x.getAlbum(), x.getArtist(), x.getGenre() };
                ListViewItem item = new ListViewItem(arrayStr);
                ResultsList.Items.Add(item);
                
                //displayStr += x.getAlbum() + " by " + x.getArtist() + "(" + x.getGenre() + ")\n\n";
            }

            
        }
    }
}

