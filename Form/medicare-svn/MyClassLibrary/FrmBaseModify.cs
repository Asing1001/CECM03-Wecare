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
    public partial class FrmBaseModify : Form
    {
        public FrmBaseModify()
        {
            InitializeComponent();

            this.label4.BackColor = this.BackColor;
        }

        private void FrmBaseModify_Load(object sender, EventArgs e)
        {
            this.label4.Left = (this.pictureBox2.Width/2)-(this.label4.Width/2);
            this.label4.Height = this.pictureBox2.Height;
            this.pictureBox1.Width = this.ClientSize.Width;
        }
    }
}
