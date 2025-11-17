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

        public void PrintExcelFile(string vStatus, string vCode)
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

                if (dt.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    // Open the Workbook:
                    Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(Application.StartupPath + @"\Reports\RPT_PRINT.xlsx",
                        false, true, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                    Int16 vRowStart = 11;
                    Microsoft.Office.Interop.Excel.Range line = (Microsoft.Office.Interop.Excel.Range)ws.Rows[12];

                    Boolean vCH = false;
                    int vRowTotal = 14;
                    int vRowAdd = 14;


                    if (dt.Rows.Count > 3)
                    {
                        try
                        {
                            for (int i = 0; i < dt.Rows.Count - 2; i++)
                            {
                                line.Insert();

                                Microsoft.Office.Interop.Excel.Range sourceRange = ws.get_Range("A12:H12");
                                sourceRange.Copy();
                                Microsoft.Office.Interop.Excel.Range last = ws.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                                Microsoft.Office.Interop.Excel.Range destinationRange = ws.get_Range("A" + (vRowStart + i + 1) + ":H" + (vRowStart + i + 1));
                                destinationRange.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteFormats);
                                vRowAdd = i + 1;
                            }
                            vCH = true;
                            if (vCH == true)
                            {
                                vRowTotal = vRowTotal + vRowAdd;
                            }
                        }
                        catch { }
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ws.Cells[vRowStart + i, "B"] = (i + 1).ToString();
                        ws.Cells[vRowStart + i, "C"] = dt.Rows[i]["pro_name"].ToString();
                        ws.Cells[vRowStart + i, "E"] = dt.Rows[i]["qty"].ToString();
                        ws.Cells[vRowStart + i, "F"] = string.Format("{0:0,0}", dt.Rows[i]["unitprice"]);
                        ws.Cells[vRowStart + i, "G"] = string.Format("{0:0,0}", dt.Rows[i]["discount"]) + "%";
                        ws.Cells[vRowStart + i, "H"] = string.Format("{0:0,0}", dt.Rows[i]["sub_amount"]);
                    }


                    if (dt.Rows.Count > 0)
                    {

                        //ws.Cells[6, "B"] = dttotal.Rows[0]["Waiting"].ToString();
                        if (dt.Rows[0]["flag"].ToString() == "0")
                        {
                            ws.Cells[7, "B"] = "Cashier : " + dt.Rows[0]["inputter"].ToString();
                        }
                        else
                        {
                            ws.Cells[7, "B"] = "Cashier : " + dt.Rows[0]["inputter"].ToString() + " ( ត្រលប់ )";
                        }

                        ws.Cells[8, "B"] = "Invoice : " + dt.Rows[0]["rcp_num"].ToString();
                        ws.Cells[7, "E"] = "Patient" + dt.Rows[0]["cus_name"].ToString();


                        ws.Cells[8, "E"] = "Date :" + dt.Rows[0]["printdate"].ToString();

                        //ws.Cells[vRowTotal + 1, "D"] = "Sub Total(" + variables.p_bestcurrencysymbol + ")   :";
                        //ws.Cells[vRowTotal + 1, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_no_dis_amount"]);


                        //ws.Cells[vRowTotal + 2, "D"] = "Sub Total(" + variables.p_secondcurrencysymbol + ")   :";
                        //ws.Cells[vRowTotal + 2, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_ex_no_dis_amount"]);

                        //ws.Cells[vRowTotal + 3, "D"] = "Discount (" + variables.p_bestcurrencysymbol + ")   :";
                        //ws.Cells[vRowTotal + 3, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_discount"]);


                        //ws.Cells[vRowTotal + 4, "D"] = "Grand Total(" + variables.p_bestcurrencysymbol + ")   :";
                        //ws.Cells[vRowTotal + 4, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_amount"]);

                        //ws.Cells[vRowTotal + 5, "D"] = "Grand Total(" + variables.p_secondcurrencysymbol + ")   :";
                        //ws.Cells[vRowTotal + 5, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_ex_amount"]);

                    }

                    excelApp.Visible = true;
                    //ws.PrintOut(
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //// Cleanup:
                    //GC.Collect();
                    //GC.WaitForPendingFinalizers();
                    //wb.Close(false, Type.Missing, Type.Missing);
                    //excelApp.Quit();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
