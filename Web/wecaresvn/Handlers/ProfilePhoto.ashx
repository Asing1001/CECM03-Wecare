<%@ WebHandler Language="C#" Class="ProfilePhoto" %>

using System;
using System.Web;
using System.Linq;

public class ProfilePhoto : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //context.Response.Cookies["Job"].Value = "1234";
        MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        if (context.Request.Cookies["Job"]!=null)
        {
            string StaffAccount ="aaa";
            if (context.Request.Cookies["login"]!=null)
            {
                StaffAccount = context.Request.Cookies["login"].Value;
            }    
          
            var q = db.Staffs.Where(n => n.Staff_Acc == StaffAccount).Single().Staff_Pix;
            byte[] buff = q.ToArray();           
            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(buff);
        }
        else if (context.Request.Cookies["PttID"]!=null)
        {
            int PatientID =Convert.ToInt32(context.Request.Cookies["PttID"].Value);
            var q = db.Patients.Where(n => n.Ptt_ID == PatientID).Single().Ptt_Pix;
            byte[] buff = q.ToArray();
            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(buff);
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}