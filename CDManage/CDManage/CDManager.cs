using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDManage
{
   /* class CDManager
    {
        private string albumName;
        private string date;
        private string ID;
        private string artistName;
        private string genre;
        private string songName;
        private int songNum; */


        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 showForm;
            showForm = new Form1();

            showForm.addCDBtn();
            showForm.addCDnameTxt();
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
    public partial class Form1 : Form
    {
        private TextBox CDnameTxt;
        
        public void addCDBtn()
        {
            Button addCDBtn = new Button();
            addCDBtn.Height = 40;
            addCDBtn.Width = 70;
            addCDBtn.Text = "Add CD";
            addCDBtn.Name = "addCDBtn";
            addCDBtn.Location = new Point(20, 180);
            addCDBtn.Font = new Font("Georgia", 16);
            this.Controls.Add(addCDBtn);
        }
        public void addCDnameTxt()
        {
            TextBox CDnameTxt = new TextBox();
            CDnameTxt.Height = 40;
            CDnameTxt.Width = 100;
            CDnameTxt.Location = new Point(20, 150);
            CDnameTxt.Name = "CDnameTxt";
            this.Controls.Add(CDnameTxt);
        }
        private void addCDBtn_Click(object sender, EventArgs e)
        {
           // CDManager.albumName = CDnameTxt.Text.Trim();
        }
    }
}
