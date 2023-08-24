<%@ WebHandler Language="C#" Class="HandlerDrPix" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

public class HandlerDrPix : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
       
        
        string StaffID = "1";
        if (context.Request.QueryString["Staff_ID"] != null)
        {
            StaffID = context.Request.QueryString["Staff_ID"];
        }

        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmd = "select Staff_Pix from Staffs where Staff_ID=@Staff_ID";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                cmd.Parameters.AddWithValue("@Staff_ID", StaffID);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    context.Response.ContentType = "image/gif";
                    context.Response.BinaryWrite((Byte[])dr[0]);
                }
                conn.Close();

            }
        }
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}