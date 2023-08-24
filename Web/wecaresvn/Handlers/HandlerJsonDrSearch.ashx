<%@ WebHandler Language="C#" Class="HandlerJsonDrSearch" %>

using System;
using System.Web;
using System.Linq;

public class HandlerJsonDrSearch : IHttpHandler 
{
    
    public void ProcessRequest (HttpContext context) 
    {
        
        //keyword = context.Request.QueryString["term"];
        MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        var q = from names in db.Staffs
                orderby names.Staff_Name
                select names.Staff_Name;

        context.Response.ContentType = "application/json";
        //context.Response.Write(string.Join(Environment.NewLine, q.ToArray()));
        
        context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(q));   //XML ->ds.GetXml()
       
    }
 
    
    public bool IsReusable 
    {
        get
        {
            return false;
        }
    }

}