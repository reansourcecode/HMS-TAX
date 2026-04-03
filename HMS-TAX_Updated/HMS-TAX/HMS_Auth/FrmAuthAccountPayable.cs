using Bunifu.UI.WinForms;
using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HMS_TAX.HMS_Auth
{
    public partial class FrmAuthAccountPayable : KryptonForm
    {
        public FrmAuthAccountPayable()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        FormatGrids FG = new FormatGrids();
        string vDraftID = string.Empty;
        string Code
        {
            get { return vDraftID; }
            set { vDraftID = value; }
        }
        void FormatDataGridview()
        {
            try
            {
                FG.FormatGrid(dgData);

                //---------------------------------
                // dgData Columns vposition
                //---------------------------------
                dgData.Columns["vap_id"].Visible = false;
                FG.SetColumn(dgData, "vcode", 22, true);
                FG.SetColumn(dgData, "vsupply", 100, true);
                FG.SetColumn(dgData, "vdate", 50, true);
                FG.SetColumn(dgData, "vinvoice", 155, true);


                dgData.Columns["vcode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //---------------------------------
                // Signature Columns vresponeby
                //---------------------------------

                //dgView.Columns["vSysDocNum"].Visible = true;
                //FG.SetColumn(dgView, "vNum", 77, true);
                FG.SetColumn(dgView, "vSysDocNum", 55, true);
                FG.SetColumn(dgView, "vDescription", 250, true);
                FG.SetColumn(dgView, "vamount", 150, true);
                dgView.Columns["vamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgView.Columns["vSysDocNum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dgView.Enabled = false;


            }
            catch { }
        }

        void get_Account_Payable(string vstatus, string vpv_id)
        {
            try
            {
                string[] p = { vstatus, variables.PBranchCode, vpv_id };
                DataTable dt = sql.proc_getdata("proc_get_sql_search", p);
                try { dgView.Rows.Clear(); }
                catch { txtSearch.Focus(); dgView.Rows.Clear(); }

                if (dt == null || dt.Rows.Count == 0) return;
                foreach (DataRow row in dt.Rows)
                {
                    dgView.Rows.Add(
                        row["sysdocnum"]?.ToString() ?? string.Empty,
                        row["description"]?.ToString() ?? string.Empty,
                        decimal.TryParse(row["amount"]?.ToString(), out decimal amt)
                            ? amt.ToString("00.0")
                            : "00.0"
                    );
                }
            }
            catch { }
        }
        private void ToggleButtons(bool isEnabled)
        {
            btnCommit.Enabled = isEnabled;
            btnReject.Enabled = isEnabled;
            _Approved.Enabled = isEnabled;
        }

        void record_list(string vstatus, string vSearch)
        {
            try
            {
                string[] p =
                {
                    vstatus,
                    variables.PBranchCode,
                    vSearch
                };

                DataTable record = sql.proc_getdata("proc_get_sql_search", p);
                dgData.Rows.Clear();
                dgView.Rows.Clear();
                txtSearch.Focus();
                txtSearch.Text = string.Empty;
                if (record == null || record.Rows.Count == 0)
                {
                    ToggleButtons(false);
                    return;
                }

                if (record != null && record.Rows.Count > 0)
                {
                    Code = string.Empty;
                    dgData.SuspendLayout(); // performance improvement

                    for (int i = 0; i < record.Rows.Count; i++)
                    {
                        DataRow row = record.Rows[i];
                        dgData.Rows.Add(
                            i + 1,
                            row["ap_id"]?.ToString(),
                            row["sup_name"]?.ToString(),
                            Convert.ToDateTime(row["ap_date"]).ToString("dd/MM/yyyy"),
                            row["invoice"]?.ToString()
                        );
                    }
                    dgData.ResumeLayout();
                    ToggleButtons(true);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading records : " + ex.Message,
                    variables.vTittle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    record_list("accounts_payable_search", txtSearch.Text.Trim());
                }
            }
            catch { }
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Code = dgData[1, e.RowIndex].Value.ToString();
                txtSearch.Text = vDraftID;


                get_Account_Payable("accounts_payable_sub", this.vDraftID);
            }
            catch { }
        }
        bool ch_ok(string vStatus, string vTracode)
        {
            try
            {
                List<parasql> arr = new List<parasql>()
                {
                    new parasql { paraname = "@vstatus",     sqltype = SqlDbType.NVarChar, values = vStatus },
                    new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode },
                    new parasql { paraname = "@vcode1",      sqltype = SqlDbType.NVarChar, values = vTracode }
                };

                DataTable dt = sql.Data_Execute("proc_get_isok", arr);

                if (dt != null && dt.Rows.Count > 0)
                {
                    string msg = dt.Rows[0]["Msg"]?.ToString();

                    if (!string.IsNullOrWhiteSpace(msg))
                    {
                        MessageBox.Show(msg, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                string vInvoice = sql.return_value("getInvoice", vTracode);
                if (!string.IsNullOrEmpty(sql.invoice_value("ExInvoice", vInvoice, vTracode)) || !string.IsNullOrEmpty(sql.invoice_value("unaExInvoice", vInvoice, vTracode)))
                {
                    sql.ShowError("Duplicate invoice is not allowed. Please enter a unique invoice number.", txtSearch);
                    return false;
                }


                if (string.IsNullOrWhiteSpace(this.vDraftID))
                {
                    MessageBox.Show("Please select payment voucher information again!",
                                    variables.vTittle,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error : " + ex.Message,
                                variables.vTittle,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return false;
            }
        }
        void auth_record(string vStatus, string vTracode, string vMsg)
        {
            try
            {
                List<parasql> arr = new List<parasql>()
                {
                    new parasql { paraname = "@vCMD",        sqltype = SqlDbType.NVarChar, values = vStatus },
                    new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode },
                    new parasql { paraname = "@vts_ID",      sqltype = SqlDbType.NVarChar, values = vTracode },
                    new parasql { paraname = "@vInputter",   sqltype = SqlDbType.NVarChar, values = variables.PInputter }
                };

                DataTable dt = sql.Data_Execute("proc_auth_paymentvoucher", arr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string vInvoice = dt.Rows[0]["TRANCODE"]?.ToString();


                    MessageBox.Show(
                        vMsg + Environment.NewLine + "Invoice : " + vInvoice,
                        variables.vTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    record_list("accounts_payable_search", "%");

                }
                else
                {
                    MessageBox.Show(
                        "No record was processed.",
                        variables.vTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch { }
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ch_ok("ch_pos", this.vDraftID) == true)
                {
                    if (MessageBox.Show("Do you want to authorize :" + this.vDraftID + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        auth_record("Auth_AccPay", this.vDraftID, variables.vMsg_Auth);
                    }
                }
            }
            catch { }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to reject :" + this.vDraftID + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    auth_record("r_AccountPayable", this.vDraftID, variables.vMsg_Reject);
                }
            }
            catch { }
        }

        private void _Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                record_list("accounts_payable_search", "%");
            }
            catch { }
        }

        private void FrmAuthAccountPayable_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = " - Authorize Account Payable";
                FormatDataGridview();
                record_list("accounts_payable_search", "%");
            }
            catch { }
        }
    }
}
