<%@ WebHandler Language="C#" Class="HadExamUnusual" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Newtonsoft.Json;

public class HadExamUnusual : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        string strconn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strconn))
        {
            string strcmd = //"SELECT ExamOverview.Exam_NameCH,Count(ExamCalendar.ExamCal_ID) AS CountExam, Patients.Ptt_Sex FROM ExamOverview join ExamSchedules on ExamSchedules.Exam_ID=ExamOverview.Exam_ID join ExamCalendar on ExamCalendar.ExamSch_ID=ExamSchedules.ExamSch_ID INNER JOIN ExamCategories ON ExamOverview.ExamCat_ID = ExamCategories.ExamCat_ID INNER JOIN Diagnosis ON ExamSchedules.Diag_ID = Diagnosis.Diag_ID INNER JOIN RegisterInformation ON Diagnosis.RegInfo_ID = RegisterInformation.RegInfo_ID INNER JOIN Patients ON RegisterInformation.Ptt_ID = Patients.Ptt_ID where ExamCalendar.ExamSch_Rlt < > '尚未檢測' and ( (ExamCalendar.ExamSch_Rlt ) < ( ExamOverview.Exam_LowLim ) or (ExamCalendar.ExamSch_Rlt ) > ( ExamOverview.Exam_UpLim )) Group by ExamOverview.Exam_NameCH, Patients.Ptt_Sex";
                "SELECT ExamOverview.Exam_NameCH,Count(ExamCalendar.ExamCal_ID) AS CountExam, Patients.Ptt_Sex FROM ExamOverview join ExamSchedules on ExamSchedules.Exam_ID=ExamOverview.Exam_ID join ExamCalendar on ExamCalendar.ExamSch_ID=ExamSchedules.ExamSch_ID INNER JOIN ExamCategories ON ExamOverview.ExamCat_ID = ExamCategories.ExamCat_ID INNER JOIN Diagnosis ON ExamSchedules.Diag_ID = Diagnosis.Diag_ID  INNER JOIN RegisterInformation ON Diagnosis.RegInfo_ID = RegisterInformation.RegInfo_ID INNER JOIN Patients ON RegisterInformation.Ptt_ID = Patients.Ptt_ID  where ExamCalendar.ExamSch_Rlt < > '尚未檢測' and (cast (ExamCalendar.ExamSch_Rlt as decimal) < cast( ExamOverview.Exam_LowLim as decimal) or cast (ExamCalendar.ExamSch_Rlt as decimal) > cast( ExamOverview.Exam_UpLim as decimal)) Group by ExamOverview.Exam_NameCH, Patients.Ptt_Sex";
            using (SqlDataAdapter da = new SqlDataAdapter(strcmd, conn))
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