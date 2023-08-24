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
    public partial class FrmDrugFreqAdd : FrmBaseModify
    {
        public FrmDrugFreqAdd()
        {
            InitializeComponent();
        }

        internal string drugFreq;
        internal int drugDay;

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            MyDB.DrugFrequencies div = 
                new MyDB.DrugFrequencies { DrugFreq_DFC = this.textBox1.Text,  DrugFreq_Days = int.Parse(this.textBox2.Text) };

            if (db.DrugFrequencies.Where(n => n.DrugFreq_DFC == this.textBox1.Text).Count() != 0)
            {
                if (this.label3.Text == "")
                {
                    if (MessageBox.Show("確定要新增嗎?", "新增確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.DrugFrequencies.InsertOnSubmit(div);
                    }
                }
                else
                {
                    if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var q = (from f in db.DrugFrequencies
                                 where f.DrugFreq_DFC == this.label3.Text
                                 select f).First();

                        q.DrugFreq_DFC = this.textBox1.Text;
                        q.DrugFreq_Days = int.Parse(this.textBox2.Text);
                    }
                }

                db.SubmitChanges();

                this.Close();
            }
            else
            {
                MessageBox.Show("已有相同項目存在，請確認");
            }
        }

        private void FrmDrugFreqAdd_Load(object sender, EventArgs e)
        {
            this.label3.Text = drugFreq;
            this.label8.Text =drugDay.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = this.label3.Text == "" ? "確定要取消嗎?\n取消後新增資料將消失!!" : "確定要取消嗎?\n取消後修改資料將消失!!";

            if (MessageBox.Show(s, "取消確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
