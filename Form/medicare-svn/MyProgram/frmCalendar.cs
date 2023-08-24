using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace MyProgram
{
    public partial class frmCalendar : Form
    {
        clsUser user = null;

        public frmCalendar(clsUser user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            FrmExamCalendar f1 = new FrmExamCalendar();
            f1.TopLevel = false; f1.ShowIcon = false;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.splitContainer1.Panel1.Controls.Add(f1);

            f1.Show();
            f1.Dock = DockStyle.Fill; f1.BringToFront();

            FrmDrugCalendar f2 = new FrmDrugCalendar();
            f2.TopLevel = false; f2.ShowIcon = false;
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.splitContainer1.Panel2.Controls.Add(f2);

            f2.Show();
            f2.Dock = DockStyle.Fill; f2.BringToFront();
        }
    }
}
