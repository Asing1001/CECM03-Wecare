using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommonHealth : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        string typeList = "";
        string conList = "";
       string txtList = "";
        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string typestr = "";

            string strCmd = "select * from  HealthKnowledge ";
            //string strCmd = "select * from  HealthKnowledge Where " + Newstype + " LIKE '%" + strC1 + "%'";
            //string strCmd = "select * from  HealthKnowledge Where Health_Type LIKE '%糖尿病%'";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    if (dr["Health_Type"].ToString() != typestr)
                    {
                        if (typestr != "")
                        {
                            
                            txtList += "</div></div>";
                            conList += "<hr/></div>";

                        }
                        typeList += "<div class='showKnowledgeType' id='s" + dr["Health_ID"] + "' onclick='TypeClick(" + dr["Health_ID"] + ")' ><br/><h5>" + dr["Health_Type"] + "</h5></div>";
                        txtList += "<div class='showKnowledge' ><br/><h1 Class='HType'>" + dr["Health_Type"] + "</h1><hr style='width:400px;Margin:0 auto' /><div id='dtitle'>";
                        conList += "<div class='showKnowledgeDetail' id='" + dr["Health_ID"] + "' ><h1 >" + dr["Health_Type"] + "</h1>";   
                        typestr = dr["Health_Type"].ToString();
                    }
                 
                    
                    //文字空白時換行
                    string strOld = dr["Health_Cont"].ToString();
                    string strNew = strOld.Replace("\r\n", "<br />");

                    txtList += "<h2 Class='HTitle'><li>" + dr["Health_Title"] + "</li></h2>";
                   
                    if (dr["Health_img"] != DBNull.Value)
                    {
                        conList += "<div style='width:940px;margin:0 auto' ><h2>" + dr["Health_Title"] + "</h2>" + "<div style='width: 400px;margin:0 auto;height:auto; display: none;word-break:break-all;'><img style='height:100px;width:100px' src='Handlers/HealthPic.ashx?Health_ID=" + dr["Health_ID"] + "' /><div style='float:right;width:650px;text-align:left;'>" + strNew + "<br/><br/></div></div></div>";
                    }
                    else
                    {
                        conList += "<div style='width:940px;margin:0 auto'><h2>" + dr["Health_Title"] + "</h2>" + "<div style='height:auto;width: 500px; display: none;word-break:break-all;text-align:left'>" + strNew + "<br/><br/></div></div>";
                    }
                    
                }

                txtList += "</div></div>";
                conList += "<hr/></div><br/><br/><br/><br/><br/><br/></div>";


                conn.Close();


            }
        }
               this.Literal1.Text=  txtList+"</div>";
               this.Literal2.Text = conList + "</div>";
               this.Literal3.Text = typeList;
    }
}