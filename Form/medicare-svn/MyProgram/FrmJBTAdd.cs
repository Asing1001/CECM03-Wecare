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
    public partial class FrmJBTAdd : FrmBaseModify
    {
        public FrmJBTAdd()
        {
            InitializeComponent();
        }

        internal string Divname;

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void FrmJBTAdd_Load(object sender, EventArgs e)
        {
            this.label3.Text = Divname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要新增嗎?", "新增確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                JobTitles div = new JobTitles { Job_Title = this.textBox1.Text };
                int m = db.JobTitles.Where(n => n.Job_Title == this.textBox1.Text).Count();

                if (m != 0)
                {
                    MessageBox.Show("已有相同項目存在，請確認");
                    this.textBox1.Focus();
                    this.textBox1.SelectAll();
                }
                else
                {
                    db.JobTitles.InsertOnSubmit(div);
                    db.SubmitChanges();
                    MessageBox.Show("資料新增成功");
                    this.Close();
                }
            }
        }
    }
}
