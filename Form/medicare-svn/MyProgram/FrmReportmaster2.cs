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
    public partial class FrmReportmaster2 : Form
    {
        public FrmReportmaster2()
        {
            InitializeComponent();
        }

        private void FrmReportmaster2_Load(object sender, EventArgs e)
        {
            int tWidth=(this.ClientSize.Width)*5 / 13;
            this.chtbar.Width = this.chtpie.Width = this.chtsex.Width = tWidth;
            this.chtage.Width = tWidth ;
            int tHeight= this.chtpie.Height = this.chtsex.Height=this.chtbar.Height = this.chtage.Height= (this.ClientSize.Height) / 3;
            this.chtpie.Location = new Point(tWidth / 20, tHeight / 3);
            this.chtsex.Location = new Point(tWidth / 20, tHeight * 5 / 3); //tWidth /20
            this.chtbar.Location = new Point(tWidth* 16/ 15, tHeight / 3);
            this.chtage.Location = new Point(tWidth* 16/ 15, tHeight * 5 / 3);
            
        }
    }
}
