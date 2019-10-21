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
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //go to login panel
        }
        
    }

    /* class CDManager
   {
       private string albumName;
       private string date;
       private string ID;               These could be variables for user input. Or they could just be for reference.
       private string artistName;
       private string genre;
       private string songName;
       private int songNum; 
   }  */
}
