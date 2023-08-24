using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyClassLibrary
{
    public class clsPatient
    {
        public static void ExportDataGridview(DataGridView gridView, bool isShowExcle)
        {
            //if (gridView.Rows.Count == 0)
            //    return false;                //不執行

            //建立Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);  //加入活頁簿
            excel.Visible = isShowExcle;
            //產生欄位名
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
            }
            //填入數據
            for (int i = 0; i < gridView.RowCount; i++)
            {
                for (int j = 0; j < gridView.ColumnCount; j++)
                {
                    try
                    {
                        if (gridView[j, i].ValueType == typeof(string) && gridView[j, i].ColumnIndex==5)
                        {
                            excel.Cells[i + 2, j + 1] = "'" + gridView[j, i].Value.ToString();
                        }
                        else
                        {
                            if (gridView[j, i].ColumnIndex==4)
                            {
                                excel.Cells[i + 2, j + 1] = ((DateTime)gridView[j, i].Value).ToShortDateString();

                            }
                            else
                            {
                                excel.Cells[i + 2, j + 1] = gridView[j, i].Value.ToString();
                            }
                        }
                    }
                    catch (Exception)
                    { }
                }                
            }
        }

        public static bool checkimport(DataGridViewCell x) //import 倒入前判斷
        {
            bool m = true;
            if (x.Value == null) //因Excel倒入時,無法排除空白行,他會是null
            {
                return m = true; 
            }
           
            if (x.Value.ToString().Length==10)  //x傳入為 dataGridView1[1, i]    0姓名;1身分證 index來自Excel匯入的欄位
            {
                String pId = x.Value.ToString();
                using (SqlConnection Conn = new SqlConnection(Properties.Settings.Default.MedicareConnectionString))
                {
                    
                    string strCompare = "Select Ptt_PID from Patients";
                    using (SqlCommand cmd = new SqlCommand(strCompare, Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        Conn.Open();

                        SqlDataReader acdr = cmd.ExecuteReader();
                        while (acdr.Read())
                        {

                            String s = acdr["Ptt_PID"].ToString();
                            if (s == pId)
                            {
                                m = false;
                                break;
                            }

                        }
                    }
                }
            }
            else { m=false; }
            return m;
        }
        public static List<String> getSheets(string FileName)  //得到Excel 所有sheetName
        {

            List<String> sheetNameList = new List<String>();

             OleDbConnection excelDatabase
             //= new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + FileName + "; Extended Properties = 'Excel 8.0;HDR=YES;IMEX=1;ReadOnly=0'"); //連線
             = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + FileName + "; Extended Properties = 'Excel 12.0 Xml;HDR=YES'");

            excelDatabase.Open();
            DataRow[] sheetList = excelDatabase.GetSchema("Tables").Select();
            
            foreach (DataRow sheet in sheetList)
            {
                /// query each sheet name from excel file
                sheetNameList.Add(sheet["TABLE_NAME"] as string);
            }
            /// close and release database connection
            excelDatabase.Close();
            return sheetNameList;
        }

        
    }
}
