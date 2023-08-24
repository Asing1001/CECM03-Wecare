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
    public partial class FrmJBT : FrmBase
    {
        public FrmJBT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.JobTitles
                        select new
                        {
                            職稱ID = f.Job_ID,
                            職稱 = f.Job_Title
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.JobTitles
                        where f.Job_Title.Contains(this.textBox1.Text)
                        select new
                        {
                            職稱ID = f.Job_ID,
                            職稱 = f.Job_Title
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmJBTAdd fd = new  FrmJBTAdd();
            fd.ShowDialog();

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.JobTitles
                        select new
                        {
                            職稱ID = f.Job_ID,
                            職稱 = f.Job_Title
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                FrmJBTEdit fd = new FrmJBTEdit();
                fd.Divname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                fd.ShowDialog();


                MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext();
                var q = from f in dba.JobTitles
                        select new
                        {
                            職稱ID = f.Job_ID,
                            職稱 = f.Job_Title
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else { MessageBox.Show("請先選擇編輯項目"); }


        }
    }
}