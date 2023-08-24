<%@ WebHandler Language="C#" Class="HadExamStatic" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Newtonsoft.Json;

public class HadExamStatic : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {

        string strconn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strconn))
        {
            string strcmd = "SELECT ExamCategories.ExamCat_Name, COUNT(ExamCalendar.ExamCal_ID) AS CountExam FROM ExamCalendar INNER JOIN ExamSchedules ON ExamCalendar.ExamSch_ID = ExamSchedules.ExamSch_ID INNER JOIN ExamOverview ON ExamSchedules.Exam_ID = ExamOverview.Exam_ID INNER JOIN ExamCategories ON ExamOverview.ExamCat_ID = ExamCategories.ExamCat_ID GROUP BY ExamCategories.ExamCat_Name";
            using (SqlDataAdapter da=new SqlDataAdapter(strcmd,conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                context.Response.ContentType = "application/json";
                context.Response.Write(JsonConvert.SerializeObject(ds));
            }
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}