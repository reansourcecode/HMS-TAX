using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.HMS;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS_TAX.Function
{
    public partial class FrmMakePaymentAP : KryptonForm
    {
        public FrmMakePaymentAP()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();
        FormatGrids formatg = new FormatGrids();

        decimal vBalance = 0;
        string vDraftID = string.Empty;
        string vIDOption = string.Empty;
        string PSysDocNum = string.Empty;

        string SysDocNum
        {
            get => PSysDocNum;
            set => PSysDocNum = value?.Trim() ?? string.Empty;
        }
        string Code
        {
            get => vDraftID;
            set => vDraftID = value?.Trim() ?? string.Empty;
        }

        public decimal Balance
        {
            get => vBalance;
            set => vBalance = value < 0 ? 0 : value;
        }


        void FormatDataGridview()
        {
            try
            {
                formatg.FormatGrid(dgView);

                //---------------------------------
                // dgData Columns vposition
                //---------------------------------
                dgView.Columns["vsysdoc"].Visible = false;

                formatg.SetColumn(dgView, "vpaiddate", 77, true);
                formatg.SetColumn(dgView, "vremark", 333, true);
                formatg.SetColumn(dgView, "vamount", 133, true);
                
                txtbalance.Enabled = false;
            }
            catch { }
        }
        private void FocusLastRow()
        {
            if (dgView.Rows.Count == 0) return;

            int lastIndex = dgView.AllowUserToAddRows
                ? dgView.Rows.Count - 2
                : dgView.Rows.Count - 1;

            dgView.ClearSelection();
            dgView.Rows[lastIndex].Selected = true;
            dgView.CurrentCell = dgView.Rows[lastIndex].Cells[0];
            dgView.FirstDisplayedScrollingRowIndex = lastIndex;
        }

        void cleartext()
        {

            txtID.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtInfo.Text = string.Empty;
            txtremark.Text = string.Empty;
            txtbalance.Text = "0.00";
            this.vDraftID = string.Empty;
            this.Code = string.Empty;
            this.PSysDocNum = string.Empty;

            DateTime today = DateTime.Today;
            pay_date.Value = today;
            dgView.Rows.Clear();
            dgView.Refresh();
        }

        void get_account_payable_history(string vstatus, string vcode)
        {
            try
            {
                string[] p =
                {
                    vstatus,
                    variables.PBranchCode,
                    vcode
                };
                DataTable dt = sql.proc_getdata("proc_get_sql_pos", p);
                dgView.Rows.Clear();
                if (dt == null || dt.Rows.Count == 0) return;
                foreach (DataRow r in dt.Rows)
                {
                    dgView.Rows.Add(
                                    r["sysdoc"]?.ToString() ?? "",
                                    DateTime.TryParse(r["paiddate"]?.ToString(), out var d) ? d.ToString("dd/MM/yyyy") : "",
                                    r["remark"]?.ToString() ?? "",
                                    decimal.TryParse(r["amount"]?.ToString(), out var a) ? a.ToString("N2") : "0.00"
                                );
                }
            }
            catch { }
        }

        void get_account_payable(string vstatus, string vcode)
        {
            try
            {
                string[] p =
                {
                    vstatus,
                    variables.PBranchCode,
                    vcode
                };

                DataTable dt = sql.proc_getdata("proc_get_sql_pos", p);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        variables.vMsgNotExits,
                        variables.vTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                    return;
                }

                DataRow row = dt.Rows[0];
                this.vDraftID = Convert.ToString(row["ap_id"]);
                txtInfo.Text = Convert.ToString(row["info"]);
                txtAmount.Focus();


                txtbalance.Text = decimal.TryParse(row["Balance"]?.ToString(), out decimal amount)
                                 ? amount.ToString("N2")   // 1,234.56 format
                                 : "0.00";

                txtAmount.Text = amount.ToString("N2");

                get_account_payable_history ("accounts_payable_history", vcode);   

            }
            catch { }
        }


        private void FrmMakePaymentAP_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                FormatDataGridview();
                cleartext();
            }
            catch { }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    get_account_payable("get_accounts_payable", txtID.Text.Trim());
                }
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                cleartext();
            }
            catch { }
        }

        private bool IsOkCommit()
        {
            try
            {
                string input = txtAmount.Text?.Trim();

                // 1. Required
                if (string.IsNullOrWhiteSpace(input))
                {
                    sql.ShowError("Amount is required.", txtAmount);
                    txtAmount.Focus();
                    return false;
                }

                // 2. Parse (culture-safe)
                if (!decimal.TryParse(input,
                                      System.Globalization.NumberStyles.Number,
                                      System.Globalization.CultureInfo.InvariantCulture,
                                      out decimal amount))
                {
                    sql.ShowError("Invalid amount. Please enter a valid number.", txtAmount);
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtbalance.Text.Trim(),
                                      System.Globalization.NumberStyles.Number,
                                      System.Globalization.CultureInfo.InvariantCulture,
                                      out decimal vBalance))
                {
                    sql.ShowError("Invalid amount. Please enter a valid number.", txtAmount);
                    txtbalance.SelectAll();
                    txtbalance.Focus();
                    return false;
                }

                // 3. Greater than zero
                if (amount <= 0)
                {
                    sql.ShowError("Amount must be greater than 0.", txtAmount);
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                    return false;
                }

                // 4. Cannot exceed balance
                if (amount > vBalance)
                {
                    sql.ShowError("Amount cannot be greater than the balance.", txtAmount);
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Validation error:\n" + ex.Message,
                    variables.vTittle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
        void add_account_payabl_paid(string vStatus)
        {
            try
            {
                DataTable dt;
                List<parasql> arr = new List<parasql>
                    {
                        new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus },
                        new parasql { paraname = "@vsysdoc", sqltype = SqlDbType.NVarChar, values = string.Empty },
                        new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode },
                        new parasql { paraname = "@vap_id", sqltype = SqlDbType.NVarChar, values = this.vDraftID },
                        new parasql { paraname = "@vpaid_date", sqltype = SqlDbType.Date, values =pay_date.Value.ToString("yyyy/MM/dd") },
                        new parasql { paraname = "@vamount", sqltype = SqlDbType.NVarChar, values = txtAmount.Text.Trim() },
                        new parasql { paraname = "@vremark", sqltype = SqlDbType.NVarChar, values = txtremark.Text.Trim() },
                        new parasql { paraname = "@vinputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter }
                    };

                dt = sql.Data_Execute("proc_register_account_payable_paid", arr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    vDraftID = Convert.ToString(dt.Rows[0]["trancode"]);
                    txtID.Text = vDraftID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    variables.vTittle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (IsOkCommit() == true)
                {
                    add_account_payabl_paid("commit");

                    MessageBox.Show("The new record has been committed successfully .\nID: " + this.vDraftID, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartext();
                }
            }
            catch { }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow only ONE decimal point
            if (e.KeyChar == '.' && !txtAmount.Text.Contains("."))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SysDocNum = dgView[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }
        void del_record(string vStatus, string vTracode, string vMsg)
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
                    get_account_payable_history("accounts_payable_history", this.vDraftID);
                }
            }
            catch { }
        }

        private void _deleted_record_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this :" + SysDocNum + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    del_record("del_acc_paid",SysDocNum, variables.vMsg_Reject);
                }
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(SysDocNum))
                {
                    _add_file.Enabled = true;
                    _deleted_record.Enabled = true; 
                    return;
                }
                _add_file.Enabled = false;
                _deleted_record.Enabled = false;
            }
            catch { }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchAccountPaid FRM_SEARCH = new FrmSearchAccountPaid();
                FRM_SEARCH.Status = "accounts_payable_paid";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    txtID.Text = FRM_SEARCH.Code;
                    this.vDraftID = FRM_SEARCH.Code;
                    get_account_payable("get_accounts_payable", this.vDraftID);
                }
                else
                {
                    txtID.Text = string.Empty;
                }
                this.Show();
            }
            catch { }
        }
    }
}
