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
    public partial class FrmExamFrequenciesCT : FrmBase
    {
        public FrmExamFrequenciesCT()
        {
            InitializeComponent();

            this.dataGridView1.Width = this.Width;
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.ExamFrequencies
                        select new
                        {
                            檢驗頻率ID = f.ExamFreq_ID,
                            檢驗頻率 = f.ExamFreq_EFC,
                            對應天數 = f.ExamFreq_Days
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.ExamFrequencies
                        where f.ExamFreq_EFC.Contains(this.textBox1.Text)
                        select new
                        {
                            檢驗頻率ID = f.ExamFreq_ID,
                            檢驗頻率 = f.ExamFreq_EFC,
                            對應天數 = f.ExamFreq_Days
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmExamFrequenciesAdd fd = new FrmExamFrequenciesAdd())
            {
                fd.ShowDialog();
            }

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.ExamFrequencies
                        select new
                        {
                            檢驗頻率ID = f.ExamFreq_ID,
                            檢驗頻率 = f.ExamFreq_EFC,
                            對應天數 = f.ExamFreq_Days
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                using (FrmExamFrequenciesAdd fd = new FrmExamFrequenciesAdd())
                {
                    fd.label4.Text = "編輯 檢驗頻率";
                    fd.drugFreq = this.dataGridView1.SelectedCells[1].Value.ToString();
                    fd.drugDay = (int)this.dataGridView1.SelectedCells[2].Value;
                    fd.ShowDialog();
                }

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.ExamFrequencies
                            select new
                            {
                                檢驗頻率ID = f.ExamFreq_ID,
                                檢驗頻率 = f.ExamFreq_EFC,
                                對應天數 = f.ExamFreq_Days
                            };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
            else { MessageBox.Show("請先選擇編輯項目"); }
        }
    }
}
