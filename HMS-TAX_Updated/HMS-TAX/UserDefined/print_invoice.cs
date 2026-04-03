using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace HMS_TAX.UserDefined
{
    internal class print_invoice
    {
        sqlexcute sql = new sqlexcute();

        public void RePrintPOS(string vStatus, string vCode, string vType)
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
                        ws.Cells[vRowStart + i, "F"] = String.Format("{0:0.##}", dt.Rows[i]["unitprice"]);
                        ws.Cells[vRowStart + i, "G"] = string.Format("{0:0}", dt.Rows[i]["discount"]) + "%";
                        ws.Cells[vRowStart + i, "H"] = String.Format("{0:0.##}", dt.Rows[i]["sub_amount"]);
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

        public void RePrintExcelOnly(string vStatus, string vCode, string vType)
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
                        ws.Cells[vRowStart + i, "F"] = String.Format("{0:0.##}", dt.Rows[i]["unitprice"]);
                        ws.Cells[vRowStart + i, "G"] = string.Format("{0:0}", dt.Rows[i]["discount"]) + "%";
                        ws.Cells[vRowStart + i, "H"] = String.Format("{0:0.##}", dt.Rows[i]["sub_amount"]);
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
                    //ws.PrintOut(
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //ws.PrintOut(
                    //   Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    //   Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //// Cleanup:
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //wb.Close(false, Type.Missing, Type.Missing);
                    //excelApp.Quit();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


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
                        ws.Cells[vRowStart + i, "F"] = String.Format("{0:0.##}", dt.Rows[i]["unitprice"]);   
                        ws.Cells[vRowStart + i, "G"] = string.Format("{0:0}", dt.Rows[i]["discount"]) + "%";
                        ws.Cells[vRowStart + i, "H"] = String.Format("{0:0.##}", dt.Rows[i]["sub_amount"]);  
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
                    //ws.PrintOut(
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //ws.PrintOut(
                    //   Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    //   Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //// Cleanup:
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //wb.Close(false, Type.Missing, Type.Missing);
                    //excelApp.Quit();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string FormatDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
                return "0";

            if (decimal.TryParse(value.ToString(), out decimal result))
                return result.ToString("0.##");

            return "0";
        }

        private void ShowMessage(string msg, MessageBoxIcon icon)
        {
            MessageBox.Show(msg, variables.vTittle, MessageBoxButtons.OK, icon);
        }

        private decimal SafeDecimal(object value)
        {
            decimal.TryParse(value?.ToString(), out decimal result);
            return result;
        }

        private DateTime SafeDate(object value)
        {
            DateTime.TryParse(value?.ToString(), out DateTime result);
            return result;
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch { }
            finally
            {
                obj = null;
            }
        }

        public void PrintPaymentVoucher(string vStatus, string vCode, string vType)
        {
            try
            {
                // ✅ 1. Get Data
                var parameters = new string[]
                {
                    vStatus,
                    variables.PBranchCode,
                    vCode
                };

                var parameter_signature = new string[]
                {
                    "una_signature",
                    variables.PBranchCode,
                    vCode
                };


                DataTable dt = sql.proc_getdata("proc_print_PaymentVoucher", parameters);

                DataTable signature = sql.proc_getdata("proc_print_PaymentVoucher", parameter_signature);


                if (dt == null || dt.Rows.Count == 0)
                {
                    ShowMessage("No data found.", MessageBoxIcon.Warning);
                    return;
                }

                // ✅ 2. Validate Template
                string reportPath = Path.Combine(Application.StartupPath, @"Reports\rcp\PaymentVoucher.xlsx");

                if (!File.Exists(reportPath))
                {
                    ShowMessage("Report template not found!", MessageBoxIcon.Error);
                    return;
                }

                Excel.Application excelApp = null;
                Excel.Workbook templateWb = null;
                Excel.Workbook reportWb = null;
                Excel.Worksheet ws = null;

                try
                {
                    excelApp = new Excel.Application
                    {
                        DisplayAlerts = false,
                        SheetsInNewWorkbook = 1
                    };

                    // ✅ 3. Open Template
                    templateWb = excelApp.Workbooks.Open(reportPath);

                    // ✅ 4. Create New Workbook
                    reportWb = excelApp.Workbooks.Add();
                    templateWb.Sheets[1].Copy(reportWb.Sheets[1]);
                    ws = (Excel.Worksheet)reportWb.Sheets[1];

                    int startRow = 17;
                    int rowCount = dt.Rows.Count;

                    decimal total = 0;

                    // ✅ 5. Prepare Bulk Data (FAST 🚀)
                    object[,] data = new object[rowCount, 3];

                    for (int i = 0; i < rowCount; i++)
                    {
                        var r = dt.Rows[i];

                        decimal amount = SafeDecimal(r["pay_amount"]);
                        total += amount;

                        data[i, 0] = r["pay_no"]?.ToString();
                        data[i, 1] = r["pay_des"]?.ToString();
                        data[i, 2] = amount;
                    }

                    // ✅ 6. Write Bulk Data to Excel (SUPER FAST)
                    Excel.Range startCell = ws.Cells[startRow, 1];
                    Excel.Range endCell = ws.Cells[startRow + rowCount - 1, 8];

                    // Map to columns A, C, H manually
                    for (int i = 0; i < rowCount; i++)
                    {
                        ws.Cells[startRow + i, "A"] = data[i, 0];
                        ws.Cells[startRow + i, "C"] = data[i, 1];
                        ws.Cells[startRow + i, "H"] = data[i, 2];
                    }

                    // ✅ 7. Header Info
                    var first = dt.Rows[0];

                    ws.Cells[7, "B"] = SafeDate(first["pay_date"]).ToString("dd/MM/yyyy");
                    ws.Cells[7, "H"] = first["pv_id"]?.ToString();
                    ws.Cells[9, "B"] = first["pay_to"]?.ToString();
                    ws.Cells[12, "A"] = first["option_title"]?.ToString();

                    ws.Cells[8, "H"] = first["invoice"]?.ToString();
                    ws.Cells[9, "H"] = first["receipt"]?.ToString();

                    // ✅ 8. Total in Words
                    ws.Cells[13, "F"] = MoneyConverter.ToWords(total);


                    for (int i = 0; i < signature.Rows.Count; i++)
                    {
                        ws.Cells[32+i, "A"] = signature.Rows[i]["rs_title"].ToString();
                        ws.Cells[32+i, "B"] = signature.Rows[i]["responder"].ToString();
                        ws.Cells[32+i, "F"] = signature.Rows[i]["position"].ToString();
                        ws.Cells[32+i, "I"] = SafeDate(signature.Rows[i]["rs_date"]).ToString("dd/MM/yyyy");

                    }

                    // ✅ 9. Close Template
                    templateWb.Close(false);

                    // ✅ 10. Show Excel
                    excelApp.Visible = true;
                    ws.Select();
                }
                finally
                {
                    // ✅ CLEAN COM MEMORY (VERY IMPORTANT)
                    ReleaseObject(ws);
                    ReleaseObject(templateWb);
                    ReleaseObject(reportWb);
                    ReleaseObject(excelApp);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error: {ex.Message}", MessageBoxIcon.Error);
            }
        }




    }
}
