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
    public partial class FrmDrugOverviewCT : FrmBase
    {
        public FrmDrugOverviewCT()
        {
            InitializeComponent();
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.DrugOverview
                        select new {
                            藥物ID = f.Drug_ID,
                            英文名稱 = f.Drug_NameEN,
                            中文名稱 = f.Drug_NameCH,
                            單位含量 = f.Drug_UnMass,
                            使用方法 = f.Drug_Usage,
                            使用劑量 = f.Drug_Dosage,
                            藥物外觀 = f.Drug_App,
                            適應症狀 = f.Drug_Indication,
                            副作用 = f.Drug_SE,
                            警語 = f.Drug_WAC,
                            用藥指示 = f.Drug_OIoS,
                            特殊藥品 = f.Drug_SpD                        
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.DrugOverview
                        where f.Drug_NameCH.Contains(this.textBox1.Text)
                        select new
                        {
                            藥物ID = f.Drug_ID,
                            英文名稱 = f.Drug_NameEN,
                            中文名稱 = f.Drug_NameCH,
                            單位含量 = f.Drug_UnMass,
                            使用方法 = f.Drug_Usage,
                            使用劑量 = f.Drug_Dosage,
                            藥物外觀 = f.Drug_App,
                            適應症狀 = f.Drug_Indication,
                            副作用 = f.Drug_SE,
                            警語 = f.Drug_WAC,
                            用藥指示 = f.Drug_OIoS,
                            特殊藥品 = f.Drug_SpD
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmDrugOverAdd fd = new FrmDrugOverAdd())
            {
                fd.ShowDialog();
            }

            using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
            {
                var q = from f in dba.DrugOverview
                        select new
                        {
                            藥物ID = f.Drug_ID,
                            英文名稱 = f.Drug_NameEN,
                            中文名稱 = f.Drug_NameCH,
                            單位含量 = f.Drug_UnMass,
                            使用方法 = f.Drug_Usage,
                            使用劑量 = f.Drug_Dosage,
                            藥物外觀 = f.Drug_App,
                            適應症狀 = f.Drug_Indication,
                            副作用 = f.Drug_SE,
                            警語 = f.Drug_WAC,
                            用藥指示 = f.Drug_OIoS,
                            特殊藥品 = f.Drug_SpD
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && this.dataGridView1.DataSource != null)
            {
                using (FrmDrugOverMf fd = new FrmDrugOverMf())
                {
                    fd.drugovIndx = int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString());

                    fd.ShowDialog();
                }

                using (MedicareDataClassesDataContext dba = new MedicareDataClassesDataContext())
                {
                    var q = from f in dba.DrugOverview
                            select new
                            {
                                藥物ID = f.Drug_ID,
                                英文名稱 = f.Drug_NameEN,
                                中文名稱 = f.Drug_NameCH,
                                單位含量 = f.Drug_UnMass,
                                使用方法 = f.Drug_Usage,
                                使用劑量 = f.Drug_Dosage,
                                藥物外觀 = f.Drug_App,
                                適應症狀 = f.Drug_Indication,
                                副作用 = f.Drug_SE,
                                警語 = f.Drug_WAC,
                                用藥指示 = f.Drug_OIoS,
                                特殊藥品 = f.Drug_SpD
                            };

                    this.dataGridView1.DataSource = q.ToList();
                }
            }
            else { MessageBox.Show("請先選擇編輯項目"); }
        }
    }
}
