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
            this.Size = new Size(360,500);
            foreach(Panel myPnl in this.Controls)
            {
                myPnl.Location = new Point(0, 0);
                myPnl.Size = new Size(360, 500);
            }
            loginPnL.Enabled = false;
            loginPnL.Visible = false;
            AdminPnL.Enabled = false;
            AdminPnL.Visible = false;
            usrPnL.Enabled = false;
            usrPnL.Visible = false;
        }

        private void switchToLoginPnlBtn_Click(object sender, EventArgs e)
        {
            guestPnL.Enabled = false;
            guestPnL.Visible = false;
            loginPnL.Enabled = true;
            loginPnL.Visible = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginPnL.Enabled = false;
            loginPnL.Visible = false;
            usrPnL.Enabled = true;
            usrPnL.Visible = true;
        }
    }
}
