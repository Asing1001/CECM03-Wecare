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
    public partial class FrmExamOverAdd : FrmBaseModify
    {
        public FrmExamOverAdd()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void FrmExamOverAdd_Load(object sender, EventArgs e)
        {
            var q = from f in db.ExamCategories
                    select f.ExamCat_Name;

            this.comboBox2.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要新增嗎?", "新增確認",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExamOverview div = new ExamOverview
                {
                    Exam_NameEN = this.textBox1.Text,
                    Exam_NameCH = this.textBox2.Text,
                    Exam_Sex = this.comboBox1.SelectedText,
                    Exam_Unit = this.textBox4.Text,
                    Exam_UpLim = this.textBox5.Text,
                    Exam_LowLim = this.textBox6.Text,
                    Exam_WarnPct = decimal.Parse(this.textBox7.Text),
                    ExamCat_ID = this.comboBox2.SelectedIndex + 1
                };

                db.ExamOverview.InsertOnSubmit(div);
                db.SubmitChanges();
            
                this.Close();
            }
        }
    }
}
