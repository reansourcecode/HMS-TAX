using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HMS_TAX.HMS_Auth
{
    public partial class FrmAuthPaymentVoucher : KryptonForm
    {
        public FrmAuthPaymentVoucher()
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
                dgData.Columns["vpvcode"].Visible = false;
                FG.SetColumn(dgData, "vcode", 22, true);
                FG.SetColumn(dgData, "vpayto", 88, true);
                FG.SetColumn(dgData, "vdate", 50, true);
                FG.SetColumn(dgData, "voption", 77, true);
                FG.SetColumn(dgData, "vreceipt", 77, true);
                FG.SetColumn(dgData, "vinvoice", 77, true);


                dgData.Columns["vcode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //---------------------------------
                // Signature Columns vresponeby
                //---------------------------------

                dgView.Columns["vSysDocNum"].Visible = false;
                FG.SetColumn(dgView, "vNum", 77, true);
                FG.SetColumn(dgView, "vDescription", 200, true);
                FG.SetColumn(dgView, "vamount", 150, true);
                dgView.Columns["vNum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



                //---------------------------------
                // Signature Columns vresponeby
                //---------------------------------
                dgsignature.Columns["vsysdoc"].Visible = false;
                dgsignature.Columns["vrs_id"].Visible = false;
                dgsignature.Columns["vsgdate"].Visible = false;

                FG.SetColumn(dgsignature, "vtitle", 125, true);
                FG.SetColumn(dgsignature, "vresponeby", 125, false);
                FG.SetColumn(dgsignature, "vposition", 125, false);

                dgView.Enabled = false;
                dgsignature.Enabled = false;


            }
            catch { }
        }

        void Get_pv_sub_info(string vstatus, string vpv_id)
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
                        row["pay_no"]?.ToString() ?? string.Empty,
                        row["pay_des"]?.ToString() ?? string.Empty,
                        decimal.TryParse(row["pay_amount"]?.ToString(), out decimal amt)
                            ? amt.ToString("00.0")
                            : "00.0"
                    );
                }
            }
            catch { }
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

                DataTable record = sql.proc_getdata("proc_get_sql_pos", p);
                dgData.Rows.Clear();
                dgView.Rows.Clear();

                if (record != null && record.Rows.Count > 0)
                {
                    Code = string.Empty;
                    dgData.SuspendLayout(); // performance improvement

                    for (int i = 0; i < record.Rows.Count; i++)
                    {
                        DataRow row = record.Rows[i];
                        dgData.Rows.Add(
                            i + 1,
                            row["pv_id"]?.ToString(),
                            row["pay_to"]?.ToString(),
                            Convert.ToDateTime(row["pay_date"]).ToString("dd/MM/yyyy"),
                            row["pay_option"]?.ToString(),
                            row["receipt"]?.ToString(),
                            row["invoice"]?.ToString()
                        );
                    }

                    dgData.ResumeLayout();
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

        void load_signature(string vstatus, string vpv_id)
        {
            try
            {
                dgsignature.Rows.Clear();

                DataTable dt = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vpv_id
                    };

                dt = sql.proc_getdata("proc_get_sql_search", p);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgsignature.Rows.Add(
                            dt.Rows[i]["sysdocnum"].ToString(),
                            dt.Rows[i]["rs_id"].ToString(),
                            dt.Rows[i]["title"].ToString(),
                            dt.Rows[i]["responder"].ToString(),
                            dt.Rows[i]["position"].ToString(),
                            dt.Rows[i]["rs_date"].ToString()
                        );
                    }
                }
            }
            catch { }
        }

        private void FrmAuthPaymentVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle + " - Authorize Payment Voucher";
                FormatDataGridview();
                record_list("pv_una_payment", "%");
            }
            catch { }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    record_list("pv_una_payment", txtSearch.Text.Trim());
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
                Get_pv_sub_info("payment_sub", this.vDraftID);
                load_signature("pv_response", this.vDraftID);
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

                    record_list("pv_una_payment", "%");

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
                        auth_record("pv_Auth", this.vDraftID, variables.vMsg_Auth);
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
                    auth_record("r_paymentvoucher", this.vDraftID, variables.vMsg_Reject);
                }
            }
            catch { }
        }

        private void _Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                record_list("pv_una_payment", "%");
            }
            catch { }
        }
    }
}
