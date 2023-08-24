<%@ WebHandler Language="C#" Class="UploadFiles" %>

using System;
using System.Web;
using System.Linq;

public class UploadFiles : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //接file  轉成 byte[]       
        string file = context.Request.Form["files"];    //#@$@DAS前面一堆怪字         


        byte[] fileData = null;        
        
        //第一種Base64轉byte
        file = file.Split(',')[1]; //分割Base64string的頭  可行但不好用
        fileData = Convert.FromBase64String(file); //轉成byte[]

        //第二種Base64轉byte  很好用!!        
        //fileData= System.Text.Encoding.ASCII.GetBytes(file);
        
        //存入資料庫
        int pid =1;
        if (context.Request.Cookies["PttID"] != null)
            {
                pid =Convert.ToInt32( context.Request.Cookies["PttID"].Value);
            }
        MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        db.Patients.Where(n => n.Ptt_ID == pid).Single().Ptt_Pix = fileData;
        
        db.SubmitChanges();        
        
        context.Response.ContentType = "text/plain";
        context.Response.Write("上傳成功!!");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}