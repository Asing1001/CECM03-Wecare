using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace MyClassLibrary
{
    public class Class1
    {
        
        public static void ExportDataGridview(DataGridView gridView, bool isShowExcle)
        {
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
                        if (gridView[j, i].ValueType == typeof(string) && gridView[j, i].ColumnIndex == 5)
                        {
                            excel.Cells[i + 2, j + 1] = "'" + gridView[j, i].Value.ToString();
                        }
                        else
                        {
                            if (gridView[j, i].ColumnIndex == 4)
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
            //return true;
        }
        //public static int countfail;
        public  static bool m=true;
        public static bool checklemport(DataGridViewCell x,ref int countfail)
        {
            
            if (x.Value == null)
            { return m = true; } //空白行

            if (x.Value.ToString().Trim() != "" && x.Value.ToString().Trim().Length == 10)
            {
                String pId = x.Value.ToString();
                using (SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Medicare;Integrated Security=True"))
                {
                    ;
                    string strCompare = "Select 身分證字號 from Patients";
                    using (SqlCommand cmd = new SqlCommand(strCompare, Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        Conn.Open();

                        SqlDataReader acdr = cmd.ExecuteReader();
                        while (acdr.Read())
                        {

                            String s = acdr["身分證字號"].ToString();
                            if (s == pId)
                            {
                                m = false;
                                countfail++;
                                break;
                            }
                        }
                    }
                }
            }
            else 
            {
                countfail++;
                return m=false; 
            }
            return m;
        }
        public static List<String> getSheets(string FileName)
        {

            List<String> sheetNameList = new List<String>();

            OleDbConnection excelDatabase
            = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + FileName + "; Extended Properties = 'Excel 8.0;HDR=YES'"); //連線
            excelDatabase.Open();
            DataRow[] sheetList = excelDatabase.GetSchema("Tables").Select();

            foreach (DataRow sheet in sheetList)
            {
                // query each sheet name from excel file
                sheetNameList.Add(sheet["TABLE_NAME"] as string);
            }
            // close and release database connection
            excelDatabase.Close();
            return sheetNameList;
        }

    }
}
