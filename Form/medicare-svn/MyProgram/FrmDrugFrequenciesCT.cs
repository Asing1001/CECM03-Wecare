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
    public partial class FrmDrugFrequenciesCT : FrmBase
    {
        public FrmDrugFrequenciesCT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.DrugFrequencies
                        select new { 用藥頻率ID = f.DrugFreq_ID, 用藥頻率 = f.DrugFreq_DFC, 轉換天數 = f.DrugFreq_Days };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.DrugFrequencies
                        where f.DrugFreq_DFC.Contains(this.textBox1.Text)
                        select new { 用藥頻率ID = f.DrugFreq_ID, 用藥頻率 = f.DrugFreq_DFC, 轉換天數 = f.DrugFreq_Days };

                this.dataGridView1.DataSource = q.ToList();
            }

            this.dataGridView1.DefaultCellStyle.ForeColor =Color.Blue ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmDrugFreqAdd f = new FrmDrugFreqAdd())
            {
                f.ShowDialog();
            }

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.DrugFrequencies
                        select new { 用藥頻率ID = f.DrugFreq_ID, 用藥頻率 = f.DrugFreq_DFC, 轉換天數 = f.DrugFreq_Days };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                using (FrmDrugFreqAdd fd = new FrmDrugFreqAdd())
                {
                    fd.drugFreq = this.dataGridView1.SelectedCells[1].Value.ToString();
                    fd.drugDay = (int)this.dataGridView1.SelectedCells[2].Value;
                    fd.label4.Text = "編輯 用藥頻率";
                    fd.ShowDialog();
                }

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.DrugFrequencies
                            select new { 用藥頻率ID = f.DrugFreq_ID, 用藥頻率 = f.DrugFreq_DFC, 轉換天數 = f.DrugFreq_Days };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
            else { MessageBox.Show("請先選擇編輯項目"); }
        }
    }
}
