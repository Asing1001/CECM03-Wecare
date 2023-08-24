using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    public class Register
    {  
        public static int RegisterPatient(int patientID, int docID, int OPIID=1)
        {
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            DB.RegisterInformations.InsertOnSubmit(
                new MyDB.RegisterInformation
                {                     
                    Ptt_ID = patientID,
                    Staff_ID = docID,
                    OPI_ID = OPIID
                });
            DB.SubmitChanges();

            return DB.RegisterInformations.Max(n => n.RegInfo_ID);
        }
    }

    public class Patient
    {
        public string Ptt_Name { get; set; }
        public int Ptt_ID { get; set; }
        public int Ptt_Num { get; set; }

        public static List<Patient> GetPatient()
        {
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

            List<Patient> list = new List<Patient>();

            var q = from p in DB.Patients
                    select new { p.Ptt_ID, p.Ptt_Name, p.Ptt_Num };

            foreach (var i in q)
            {
                list.Add(new Patient { Ptt_ID = i.Ptt_ID, Ptt_Name = i.Ptt_Name, Ptt_Num = (int)i.Ptt_Num });
            }
            return list;
        }
    }

    public class frequency
    {
        public int fID { get; set; }
        public string fName { get; set; }
        public int fDay { get; set; }

        public static List<frequency> GetFrequency()
        {
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            List<frequency> list = new List<frequency>();
            var q = from p in DB.ExamFrequencies
                    select p;

            foreach (var i in q)
            {
                list.Add(new frequency { fID = i.ExamFreq_ID, fName = i.ExamFreq_EFC, fDay = i.ExamFreq_Days });
            }
            return list;
        }
    }

    public class Exam
    {
        public int eID { get; set; }
        public string eName { get; set; }

        public static List<Exam> GetExam()
        {
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            List<Exam> list = new List<Exam>();
            var q = from p in DB.ExamOverview
                    select p;

            foreach (var i in q)
            {
                list.Add(new Exam { eID = i.Exam_ID, eName = i.Exam_NameCH });
            }
            return list;
        }
    }

    public class ClsExamSchedule
    {
        public static List<MyDB.View_ExamSchedule> getSchedule()
        {
            global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            var q2 = from p in DB.View_ExamSchedules
                     select p;

            return q2.ToList();
        }

        public static int id;
        public static string buttonName;

    }

    public class DiagPatient
    {
        public int Diag_ID { get; set; }
        public string Ptt_Name  { get; set; }
        public int Ptt_Num { get; set; }
    }
}
