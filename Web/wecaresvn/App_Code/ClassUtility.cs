using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// ClassUtility 的摘要描述
/// </summary>
public class ClassUtility
{
	public ClassUtility()
	{
		//
		// TODO: 在這裡新增建構函式邏輯
		//

	}
    public static string getJobTitles(int JobID)
    {
        string strName = "";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("select Job_Title from JobTitles where Job_ID=@JobID", conn);
            cmd.Parameters.AddWithValue("@JobID", JobID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                strName = dr[0].ToString();
            }
            conn.Close();
        }
        return strName;
    }
    public static string getDivTitles(int DivID)
    {
        string strName = "";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("select Div_Name from Divisions where Div_ID=@DivID", conn);
            cmd.Parameters.AddWithValue("@DivID", DivID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                strName = dr[0].ToString();
            }
            conn.Close();
        }
        return strName;
    }
    public static string getStringbr(object Feild)
    {
       var M = "";
       if (Feild is DBNull)
       {
           return "";
       }
       else
       {
           string[] x = Feild.ToString().Split(',');

           foreach (string temp in x)
           {
               M += temp + "<br/>";
           }
           return M;
       }
           
           
            
            
       
      
    }
    public static double getStaffEvalution(int StaffID)
    {
        Double x = 1.0;
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("select round(AVG(cast(Eva_Sco as float)),2) from Evaluation Group by Staff_ID Having Staff_ID=@StaffID", conn);
            cmd.Parameters.AddWithValue("@StaffID", StaffID);
            conn.Open();
            if (cmd.ExecuteScalar() is DBNull)
            { return 0; }
            else
            { 
              x= Convert.ToDouble(cmd.ExecuteScalar());
            }
            conn.Close();
        }
        return x;
    }
    static object sc ;
    public static string getEvaSco(int EvaID)
    {
      
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
        {

            SqlCommand cmd = new SqlCommand("select Eva_Sco from Evaluation where Eva_ID=@Eva_ID", conn);
            cmd.Parameters.AddWithValue("@Eva_ID", EvaID);
            conn.Open();

           sc= cmd.ExecuteScalar();
            if (sc is DBNull)
            {
                return "評分";
            }
            else
            {
               
                conn.Close();
                return Convert.ToString(sc);
            }
            
            
        }
        
    }
    public static bool Readonly(object score)
    {
        if (score is DBNull)
        { return true; }
        else
        {
            return false;
        }
        
    }
        
}