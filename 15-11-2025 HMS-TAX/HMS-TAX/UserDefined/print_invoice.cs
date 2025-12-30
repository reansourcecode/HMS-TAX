using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_TAX.UserDefined
{
    internal class print_invoice
    {
        sqlexcute sql = new sqlexcute();

        public void PrintExcelFile(string vStatus, string vCode , string vType)
        {

            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                            vStatus,
                            variables.PBranchCode,
                            vCode
                        };
                dt = sql.proc_getdata("proc_print_invoices", p);


                if (dt.Rows.Count > 12)
                {
                    MessageBox.Show("system doesn't allow print over records sheets in excel (12) ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dt.Rows.Count > 0)
                {
                    string vReportPath = Application.StartupPath + @"\Reports\rcp\rcp_tax_ti.xlsx";
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    // Open the Workbook:
                    if (vType == "1")
                    {
                        vReportPath = Application.StartupPath + @"\Reports\rcp\rcp_tax_ci.xlsx";
                    }

                    Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(vReportPath,
                        false, true, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                    Int16 vRowStart = 13;
                    Microsoft.Office.Interop.Excel.Range line = (Microsoft.Office.Interop.Excel.Range)ws.Rows[12];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ws.Cells[vRowStart + i, "A"] = (i + 1).ToString();
                        ws.Cells[vRowStart + i, "B"] = dt.Rows[i]["pro_name"].ToString();
                        ws.Cells[vRowStart + i, "C"] = dt.Rows[i]["expired"].ToString();
                        ws.Cells[vRowStart + i, "D"] = dt.Rows[i]["packing"].ToString();
                        ws.Cells[vRowStart + i, "E"] = dt.Rows[i]["qty"].ToString();
                        ws.Cells[vRowStart + i, "F"] = string.Format("{0:0,0}", dt.Rows[i]["unitprice"]);
                        ws.Cells[vRowStart + i, "G"] = string.Format("{0:0}", dt.Rows[i]["discount"]) + "%";
                        ws.Cells[vRowStart + i, "H"] = string.Format("{0:0,0}", dt.Rows[i]["sub_amount"]);
                    }


                    if (dt.Rows.Count > 0)
                    {

                        ws.Cells[7, "B"] = dt.Rows[0]["cus_name"].ToString();
                        ws.Cells[9, "B"] = dt.Rows[0]["address"].ToString();

                        ws.Cells[7, "F"] = "Invoice No: " + dt.Rows[0]["rcp_num"].ToString();
                        ws.Cells[9, "F"] = "Date: " + dt.Rows[0]["printdate"].ToString();

                        ws.Cells[9, "H"] = dt.Rows[0]["phone"].ToString();


                        if (vType == "0")
                        {
                            ws.Cells[28, "G"] = dt.Rows[0]["exchangrate"].ToString();
                        }
                        else if (vType == "1")
                        {
                            ws.Cells[26, "G"] = dt.Rows[0]["exchangrate"].ToString();
                        }
                    }

                    excelApp.Visible = true;
                    ws.PrintOut(
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //// Cleanup:
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //wb.Close(false, Type.Missing, Type.Missing);
                    //excelApp.Quit();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
