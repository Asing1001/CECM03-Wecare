<%@ WebHandler Language="C#" Class="HealthPic" %>

using System;
using System.Web;

public class HealthPic : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        string HealID = "1";
        HealID = context.Request.QueryString["Health_ID"];
        
        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(strConn))
        {
            string strCmd = "select Health_img from HealthKnowledge where Health_ID=@Health_ID";
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(strCmd, conn))
            {
                cmd.Parameters.AddWithValue("@Health_ID", HealID);
                conn.Open();
                System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr[0] != DBNull.Value)
                    {
                        context.Response.ContentType = "image/jpg";
                        context.Response.BinaryWrite((Byte[])dr[0]);
                    }
                    conn.Close();
                }

            }
        }    
    }
 
    
    
    
    
    
    
    
    
    
    public bool IsReusable {
        get {
            return false;
        }
    }

}