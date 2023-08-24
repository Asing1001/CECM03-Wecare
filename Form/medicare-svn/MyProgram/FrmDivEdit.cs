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
    public partial class FrmDivEdit : FrmBaseModify
    {
        internal string Divname;

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        public FrmDivEdit()
        {
            InitializeComponent();
        }

        private void FrmDivEdit_Load(object sender, EventArgs e)
        {
            this.lblOldDivName.Text = Divname;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Divisions div = new Divisions { Div_Name = this.txtNewDivName.Text };

            if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (db.Divisions.Where(n => n.Div_Name == div.Div_Name).Count() != 0)
                {
                    MessageBox.Show("項目名稱已存在，請重新輸入!!!");
                }
                else
                {
                    var q = (from f in db.Divisions
                             where f.Div_Name == this.lblOldDivName.Text
                             select f).First();

                    q.Div_Name = this.txtNewDivName.Text;

                    db.SubmitChanges();

                    ClsRecord.Record(sender, this.Name);

                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後更新資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
