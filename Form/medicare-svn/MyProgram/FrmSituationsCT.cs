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
    public partial class FrmSituationsCT : FrmBase
    {
        public FrmSituationsCT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.Situations
                        select new
                        {
                            狀態名稱ID = f.Status_ID,
                            狀態名稱 = f.Status_Name
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.Situations
                        where f.Status_Name.Contains(this.textBox1.Text)
                        select new
                        {
                            狀態名稱ID = f.Status_ID,
                            狀態名稱 = f.Status_Name
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmSituationsAdd fd = new FrmSituationsAdd())
            {
                fd.ShowDialog();
            }

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.Situations
                        select new
                        {
                            狀態名稱ID = f.Status_ID,
                            狀態名稱 = f.Status_Name
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                using (FrmSituationsAdd fd = new FrmSituationsAdd())
                {
                    fd.Divname = this.dataGridView1.SelectedCells[1].Value.ToString();
                    fd.label4.Text = "編輯 狀態項目";
                    fd.ShowDialog();
                }

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.Situations
                            select new
                            {
                                狀態名稱ID = f.Status_ID,
                                狀態名稱 = f.Status_Name
                            };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
            else { MessageBox.Show("請先選擇編輯項目"); }
        }
    }
}
