using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;
using MyDB;

namespace MyProgram
{
    public partial class FrmDivAdd : FrmBaseModify
    {
        public FrmDivAdd()
        {
            InitializeComponent();

            this.label3.Text = Divname;
        }
       
        internal string Divname;

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Divisions div = new Divisions { Div_Name = this.textBox1.Text };

            if (MessageBox.Show("確定要新增嗎?", "新增確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Divisions.InsertOnSubmit(div);
                db.SubmitChanges();

                ClsRecord.Record(sender, this.Name);

                this.Close();
            }
        }

        private void FrmDivAdd_Load(object sender, EventArgs e)
        {
            this.label3.Text = Divname;
        }
    }
}
