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
    public partial class FrmExamCategAdd : FrmBaseModify
    {
        public FrmExamCategAdd()
        {
            InitializeComponent();
        }

        internal string Divname;

        private void FrmExamCategAdd_Load(object sender, EventArgs e)
        {
            this.label3.Text = Divname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後更新資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            ExamCategories div = new ExamCategories { ExamCat_Name = this.textBox1.Text };

            if (this.label3.Text == "")
            {
                if (MessageBox.Show("確定要新增嗎?", "新增確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ExamCategories.InsertOnSubmit(div);
                }
            }
            else
            {
                if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var q = (from f in db.ExamCategories
                         where f.ExamCat_Name == this.label3.Text
                         select f).First();

                    q.ExamCat_Name = this.textBox1.Text;
                }
            }

            db.SubmitChanges();

            this.Close();
        }
    }
}
