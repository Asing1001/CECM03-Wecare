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
    public partial class FrmDivisionsCT : FrmBase
    {
        public FrmDivisionsCT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.Divisions
                        select new { 科別ID=f.Div_ID,科別名稱=f.Div_Name};

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.Divisions
                        where f.Div_Name.Contains(this.textBox1.Text)
                        select new { 科別ID = f.Div_ID, 科別名稱 = f.Div_Name };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDivAdd fd = new FrmDivAdd();
            fd.ShowDialog();

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.Divisions
                        select new { 科別ID = f.Div_ID, 科別名稱 = f.Div_Name };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDivEdit fd = new FrmDivEdit();

            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                fd.Divname = this.dataGridView1.SelectedCells[1].Value.ToString();
                fd.ShowDialog();

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.Divisions
                            select new { 科別ID = f.Div_ID, 科別名稱 = f.Div_Name };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
            else { MessageBox.Show("請先選擇編輯項目"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
