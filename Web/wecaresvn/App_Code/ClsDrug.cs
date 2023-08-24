using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCareWeb.App_Code
{
    public interface IMedicare
    {       
       BindingSource GetData();
       BindingSource Search(string a , string b);
    }


    public class ClsDrug:IMedicare
    {
        public static int editID; 
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public MediCareDataClassesDataContext DB = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        public virtual BindingSource GetData()
        {            
            BindingSource bs = new BindingSource();
            var q = from p in DB.View_DrugSchedules
                    select p;
             bs.DataSource = q.ToList();
             return bs;
        }

        public virtual BindingSource GetData(int ID)
        {         
            BindingSource bs = new BindingSource();
            var q = from p in DB.View_DrugSchedules
                    where p.ID==ID
                    select p;
            bs.DataSource = q.ToList();
            return bs;
        }

        public virtual void DeleteSchedule(int id)
        {
            if (MessageBox.Show("確定要刪除嗎?\n刪除後將無法復原!!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            == DialogResult.Yes)
            {       
                 
                var q = from p in DB.DrugSchedules
                        where p.DrugSch_ID == id
                        select p;
                DB.DrugSchedules.DeleteOnSubmit(q.FirstOrDefault());
                DB.SubmitChanges();                
            }
        }

        public BindingSource Search(string SearchBy, string InputString)
        {
            BindingSource bs = new BindingSource();
            if (SearchBy == "姓名")
            {
                var q = from p in DB.View_DrugSchedules
                        where p.姓名.Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
            else
            {
                var q = from p in DB.View_DrugSchedules
                        where p.病歷號碼.ToString().Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            } 
        }
    }
    public class TotalDrug : ClsDrug
    {
        public override BindingSource GetData()
        {            
            BindingSource bs = new BindingSource();
            var q = from p in DB.DrugOverview
                    select p;
            bs.DataSource = q.ToList();
            return bs;
        }
    }

    public class DrugFrequency : ClsDrug
    {
        public override BindingSource GetData()
        {            
            BindingSource bs = new BindingSource();
            var q = from p in DB.DrugFrequencies
                    select p;
            bs.DataSource = q.ToList();
            return bs;
        }
    }

    public class RemindDays : ClsDrug
    {
        public override BindingSource GetData()
        {
            BindingSource bs = new BindingSource();
            var q = from p in DB.RemindDays
                    select p;
            bs.DataSource = q.ToList();
            return bs;
        }
    }



}
