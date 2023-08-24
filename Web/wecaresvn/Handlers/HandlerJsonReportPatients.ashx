<%@ WebHandler Language="C#" Class="HandlerJsonReportPatients" %>

using System;
using System.Web;
using System.Linq;

public class HandlerJsonReportPatients : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {

        var pName = HttpUtility.UrlDecode(context.Request.Cookies["login"].Value);
        string pExam = context.Request.QueryString["pexam"].ToString();

        int x = 1;
        if (context.Request.QueryString["Page"] != null)
        {
            x = Convert.ToInt32(context.Request.QueryString["Page"]);
        }
        //string pDate = context.Request.QueryString["pdate"].ToString();

        //pName = "楊搏試";
        MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        //var q = from v in db.View_ExamCalendars
        //        where v.病患名稱 == pName && v.結果值 != "尚未檢測" && v.檢驗項目==pExam 
        //        orderby v.檢驗日期 ascending
        //        select new { v.結果值, v.檢驗項目, v.檢驗日期 };
        
        var t=db.View_ExamCalendars.Where(n=>n.病患名稱==pName && n.結果值 != "尚未檢測" && n.檢驗項目==pExam ).OrderBy(n=>n.檢驗日期).Skip((x-1)*5).Take(5).Select(n=> new{n.結果值 , n.檢驗項目 , n.檢驗日期});

        context.Response.ContentType = "application/json";
        context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(t));   
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}