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
    public partial class FrmJBTEdit : FrmBaseModify
    {
        public string Divname;
        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        public FrmJBTEdit()
        {
            InitializeComponent();
        }

        private void FrmJBTEdit_Load(object sender, EventArgs e)
        {
            this.lblOldJobTitle.Text = Divname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?取消後編輯資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後將無法復原!!", "更新資料",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                JobTitles div = new JobTitles { Job_Title = this.txtNewJobTitle.Text };

                if (db.JobTitles.Where(n => n.Job_Title == this.txtNewJobTitle.Text).Count() != 0)
                {
                    MessageBox.Show("已有相同項目存在，請確認");

                    this.txtNewJobTitle.Focus();
                    this.txtNewJobTitle.SelectAll();
                }
                else
                {
                    var q = (from f in db.JobTitles
                             where f.Job_Title == this.lblOldJobTitle.Text
                             select f).First();

                    q.Job_Title = this.txtNewJobTitle.Text;

                    db.SubmitChanges();

                    ClsRecord.Record(sender, this.Name);

                    this.Close();
                }
            }
        }
    }
}
