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
    public partial class frmUserManager : Form
    {
        public frmUserManager()
        {
            InitializeComponent();
        }

        private void frmUserManager_Load(object sender, EventArgs e)
        {
            if (this.tabPage1.Controls.Count > 0)
            {
                foreach (Control each in this.tabPage1.Controls)
                {
                    if (each is FrmNewStaff)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }
            else
            {
                FrmNewStaff f = new FrmNewStaff();
                this.showForm(f);
            }
        }

        private void showForm(Form f)
        {
            f.TopLevel = false; f.ShowIcon = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.tabPage1.Controls.Add(f);
            f.Show();
            f.Dock = DockStyle.Fill; f.BringToFront();
            f.Move += f_Move;
        }

        void f_Move(object sender, EventArgs e)
        {
            ((Form)sender).Location = new Point(0, 0);
        }
    }
}
