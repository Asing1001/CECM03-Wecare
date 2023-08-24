using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsStatus
    {
        public int sID { get; set; }
        public string sName { get; set; }

        public static IList<clsStatus> GetStatus()
        {
            List<clsStatus> list = new List<clsStatus>();

            using (MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext())
            {
                var q = from p in db.Situations
                        select p;

                foreach (var each in q)
                {
                    list.Add(new clsStatus { sID = each.Status_ID, sName = each.Status_Name });
                }
            }
            return list;
        }
    }
}
