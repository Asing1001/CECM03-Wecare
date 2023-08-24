<%@ WebHandler Language="C#" Class="HandlerGetSingleExamCal" %>

using System;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using WebCareWeb.App_Code;
using System.Configuration;
using System.Data.SqlClient;

public class HandlerGetSingleExamCal : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
        ClsExamCalender eCal = null;
        ClsDrugCalendar dCal = null;
        string id = "", type = "";
        
        if (context.Request.QueryString["id"] != null && context.Request.QueryString["type"] != null)
        {
            id = context.Request.QueryString["id"];
            type = context.Request.QueryString["type"];

            if (type == "exam")
            {
                eCal = new ClsExamCalender(Convert.ToInt32(id));

                context.Response.ContentType = "application/json";
                context.Response.Write(JsonConvert.SerializeObject(eCal.GetObject()));
            }
            else
            {
                dCal = new ClsDrugCalendar(Convert.ToInt32(id));
                
                context.Response.ContentType = "application/json";
                context.Response.Write(JsonConvert.SerializeObject(dCal.GetObject()));
            }
        }

        //string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        //using (SqlConnection conn = new SqlConnection(strConn))
        //{
        //    string strCmd = 
        //        eCal != null ? "select * from View_ExamCalendar where ID = @id" : "select * from View_DrugCalendar where ID = @id";
        //    using (SqlDataAdapter da = new SqlDataAdapter(strCmd, conn))
        //    {
        //        using (DataSet ds = new DataSet())
        //        {
        //            da.Fill(ds);
                    
        //            context.Response.ContentType = "application/json";
        //            context.Response.Write(JsonConvert.SerializeObject(ds));
        //        }
                
        //        conn.Close();
        //    }
        //}
    }
 
    public bool IsReusable 
    {
        get {
            return false;
        }
    }

}