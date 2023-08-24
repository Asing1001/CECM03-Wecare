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
    public partial class FrmExamCategoriesCT : FrmBase
    {
        public FrmExamCategoriesCT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.ExamCategories
                        select new {
                            檢驗類別ID = f.ExamCat_ID,
                            檢驗類別名稱 = f.ExamCat_Name,
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.ExamCategories
                        where f.ExamCat_Name.Contains(this.textBox1.Text)
                        select new
                        {
                            檢驗類別ID = f.ExamCat_ID,
                            檢驗類別名稱 = f.ExamCat_Name,
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmExamCategAdd fd = new FrmExamCategAdd())
            {
                fd.ShowDialog();

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.ExamCategories
                            select new
                            {
                                檢驗類別ID = f.ExamCat_ID,
                                檢驗類別名稱 = f.ExamCat_Name,
                            };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FrmExamCategAdd fd = new FrmExamCategAdd())
            {
                fd.label4.Text = "編輯 檢查類別";

                if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
                {
                    fd.Divname = this.dataGridView1.SelectedCells[1].Value.ToString();
                    fd.ShowDialog();

                    using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                    {
                        var q = from f in dba.ExamCategories
                                select new
                                {
                                    檢驗類別ID = f.ExamCat_ID,
                                    檢驗類別名稱 = f.ExamCat_Name,
                                };

                        this.dataGridView1.DataSource = q.ToList();
                    }
                }
                else { MessageBox.Show("請先選擇編輯項目"); }
            }
        }       
    }
}
