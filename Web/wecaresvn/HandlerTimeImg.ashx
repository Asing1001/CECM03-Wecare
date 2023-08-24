<%@ WebHandler Language="C#" Class="HandlerTimeImg" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

public class HandlerTimeImg : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        string timelineID = "1";
        if (context.Request.QueryString["timelineID"] != null)
        {
            timelineID = context.Request.QueryString["timelineID"];
        }

        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmd = "select TimeLine_Bytes from TimeLines where TimeLine_ID=@TimeLine_ID";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                cmd.Parameters.AddWithValue("@TimeLine_ID", timelineID);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr[0] != DBNull.Value)
                    {
                        context.Response.ContentType = "image/jpg";
                        context.Response.BinaryWrite((Byte[])dr[0]);
                    }

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