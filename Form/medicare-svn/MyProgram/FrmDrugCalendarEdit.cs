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
    public partial class FrmDrugCalendarEdit : Form
    {
        internal ClsDrugCalendar dCal;
        MyDB.MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        public FrmDrugCalendarEdit()
        {
            InitializeComponent();
        }

        private void FrmDrugCalendarEdit_Load(object sender, EventArgs e)
        {
            病患Ptt_NameTextBox.Text = dCal.Ptt_Name;
            txtNameEN.Text = dCal.Drug_NameEN;
            txtNameCH.Text = dCal.Drug_NameCH;
            cbRmd.Checked = dCal.DrugCal_Rmd;
            txtRem.Text = dCal.DrugCal_Rem;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dCal.DrugCal_Rmd = cbRmd.Checked;
            dCal.DrugCal_Rem = txtRem.Text;

            if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dCal.Updata();

                ClsRecord.Record(sender, this.Name, dCal.Ptt_ID);

                db.Dispose();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後修改資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Dispose();
                this.Close();
            }
        }
    }
}
