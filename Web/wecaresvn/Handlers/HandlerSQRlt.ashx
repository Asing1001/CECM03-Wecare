<%@ WebHandler Language="C#" Class="HandlerSQRlt" %>

using System;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

public class HandlerSQRlt : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        
       int EvaId =Convert.ToInt32(context.Request.QueryString["Eva_Id"]);
       string EvaRlt = context.Request.QueryString["Eva_Rlt"];
       using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
       {
           SqlCommand cmd = new SqlCommand("Update Evaluation set Eva_Rlt=@EvaRlt where Eva_Id=@EvaId", conn);
           cmd.Parameters.AddWithValue("@EvaId", EvaId);
           cmd.Parameters.AddWithValue("@EvaRlt", EvaRlt);
           
           conn.Open();
           cmd.ExecuteNonQuery();
           conn.Close();
       }
               
       // context.Response.ContentType = "text/plain";
       
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}