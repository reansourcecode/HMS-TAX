using ComponentFactory.Krypton.Toolkit;
using DevComponents.DotNetBar.Controls;
using HMS_TAX.HMS;
using HMS_TAX.UserDefined;
using Microsoft.Office.Core;
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
    public partial class FrmAccountPayable : KryptonForm
    {
        public FrmAccountPayable()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        FormatGrids formatg = new FormatGrids();
        print_invoice print = new print_invoice();

        int vTotal_row = 0;
        int vMax_row = 5;
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

        string IDOption
        {
            get => vIDOption;
            set => vIDOption = value?.Trim() ?? string.Empty;
        }

        void FormatDataGridview()
        {
            try
            {
                formatg.FormatGrid(dgData);

                //---------------------------------
                // dgData Columns vposition
                //---------------------------------
                dgData.Columns["vSysDocNum"].Visible = false;

                formatg.SetColumn(dgData, "vNum", 40, true);
                formatg.SetColumn(dgData, "vDescription", 355, false);
                formatg.SetColumn(dgData, "vamount", 133, false);

                //---------------------------------
                // Signature Columns vresponeby
                //---------------------------------
            }
            catch { }
        }
        private void FocusLastRow()
        {
            if (dgData.Rows.Count == 0) return;

            int lastIndex = dgData.AllowUserToAddRows
                ? dgData.Rows.Count - 2
                : dgData.Rows.Count - 1;

            dgData.ClearSelection();
            dgData.Rows[lastIndex].Selected = true;
            dgData.CurrentCell = dgData.Rows[lastIndex].Cells[0];
            dgData.FirstDisplayedScrollingRowIndex = lastIndex;
        }


        private bool IsOkCommit()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboSupply.SelectedValue.ToString()))
                {
                    sql.ShowError("The 'company' field is required.", cboSupply);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtinvoice.Text))
                {
                    sql.ShowError("The 'invoice' field is required.", txtinvoice);
                    return false;
                }

                if (!string.IsNullOrEmpty(sql.invoice_value("ExInvoice", txtinvoice.Text.Trim(),this.vDraftID)) || !string.IsNullOrEmpty(sql.invoice_value("unaExInvoice", txtinvoice.Text.Trim(), this.vDraftID)))
                {
                    sql.ShowError("Duplicate invoice is not allowed. Please enter a unique invoice number.", txtinvoice);
                    return false;
                }


                if (vTotal_row > vMax_row)
                {
                    MessageBox.Show(
                        $"This record exceeds the maximum limit of {vMax_row}.",
                        variables.vTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        void cleartext()
        {

            txtID.Text = string.Empty;
            txtinvoice.Text = string.Empty;
            txtremark.Text = string.Empty;
            cboSupply.SelectedValue = "";
            lblTotal.Text = "Total : 0.00$" ;
            this.vDraftID = string.Empty;
            this.Code = string.Empty;
            this.PSysDocNum = string.Empty;

            DateTime today = DateTime.Today;
            po_date.Value = today;
            dgData.Rows.Clear();
            dgData.Refresh();

        }
        string MakeDraftID(string vstatus)
        {
            try
            {
                // If DraftID already exists, return it
                if (!string.IsNullOrEmpty(vDraftID))
                    return vDraftID;
                vDraftID = sql.return_value(vstatus, "");
                return vDraftID;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        void get_sub_info(string vstatus, string vpv_id)
        {
            try
            {
                string[] p = { vstatus, variables.PBranchCode, vpv_id };
                DataTable dt = sql.proc_getdata("proc_get_sql_search", p);

                try { dgData.Rows.Clear(); }
                catch
                {
                    txtID.Focus();
                    dgData.Rows.Clear();
                    get_sub_info("accounts_payable_sub", this.vDraftID);
                }

                vTotal_row = 0;
                decimal vAmount = 0;
                decimal vTotalAmount = 0;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgData.Rows.Add(
                            dt.Rows[i]["sysdocnum"].ToString(),
                            (i+1).ToString(),
                            dt.Rows[i]["description"].ToString(),
                            decimal.TryParse(dt.Rows[i]["amount"].ToString(), out decimal amt)
                            ? amt.ToString("00.0") : "00.0"
                        );

                        decimal.TryParse(dt.Rows[i]["amount"].ToString(), out vAmount);
                        vTotalAmount = vTotalAmount + vAmount;
                        vTotal_row++;
                    }
                }
                lblTotal.Text = "Total : " +  string.Format("{0:0.00}", vTotalAmount);
            }
            catch { }
        }


        void add_sub_record(string vCode)
        {
            try
            {
                if (dgData.Rows.Count > 0)
                {
                    vTotal_row = 0;
                    for (int i = 0; i < dgData.Rows.Count; i++)
                    {
                        // skip new row
                        if (dgData.Rows[i].IsNewRow) continue;

                        string vSysDocNum = string.Empty;
                        string vDescription = string.Empty;
                        float vamount = 0;

                        if (dgData.Rows[i].Cells["vSysDocNum"].Value != null)
                            vSysDocNum = dgData.Rows[i].Cells["vSysDocNum"].Value.ToString();

                        if (dgData.Rows[i].Cells["vDescription"].Value != null)
                            vDescription = dgData.Rows[i].Cells["vDescription"].Value.ToString();

                        if (dgData.Rows[i].Cells["vamount"].Value != null)
                            float.TryParse(dgData.Rows[i].Cells["vamount"].Value.ToString(), out vamount);

                        if (!string.IsNullOrEmpty(vDescription) ||
                            !string.IsNullOrEmpty(vSysDocNum) ||
                            vamount != 0)
                        {
                            List<parasql> arr = new List<parasql>();

                            arr.Add(new parasql { paraname = "@vsysdocnum", sqltype = SqlDbType.NVarChar, values = vSysDocNum });
                            arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                            arr.Add(new parasql { paraname = "@vap_id", sqltype = SqlDbType.NVarChar, values = vCode });
                            arr.Add(new parasql { paraname = "@vdesc", sqltype = SqlDbType.NVarChar, values = vDescription });
                            arr.Add(new parasql { paraname = "@vamount", sqltype = SqlDbType.Float, values = vamount });

                            sql.Data_Execute("proc_accounts_payable_sub", arr);

                            vTotal_row = i + 1;
                        }
                    }

                    get_sub_info("accounts_payable_sub", this.vDraftID);

                }
            }
            catch { }
        }


        void add_account_payable(string vStatus)
        {
            try
            {
                MakeDraftID("AccountPayable");

                DataTable dt;
                List<parasql> arr = new List<parasql>
                    {
                        new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus },
                        new parasql { paraname = "@vap_id", sqltype = SqlDbType.NVarChar, values = this.vDraftID },
                        new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode },
                        new parasql { paraname = "@vap_date", sqltype = SqlDbType.Date, values = po_date.Value.Date },
                        new parasql { paraname = "@vsupply", sqltype = SqlDbType.NVarChar, values = cboSupply.SelectedValue?.ToString() },
                        new parasql { paraname = "@vinvoice", sqltype = SqlDbType.NVarChar, values = txtinvoice.Text.Trim() },
                        new parasql { paraname = "@vremark", sqltype = SqlDbType.NVarChar, values = txtremark.Text.Trim() },
                        new parasql { paraname = "@vinputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter }
                    };

                dt = sql.Data_Execute("proc_register_account_payable", arr);
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
        void delete_record(string vStatus, string vCode)
        {
            try
            {

                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vStatus", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vTran_ID", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_delete_trans", arr);
                if (dt.Rows.Count > 0)
                {
                    get_sub_info("accounts_payable_sub", this.vDraftID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                po_date.Value = DateTime.Parse(row["ap_date"].ToString());
                txtinvoice.Text = Convert.ToString(row["invoice"]);
                txtremark.Text = Convert.ToString(row["remark"]);

                cboSupply.SelectedValue = Convert.ToString(row["supply_id"]);
            }
            catch { }
        }


        private void FrmAccountPayable_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Accounts Payable Booking";
                FormatDataGridview();
                cleartext();

                sql.Filter_ComboBox(cboSupply, "exec pro_get_combo_by_branch  'SupplyActive','" + variables.PBranchCode + "'", "title", "code");
                MakeDraftID("AccountPayable");
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

        private void _sub_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOkCommit())
                {
                    string vSysDoc = sql.return_value("Payable_SYSDOC", "");
                    int vrow = dgData.Rows.Count + 1;
                    // Add new row
                    dgData.Rows.Add(
                        vSysDoc ?? string.Empty,
                        vrow,
                        string.Empty,
                        0
                    );
                    FocusLastRow();
                    add_account_payable("I");

                }
            }
            catch { }
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SysDocNum = dgData[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void dgData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IsOkCommit())
                {
                    add_account_payable("I");
                    add_sub_record(this.vDraftID);
                }
            }
            catch { }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgData.Rows.Count <= 0)
                {
                    sql.ShowError("Please verify the record information before proceeding. ",txtID);
                    return;
                }
                if (IsOkCommit() == true)
                {
                    add_account_payable("commit");
                    add_sub_record(this.vDraftID);

                    //if (MessageBox.Show("Do you want to print reciept ", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    print.PrintPaymentVoucher("una_print", this.vDraftID, variables.pos_flag);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("The new record has been committed successfully .\nID: " + this.vDraftID, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                    MessageBox.Show("The new record has been committed successfully .\nID: " + this.vDraftID, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch { }
        }

        private void cboSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(vDraftID))
            //{
            //    add_account_payable("I");
            //}
        }

       
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    get_account_payable("accounts_payable", txtID.Text.Trim());
                    get_sub_info("accounts_payable_sub", this.vDraftID);

                }
            }
            catch { }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.AllowDecimal(sender, e, 2); // 2 decimal places
        }
        private void dgData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgData.CurrentCell.ColumnIndex == 3 ) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

        }

        private void _sub_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_record("account_payable_d", this.PSysDocNum);
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (dgData.Rows.Count <= 1)
                {
                    _sub_delete.Enabled = false;
                }
                _sub_delete.Enabled = !string.IsNullOrWhiteSpace(PSysDocNum);
            }
            catch { }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchAccountPayable FRM_SEARCH = new FrmSearchAccountPayable();
                FRM_SEARCH.Status = "accounts_payable_search";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    txtID.Text = FRM_SEARCH.Code;
                    this.vDraftID = FRM_SEARCH.Code;

                    get_account_payable("accounts_payable", this.vDraftID);
                    get_sub_info("accounts_payable_sub", this.vDraftID);
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
