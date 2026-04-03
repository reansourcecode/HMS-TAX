using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;
using Excel = Microsoft.Office.Interop.Excel;

namespace HMS_TAX.Function
{
    public partial class FrmReports : KryptonForm
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();
        public string PStatus = string.Empty;
        public string PCode = string.Empty;

        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        public string Code
        {
            get { return PCode; }
            set { PCode = value; }
        }


        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < rtpData.Columns.Count; i++)
                {
                    rtpData.Columns[i].ReadOnly = true;
                    rtpData.Columns[i].Width = 222;
                }

                rtpData.Columns["vrpt_name"].Visible = false;
                rtpData.Columns["vrpt_id"].Width = 55;

                rtpData.AutoResizeColumnHeadersHeight();

                // Resize all the row heights to fit the contents of all non-header cells.
                rtpData.AutoResizeRows(
                    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                //txtTypeCode
                this.rtpData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                rtpData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;


                this.rtpData.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.rtpData.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }

        void rpt_list(string vstatus)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     ""
                    };
                rtpData.Rows.Clear();
                dblist = sql.proc_getdata("proc_rpt_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        rtpData.Rows.Add(
                            dblist.Rows[i]["code"].ToString(),
                            (i + 1).ToString(),
                            dblist.Rows[i]["name"].ToString()
                        );
                    }
                }
                else
                {


                }
            }
            catch { }
        }

        bool IsOk()
        {

            return true;
        }

        void rpt_po_summary()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_po_summary", arr);

                if (dt.Rows.Count > 0)
                {

                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_po_summary.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 6;
                        ws.Cells[4, "D"] = DateTime.Today;
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "B"] = (i + 1).ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["po_id"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["sup_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["pro_name"].ToString();
                            ws.Cells[Start + i, "F"] = dt.Rows[i]["cost"].ToString();
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["oth_cost"].ToString();
                            ws.Cells[Start + i, "H"] = dt.Rows[i]["qty"].ToString();
                            ws.Cells[Start + i, "I"] = dt.Rows[i]["amount"].ToString();
                            ws.Cells[Start + i, "J"] = dt.Rows[i]["sto_name"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }

                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }
            }
            catch { }
        }
        void rpt_po_details()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_po_details", arr);
                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_po_details.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 6;
                        ws.Cells[4, "D"] = DateTime.Today;
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "B"] = (i + 1).ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["po_id"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["sup_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["po_date"].ToString();
                            ws.Cells[Start + i, "F"] = dt.Rows[i]["pro_name"].ToString();
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["cost"].ToString();
                            ws.Cells[Start + i, "H"] = dt.Rows[i]["oth_cost"].ToString();
                            ws.Cells[Start + i, "I"] = dt.Rows[i]["qty"].ToString();
                            ws.Cells[Start + i, "J"] = dt.Rows[i]["discount"].ToString();
                            ws.Cells[Start + i, "K"] = dt.Rows[i]["amount"].ToString();
                            ws.Cells[Start + i, "L"] = dt.Rows[i]["sto_name"].ToString();
                            ws.Cells[Start + i, "M"] = dt.Rows[i]["exp_date"].ToString();
                            ws.Cells[Start + i, "N"] = dt.Rows[i]["inputter"].ToString();
                            ws.Cells[Start + i, "O"] = dt.Rows[i]["batch_id"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }

                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }

            }
            catch { }
        }

        void rpt_account_payable()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsupply_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_account_payable", arr);
                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_account_payable.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 8;
                        ws.Cells[5, "A"] = "AP DETAIL FOR " + dtFrom.Value.ToString("dd/MM/yyyy") +" - "+ dtTo.Value.ToString("dd/MM/yyyy");
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        string lastApId = "";
                        int groupStartRow = Start;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string currentApId = dt.Rows[i]["ap_id"].ToString();
                            int rowIndex = Start + i;

                            // Only write A–E if new ap_id
                            if (currentApId != lastApId)
                            {

                                ws.Cells[rowIndex, "A"] = currentApId;
                                ws.Cells[rowIndex, "B"] = Convert.ToDateTime(dt.Rows[i]["ap_date"]).ToString("dd/MM/yyyy");
                                ws.Cells[rowIndex, "C"] = dt.Rows[i]["invoice"].ToString();
                                ws.Cells[rowIndex, "D"] = dt.Rows[i]["sup_name"].ToString();
                                ws.Cells[rowIndex, "E"] = dt.Rows[i]["description"].ToString();
                                ws.Cells[rowIndex, "F"] = dt.Rows[i]["TotalAmount"].ToString();

                                ws.Cells[rowIndex, "I"] = dt.Rows[i]["balance"].ToString();

                                // Start new group
                                groupStartRow = rowIndex;
                                lastApId = currentApId;
                            }

                            // Always write F, G, H
                            ws.Cells[rowIndex, "G"] = DateTime.TryParse(dt.Rows[i]["paiddate"]?.ToString(), out var paidDate)
                                ? paidDate.ToString("dd/MM/yyyy")
                                : "";

                            ws.Cells[rowIndex, "H"] = dt.Rows[i]["amount"].ToString();
                            progressbarsetup.Value = i + 1;
                        }


                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }

            }
            catch { }
        }



        void rpt_pos_details()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vcus_id", sqltype = SqlDbType.NVarChar, values = cboCustomer.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_pos_details", arr);
                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_pos_details.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 6;
                        ws.Cells[4, "F"] = DateTime.Today;
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "B"] = (i + 1).ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["rcp_num"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["cus_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["pro_name"].ToString();
                            ws.Cells[Start + i, "F"] = dt.Rows[i]["sto_name"].ToString();
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["cost"].ToString();
                            ws.Cells[Start + i, "H"] = dt.Rows[i]["unitprice"].ToString();
                            ws.Cells[Start + i, "I"] = String.Format("{0:0}", dt.Rows[i]["discount"]).ToString() + " %";
                            ws.Cells[Start + i, "J"] = dt.Rows[i]["qty"].ToString();
                            ws.Cells[Start + i, "K"] = dt.Rows[i]["amount"].ToString();
                            ws.Cells[Start + i, "L"] = dt.Rows[i]["inputter"].ToString();
                            ws.Cells[Start + i, "M"] = dt.Rows[i]["rcp_date"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }
                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }

            }
            catch { }
        }

        void rpt_customer_info()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_customer_info", arr);

                if (dt.Rows.Count > 0)
                {

                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_customer_info.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 6;
                        ws.Cells[4, "D"] = DateTime.Today;
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "B"] = (i + 1).ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["cus_id"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["cus_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["phone"].ToString();
                            ws.Cells[Start + i, "F"] = dt.Rows[i]["address"].ToString();
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["remark"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }

                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }
            }
            catch { }
        }
        void rpt_product_details()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_product_details", arr);
                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_product_details.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 7;
                        ws.Cells[3, "H"] = dtFrom.Value.ToString("yyyy/MM/dd") +"-"+ dtTo.Value.ToString("yyyy/MM/dd");

                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "A"] = (i + 1).ToString();
                            ws.Cells[Start + i, "B"] = dt.Rows[i]["pro_name"].ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["sto_name"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["mol_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["pack_name"].ToString();
                            ws.Cells[Start + i, "F"] = "";
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["qty_opening"].ToString();
                            ws.Cells[Start + i, "H"] = dt.Rows[i]["qty_po"].ToString();
                            ws.Cells[Start + i, "I"] = dt.Rows[i]["cost_po"].ToString();
                            ws.Cells[Start + i, "J"] = dt.Rows[i]["oth_cost_po"].ToString();
                            ws.Cells[Start + i, "K"] = dt.Rows[i]["qty_sale"].ToString();
                            ws.Cells[Start + i, "L"] = dt.Rows[i]["t_amount_sale"].ToString();
                            ws.Cells[Start + i, "M"] = dt.Rows[i]["t_cost_sale"].ToString();
                            ws.Cells[Start + i, "N"] = dt.Rows[i]["other_qty"].ToString();
                            ws.Cells[Start + i, "O"] = dt.Rows[i]["qty_ending"].ToString();
                            ws.Cells[Start + i, "P"] = "0";
                            ws.Cells[Start + i, "Q"] = dt.Rows[i]["cost_ending"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }

                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }

            }
            catch { }
        }

        void rpt_in_stock()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_in_stock", arr);
                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_in_stock.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 6;
                        ws.Cells[4, "D"] = DateTime.Today;
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "B"] = (i + 1).ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["pro_name"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["sto_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["qty"].ToString();
                            ws.Cells[Start + i, "F"] = dt.Rows[i]["stockin"].ToString();
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["stockout"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }

                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }

            }
            catch { }
        }
        void rpt_in_stock_inout()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cbosupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vmol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpacking_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vdate_from", sqltype = SqlDbType.NVarChar, values = dtFrom.Value.ToString("yyyy/MM/dd") });
                arr.Add(new parasql { paraname = "@vdate_to", sqltype = SqlDbType.NVarChar, values = dtTo.Value.ToString("yyyy/MM/dd") });

                dt = sql.Data_Execute("rpt_in_stock_inout", arr);
                if (dt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;
                    try
                    {
                        excelApplication = new Excel.Application();
                        excelApplication.SheetsInNewWorkbook = 1;
                        excelApplication.DisplayAlerts = false;

                        // Open the template
                        workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\rpt_in_stock_inout.xlsx");

                        // Create working report
                        workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                        workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                        int Start = 6;
                        ws.Cells[4, "D"] = DateTime.Today;
                        progressbarsetup.Visible = true;
                        progressbarsetup.Minimum = 0;
                        progressbarsetup.Maximum = dt.Rows.Count + 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            ws.Cells[Start + i, "B"] = (i + 1).ToString();
                            ws.Cells[Start + i, "C"] = dt.Rows[i]["pro_name"].ToString();
                            ws.Cells[Start + i, "D"] = dt.Rows[i]["sto_name"].ToString();
                            ws.Cells[Start + i, "E"] = dt.Rows[i]["qty"].ToString();
                            ws.Cells[Start + i, "F"] = dt.Rows[i]["qty_balance"].ToString();
                            ws.Cells[Start + i, "G"] = dt.Rows[i]["batch_id"].ToString();
                            ws.Cells[Start + i, "H"] = dt.Rows[i]["inputter"].ToString();
                            ws.Cells[Start + i, "I"] = dt.Rows[i]["create_at"].ToString();
                            ws.Cells[Start + i, "J"] = dt.Rows[i]["referent"].ToString();

                            progressbarsetup.Value = (i + 1);

                        }

                        progressbarsetup.Value = 0;
                        progressbarsetup.Visible = false;
                        workbookTemplate.Close();
                        // Set the active sheet
                        ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                        // Show the report
                        excelApplication.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No data display .", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressbarsetup.Visible = false;
                }

            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk() == true)
                {
                    if (Code == "rpt_po_details")
                    {
                        rpt_po_details();
                    }
                    else if (Code == "rpt_po_summary")
                    {
                        rpt_po_summary();
                    }
                    else if (Code == "rpt_customer_info")
                    {
                        rpt_customer_info();
                    }

                    else if (Code == "rpt_product_details")
                    {
                        rpt_product_details();
                    }

                    else if (Code == "rpt_pos_details")
                    {
                        rpt_pos_details();
                    }

                    else if (Code == "rpt_in_stock")
                    {
                        rpt_in_stock();
                    }

                    else if (Code == "rpt_in_stock_inout")
                    {
                        rpt_in_stock_inout();
                    }

                    else if (Code == "rpt_account_payable")
                    {
                        rpt_account_payable();
                    }

                }
            }
            catch { }
        }
        private void FrmReports_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle + " - Reports";
                FormatDataGridview();
                rpt_list("rpt_name");

                sql.Filter_ComboBox(cboStock, "exec proc_rpt_sql  'rpt_cbo_stock','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboProduct, "exec proc_rpt_sql  'rpt_product','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboCustomer, "exec proc_rpt_sql  'rpt_customer','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cbosupply, "exec proc_rpt_sql  'rpt_supply','" + variables.PBranchCode + "','%'", "name", "code");

                sql.Filter_ComboBox(cboLine, "exec proc_rpt_sql  'rpt_line','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboMolecule, "exec proc_rpt_sql  'rpt_Mol','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboPacking, "exec proc_rpt_sql  'rpt_packing','" + variables.PBranchCode + "','%'", "name", "code");

            }
            catch { }
        }


        private void rtpData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblShow.Text =  rtpData[2, e.RowIndex].Value.ToString();
                PCode = rtpData[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }

    }
}
