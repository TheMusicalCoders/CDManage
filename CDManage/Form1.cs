using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDManage
{
    public partial class Form1 : Form
    {
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
            this.Size = new Size(360,500);
            foreach(Panel myPnl in this.Controls)
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

            switchToAddCdPanelBtn.Visible = false;
            swithToAdminPanelBtn.Visible = false;
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
            cdEditPnl.Enabled = true;
            cdEditPnl.Visible = true;
            loginPnL.Visible = false;
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
    }
}

