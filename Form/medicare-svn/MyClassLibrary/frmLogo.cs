using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_TimeNow.Text = DateTime.Now.ToShortTimeString();
        }

        protected void AddButton(string[] strFunctions)
        {
            foreach (string each in strFunctions)
            {
                this.flowLayoutPanel1.Controls.Add(new Button { Name = string.Format("btn_{0}", strFunctions),
                                                                Text = each,
                                                                AutoSize = false,
                                                                Size = new System.Drawing.Size(190, 80),
                                                                FlatStyle = System.Windows.Forms.FlatStyle.Popup,
                                                                Padding = new System.Windows.Forms.Padding(0),
                                                                Font = new System.Drawing.Font(FontFamily.GenericMonospace, 20),
                                                                Margin = new System.Windows.Forms.Padding(5, 2, 2, 2),
                                                                BackColor = Color.AliceBlue });
            }
        }
    }
}
