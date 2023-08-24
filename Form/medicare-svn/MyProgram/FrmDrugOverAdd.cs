using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDB;
using MyClassLibrary;

namespace MyProgram
{
    public partial class FrmDrugOverAdd : FrmBaseModify
    {
        public FrmDrugOverAdd()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要新增嗎?", "新增確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (db.DrugOverview.Where(n => n.Drug_NameEN == this.textBox1.Text).Count() == 0 
                    && db.DrugOverview.Where(n => n.Drug_NameCH == this.textBox2.Text).Count() == 0)
                {
                    DrugOverview div = new DrugOverview
                    {
                        Drug_NameEN = this.textBox1.Text,
                        Drug_NameCH = this.textBox2.Text,
                        Drug_UnMass = this.textBox3.Text,
                        Drug_Usage = this.textBox4.Text,
                        Drug_Dosage = this.textBox5.Text,
                        Drug_App = this.textBox6.Text,
                        Drug_Indication = this.textBox7.Text,
                        Drug_SE = this.textBox8.Text,
                        Drug_WAC = this.textBox9.Text,
                        Drug_OIoS = this.textBox10.Text,
                        Drug_SpD = this.checkBox1.Checked
                    };

                    db.DrugOverview.InsertOnSubmit(div);
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
            if (MessageBox.Show("確定要取消嗎?\n取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
