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
    public partial class FrmExamOverviewCT : FrmBase
    {
        public FrmExamOverviewCT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.ExamOverview
                        join c in db.ExamCategories on f.ExamCat_ID equals c.ExamCat_ID
                        select new
                        {
                            檢驗項目ID = f.Exam_ID,
                            英文名稱 = f.Exam_NameEN,
                            中文名稱 = f.Exam_NameCH,
                            限定性別 = f.Exam_Sex,
                            檢驗值單位 = f.Exam_Unit,
                            檢驗值上限 = f.Exam_UpLim,
                            檢驗值下限 = f.Exam_LowLim,
                            危險值百分比 = f.Exam_WarnPct,
                            檢驗類別名稱 = c.ExamCat_Name
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.ExamOverview
                        join c in db.ExamCategories on f.ExamCat_ID equals c.ExamCat_ID
                        where f.Exam_NameCH.Contains(this.textBox1.Text)
                        select new
                        {
                            檢驗項目ID = f.Exam_ID,
                            英文名稱 = f.Exam_NameEN,
                            中文名稱 = f.Exam_NameCH,
                            限定性別 = f.Exam_Sex,
                            檢驗值單位 = f.Exam_Unit,
                            檢驗值上限 = f.Exam_UpLim,
                            檢驗值下限 = f.Exam_LowLim,
                            危險值百分比 = f.Exam_WarnPct,
                            檢驗類別名稱 = c.ExamCat_Name
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmExamOverAdd fd = new FrmExamOverAdd())
            {
                fd.ShowDialog();
            }

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.ExamOverview
                        join c in dba.ExamCategories on f.ExamCat_ID equals c.ExamCat_ID
                        select new
                        {
                            檢驗項目ID = f.Exam_ID,
                            英文名稱 = f.Exam_NameEN,
                            中文名稱 = f.Exam_NameCH,
                            限定性別 = f.Exam_Sex,
                            檢驗值單位 = f.Exam_Unit,
                            檢驗值上限 = f.Exam_UpLim,
                            檢驗值下限 = f.Exam_LowLim,
                            危險值百分比 = f.Exam_WarnPct,
                            檢驗類別名稱 = c.ExamCat_Name
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                using (FrmExamOverMF fd = new FrmExamOverMF())
                {
                    fd.drugovIndx = (int)this.dataGridView1.SelectedCells[0].Value;

                    fd.ShowDialog();
                }

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.ExamOverview
                            join c in dba.ExamCategories on f.ExamCat_ID equals c.ExamCat_ID
                            select new
                            {
                                檢驗項目ID = f.Exam_ID,
                                英文名稱 = f.Exam_NameEN,
                                中文名稱 = f.Exam_NameCH,
                                限定性別 = f.Exam_Sex,
                                檢驗值單位 = f.Exam_Unit,
                                檢驗值上限 = f.Exam_UpLim,
                                檢驗值下限 = f.Exam_LowLim,
                                危險值百分比 = f.Exam_WarnPct,
                                檢驗類別名稱 = c.ExamCat_Name
                            };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
            else { MessageBox.Show("請先選擇編輯項目"); }
        }
    }
}
