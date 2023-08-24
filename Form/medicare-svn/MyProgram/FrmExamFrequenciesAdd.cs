using MyClassLibrary;
using MyDB;
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
    public partial class FrmExamFrequenciesAdd : FrmBaseModify
    {
        public FrmExamFrequenciesAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
            DialogResult result =
                MessageBox.Show("確定要取消嗎?\n取消後修改資料將消失!!", "取消確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        internal string drugFreq;
        internal int drugDay;

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.errorM.Visible = true;
                return;
            }

            MyDB.ExamFrequencies div = 
                new MyDB.ExamFrequencies { ExamFreq_EFC = this.textBox1.Text, ExamFreq_Days = int.Parse(this.textBox2.Text) };
            
            if (this.label3.Text == "")
            {
                DialogResult res = MessageBox.Show("確定要新增嗎?", "新增確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    db.ExamFrequencies.InsertOnSubmit(div);
                    db.SubmitChanges();

                    this.Close();
                }
            }
            else
            {
                var q = (from f in db.ExamFrequencies
                         where f.ExamFreq_EFC == this.label3.Text
                         select f).First();

                q.ExamFreq_EFC = this.textBox1.Text;
                q.ExamFreq_Days = int.Parse(this.textBox2.Text);

                DialogResult result = 
                    MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    db.SubmitChanges();

                    this.Close();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }

            //不知道內碼則以字元也可
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }

        private void FrmExamFrequenciesAdd_Load(object sender, EventArgs e)
        {
            this.label3.Text = this.textBox1.Text = drugFreq;
            this.label8.Text = this.textBox2.Text = drugDay.ToString();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.errorM.Visible = false;
        }
    }
}
