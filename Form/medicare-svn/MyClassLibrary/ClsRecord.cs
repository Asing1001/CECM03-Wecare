using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public static class ClsRecord
    {
        public static clsUser CurrentUser;
        public static int StaffID=1;
        public static void Record(object sender, string formName)
        {
            string ButtonText;
            if(sender is Button)
            { ButtonText=((Button)sender).Text;}
            else
            { ButtonText = ((ToolStripItem)sender).Text; }
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            int formID = DB.Forms.Where(n => n.Frm_NameEN == formName).First().Frm_ID;
            MyDB.UseRecords ur = new MyDB.UseRecords { Rec_UT = DateTime.Now, Rec_Use = ButtonText, Ptt_ID = null, Staff_ID = StaffID, Frm_ID = formID };
            DB.UseRecords.InsertOnSubmit(ur);
            DB.SubmitChanges();
        }

        public static void Record(object sender, string formName, int PatientID)
        {
            string ButtonText;
            if (sender is Button)
            { ButtonText = ((Button)sender).Text; }
            else
            { ButtonText = ((ToolStripItem)sender).Text; }
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            int formID = DB.Forms.Where(n => n.Frm_NameEN == formName).First().Frm_ID;
            MyDB.UseRecords ur = new MyDB.UseRecords { Rec_UT = DateTime.Now, Rec_Use = ButtonText, Ptt_ID = PatientID, Staff_ID = StaffID, Frm_ID = formID };
            DB.UseRecords.InsertOnSubmit(ur);
            DB.SubmitChanges();
        }
    }
}
