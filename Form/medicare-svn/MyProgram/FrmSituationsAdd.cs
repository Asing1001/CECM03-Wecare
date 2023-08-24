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
    public partial class FrmSituationsAdd : FrmBaseModify
    {
        public FrmSituationsAdd()
        {
            InitializeComponent();
        }

        private void FrmSituationsAdd_Load(object sender, EventArgs e)
        {
            this.label3.Text = Divname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.label3.Text == "")
            {
                if (MessageBox.Show("確定要取消嗎?\n取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("確定要取消嗎?\n取消後修改資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        internal string Divname;

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            Situations div = new Situations {  Status_Name = this.textBox1.Text };

            string s1 = this.label3.Text == "" ? "確定要新增嗎?" : "確定要更新資料嗎?\n更新後舊有資料將無法復原!!";
            string s2 = this.label3.Text == "" ? "新增確認" : "更新確認";

            if (db.Situations.Where(n => n.Status_Name == this.textBox1.Text).Count() == 0)
            {
                if (this.label3.Text == "")
                {
                    if (MessageBox.Show(s1, s2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Situations.InsertOnSubmit(div);
                    }
                }
                else
                {
                    if (MessageBox.Show(s1, s2, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var q = (from f in db.Situations
                                 where f.Status_Name == this.label3.Text
                                 select f).First();
                        q.Status_Name = this.textBox1.Text;
                    }
                }

                db.SubmitChanges();

                this.Close();
            }
            else
            {
                MessageBox.Show("已有相同項目存在，請確認");
            }
        }
    }
}
