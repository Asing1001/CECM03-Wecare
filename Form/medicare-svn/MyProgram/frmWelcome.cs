using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        //bool a = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            DateTime t1 = DateTime.Now;

            while(true)
            {
                Application.DoEvents();

                DateTime t2 = DateTime.Now;
                double time = (t2 - t1).TotalSeconds;

                if(time > 3)
                {
                    this.Close();
                    break;
                }

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //a = false;

            this.Close();

            FrmLogin f = new FrmLogin();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
