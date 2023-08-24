using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDB;

namespace MyClassLibrary
{
    public class ClsExamCalender:IMedicare
    {
        MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
        
        public BindingSource GetData(DateTime d)
        {
            BindingSource bs = new BindingSource();
            //搜尋 1.當日  2.檢驗快到該提醒但未提醒  3.昨天應到卻未到   的病患
            bs.DataSource = DB.View_ExamCalendars.Where
                (n => n.檢驗日期 == d.Date ||   //當日
                (n.檢驗日期.Date <= d.Date.AddDays(n.提早天數) && n.檢驗日期 >= d && n.已提醒 == false) || //未提醒
                (n.檢驗日期 == d.AddDays(-1) && n.狀態 == "未完成")).OrderBy(n => n.檢驗日期).ToList();  //昨日應到
            return bs;
        }

        public BindingSource GetData()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DB.View_ExamCalendars.Where
                (n => n.檢驗日期 == DateTime.Today ||
                (n.檢驗日期.Date <= DateTime.Today.Date.AddDays(n.提早天數) && n.檢驗日期.Date >= DateTime.Today && n.已提醒 == false) ||
                (n.檢驗日期 == DateTime.Today.AddDays(-1) && n.狀態 == "未完成")).ToList();
            return bs;
        }

        public BindingSource Search(string SearchBy, string InputString)
        {
            BindingSource bs = new BindingSource();
            if (SearchBy == "病患姓名")
            {
                var q = from p in DB.View_ExamCalendars
                        where p.病患名稱.Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
            else
            {
                var q = from p in DB.View_ExamCalendars
                        where p.病歷號碼.ToString().Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
        }
    }

    public class ClsDrugCalendar
    {
        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        public int DrugCal_ID { get; set; }
        public int DrugSch_ID { get; set; }
        public int RmdDay_ID { get; set; }
        public int Status_ID { get; set; }
        public DateTime DrugCal_SD { get; set; }
        public string DrugCal_Rem { get; set; }
        public bool DrugCal_Rmd { get; set; }
        public int Staff_ID { get; set; }
        public int Ptt_ID { get; set; }
        public string Ptt_Name { get; set; }
        public int Drug_ID { get; set; }
        public string Drug_NameEN { get; set; }
        public string Drug_NameCH { get; set; }

        public ClsDrugCalendar()
        { 

        }

        public ClsDrugCalendar(int id)
        {
            var q = DB.DrugCalendar.Where(n => n.DrugCal_ID == id).First();

            DrugCal_ID = q.DrugCal_ID;
            DrugSch_ID = q.DrugSch_ID;
            RmdDay_ID = q.RmdDay_ID;
            Status_ID = q.Status_ID;
            DrugCal_SD = q.DrugCal_SD;
            DrugCal_Rem = q.DrugCal_Rem;
            DrugCal_Rmd = q.DrugCal_Rmd;
            Staff_ID = DB.View_DrugCalendars.Where(n => n.ID == id).First().Staff_ID;
            int pttNum = DB.View_DrugCalendars.Where(n => n.ID == id).Single().病歷號碼;
            Ptt_ID = DB.Patients.Where(n => n.Ptt_Num == pttNum).Single().Ptt_ID;
            Ptt_Name = DB.Patients.Where(n => n.Ptt_ID == Ptt_ID).Single().Ptt_Name;
            Drug_ID = DB.View_DrugCalendars.Where(n => n.ID == id).First().Drug_ID.Value;
            Drug_NameCH = DB.DrugOverview.Where(n => n.Drug_ID == Drug_ID).First().Drug_NameCH.ToString();
            Drug_NameEN = DB.DrugOverview.Where(n => n.Drug_ID == Drug_ID).First().Drug_NameEN.ToString();
        }

        public BindingSource GetData(DateTime d)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DB.View_DrugCalendars.Where
                (n => n.用藥日期 == d ||
                (n.用藥日期.Date <= d.Date.AddDays(n.幾天前提醒) && n.用藥日期 >= d && n.已提醒 == false) ||
                (n.用藥日期 == d.AddDays(-1) && n.狀態 != "完成")).OrderBy(n => n.用藥日期).ToList();
            return bs;
        }

        public BindingSource Search(string SearchBy, string InputString)
        {
            BindingSource bs = new BindingSource();
            if (SearchBy == "病患姓名")
            {
                var q = from p in DB.View_DrugCalendars
                        where p.病患姓名.Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
            else
            {
                var q = from p in DB.View_DrugCalendars
                        where p.病歷號碼.ToString().Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
        }

        public void Updata()
        {
            var q = DB.DrugCalendar.Where(n => n.DrugCal_ID == this.DrugCal_ID).First();

            q.DrugCal_Rem = DrugCal_Rem;
            q.DrugCal_Rmd = DrugCal_Rmd;

            DB.SubmitChanges();
        }
    }
}
