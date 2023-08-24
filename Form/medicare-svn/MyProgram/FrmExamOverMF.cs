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
    public partial class FrmExamOverMF : FrmBaseModify
    {
        public FrmExamOverMF()
        {
            InitializeComponent();
        }

        private void FrmExamOverMF_Load(object sender, EventArgs e)
        {
            var qp = from f in db.ExamCategories
                     select f.ExamCat_Name;

            this.comboBox2.DataSource = qp.ToList();

            var q = (from f in db.ExamOverview
                     where f.Exam_ID == drugovIndx
                     select f).First();

            this.textBox1.Text = q.Exam_NameEN;
            this.textBox2.Text = q.Exam_NameCH;
            this.comboBox1.SelectedText = q.Exam_Sex;
            this.textBox4.Text = q.Exam_Unit;
            this.textBox5.Text = q.Exam_UpLim;
            this.textBox6.Text = q.Exam_LowLim;
            this.textBox7.Text = q.Exam_WarnPct.ToString();
            this.comboBox2.SelectedIndex = q.ExamCat_ID - 1;
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        internal int drugovIndx;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var q = (from f in db.ExamOverview
                         where f.ExamCat_ID == drugovIndx
                         select f).First();

                q.Exam_NameEN = this.textBox1.Text;
                q.Exam_NameCH = this.textBox2.Text;
                q.Exam_Sex = this.comboBox1.SelectedText;
                q.Exam_Unit = this.textBox4.Text;
                q.Exam_UpLim = this.textBox5.Text;
                q.Exam_LowLim = this.textBox6.Text;
                q.Exam_WarnPct = decimal.Parse(this.textBox7.Text);
                q.ExamCat_ID = this.comboBox2.SelectedIndex + 1;

                db.SubmitChanges();

                this.Close();
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
