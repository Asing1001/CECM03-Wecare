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
using MyDB;

namespace MyProgram
{
    public partial class FrmDrugOverMf : FrmBaseModify
    {
        public FrmDrugOverMf()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        internal int drugovIndx;

        private void FrmDrugOverMf_Load(object sender, EventArgs e)
        {
            var q = (from f in db.DrugOverview
                     where f.Drug_ID == drugovIndx
                     select f).First();

            this.textBox1.Text = q.Drug_NameEN;
            this.textBox2.Text = q.Drug_NameCH;
            this.textBox3.Text = q.Drug_UnMass;
            this.textBox4.Text = q.Drug_Usage;
            this.textBox5.Text = q.Drug_Dosage;
            this.textBox6.Text = q.Drug_App;
            this.textBox7.Text = q.Drug_Indication;
            this.textBox8.Text = q.Drug_SE;
            this.textBox9.Text = q.Drug_WAC;
            this.textBox10.Text = q.Drug_OIoS;
            this.checkBox1.Checked = (bool)q.Drug_SpD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (db.DrugOverview.Where(n => n.Drug_NameEN == this.textBox1.Text).Count() == 0
                    && db.DrugOverview.Where(n => n.Drug_NameCH == this.textBox2.Text).Count() == 0)
                {
                    var q = (from f in db.DrugOverview
                             where f.Drug_ID == drugovIndx
                             select f).First();

                    q.Drug_NameEN = this.textBox1.Text;
                    q.Drug_NameCH = this.textBox2.Text;
                    q.Drug_UnMass = this.textBox3.Text;
                    q.Drug_Usage = this.textBox4.Text;
                    q.Drug_Dosage = this.textBox5.Text;
                    q.Drug_App = this.textBox6.Text;
                    q.Drug_Indication = this.textBox7.Text;
                    q.Drug_SE = this.textBox8.Text;
                    q.Drug_WAC = this.textBox9.Text;
                    q.Drug_OIoS = this.textBox10.Text;
                    q.Drug_SpD = this.checkBox1.Checked;
                    db.SubmitChanges();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("已有相同項目存在，請確認");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後修改資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
