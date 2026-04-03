
using ComponentFactory.Krypton.Toolkit;
using DevComponents.DotNetBar.Controls;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HMS_TAX.HMS
{
    public partial class FrmPaymentVoucher : KryptonForm
    {
        public FrmPaymentVoucher()
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
                formatg.FormatGrid(dgsignature);

                //---------------------------------
                // dgData Columns vposition
                //---------------------------------
                dgData.Columns["vSysDocNum"].Visible = false;

                formatg.SetColumn(dgData, "vNum", 88, false);
                formatg.SetColumn(dgData, "vDescription", 222, false);
                formatg.SetColumn(dgData, "vamount", 199, false);

                //---------------------------------
                // Signature Columns vresponeby
                //---------------------------------
                dgsignature.Columns["vsysdoc"].Visible = false;
                dgsignature.Columns["vrs_id"].Visible = false;

                formatg.SetColumn(dgsignature, "vtitle", 125, true);
                formatg.SetColumn(dgsignature, "vresponeby", 255, false);
                formatg.SetColumn(dgsignature, "vposition", 255, false);
                formatg.SetColumn(dgsignature, "vdate", 111, false);

            }
            catch { }
        }
        void cleartext()
        {

            txtPVID.Text = string.Empty;
            txtPayto.Text = string.Empty;
            txtReceipt.Text = string.Empty;
            txtinvoice.Text = string.Empty;
            txtOptionNoted.Text = string.Empty;
            cboOption.SelectedValue = "";

            this.vDraftID= string.Empty;
            this.Code = string.Empty;
            this.PSysDocNum = string.Empty;
            vTotal_row = 0;

            DateTime today = DateTime.Today;
            pv_date.Value = today;
            txtOptionNoted.Visible = false;

            dgData.Rows.Clear();
            dgData.Refresh();

        }

        private bool IsOkCommit()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPayto.Text))
                {
                    sql.ShowError("The 'Pay To' field is required.", txtPayto);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtReceipt.Text))
                {
                    sql.ShowError("The 'Receipt' field is required.", txtReceipt);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(cboOption.SelectedValue.ToString()))
                {
                    sql.ShowError("The 'Option' field is required.", cboOption);
                    return false;
                }

                if (vTotal_row > vMax_row)
                {
                    MessageBox.Show(
                        $"This record exceeds the maximum limit of {vMax_row}.",
                        variables.vTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    get_sub_info("payment_sub", this.vDraftID);
                    return false;
                }

                return true;
            }
            catch  
            {
                return false;
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
                            MakeSysDoc(dt.Rows[i]["sysdocnum"].ToString()),
                            dt.Rows[i]["rs_id"].ToString(),
                            dt.Rows[i]["title"].ToString(),
                            dt.Rows[i]["responder"].ToString(),
                            dt.Rows[i]["position"].ToString(),
                            dt.Rows[i]["rs_date"].ToString()
                        );
                    }

                    if (dgsignature.Rows.Count > 0 && dgsignature.Columns.Count > 1)
                    {
                        dgsignature.CurrentCell = dgsignature.Rows[0].Cells[3];
                        dgsignature.Rows[0].Cells[3].Selected = true;
                    }


                }
            }
            catch { }
        }

        void get_sub_info(string vstatus, string vpv_id)
        {
            try
            {
                string[] p = { vstatus, variables.PBranchCode, vpv_id };
                DataTable dt = sql.proc_getdata("proc_get_sql_search", p);

                try { dgData.Rows.Clear(); }
                catch { 
                    
                    txtPVID.Focus(); dgData.Rows.Clear();
                    get_sub_info("payment_sub", this.vDraftID);
                }

                vTotal_row = 0;

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgData.Rows.Add(
                            dt.Rows[i]["sysdocnum"].ToString(),
                            dt.Rows[i]["pay_no"].ToString(),
                            dt.Rows[i]["pay_des"].ToString(),
                            decimal.TryParse(dt.Rows[i]["pay_amount"].ToString(), out decimal amt)
                            ? amt.ToString("00.0"): "00.0"
                        );

                        vTotal_row++;
                    }
                }


                load_signature("pv_response", this.vDraftID);
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

                        string vNo = string.Empty;
                        string vSysDocNum = string.Empty;
                        string vDescription = string.Empty;
                        float vamount = 0;

                        if (dgData.Rows[i].Cells["vNum"].Value != null)
                            vNo = dgData.Rows[i].Cells["vNum"].Value.ToString();

                        if (dgData.Rows[i].Cells["vSysDocNum"].Value != null)
                            vSysDocNum = dgData.Rows[i].Cells["vSysDocNum"].Value.ToString();

                        if (dgData.Rows[i].Cells["vDescription"].Value != null)
                            vDescription = dgData.Rows[i].Cells["vDescription"].Value.ToString();

                        if (dgData.Rows[i].Cells["vamount"].Value != null)
                            float.TryParse(dgData.Rows[i].Cells["vamount"].Value.ToString(), out vamount);

                        if (!string.IsNullOrEmpty(vNo) ||
                            !string.IsNullOrEmpty(vDescription) ||
                            !string.IsNullOrEmpty(vSysDocNum) ||
                            vamount != 0)
                        {
                            List<parasql> arr = new List<parasql>();

                            arr.Add(new parasql { paraname = "@vsysdocnum", sqltype = SqlDbType.NVarChar, values = vSysDocNum });
                            arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                            arr.Add(new parasql { paraname = "@vpv_id", sqltype = SqlDbType.NVarChar, values = vCode });

                            arr.Add(new parasql { paraname = "@vpay_no", sqltype = SqlDbType.NVarChar, values = vNo });
                            arr.Add(new parasql { paraname = "@vpv_desc", sqltype = SqlDbType.NVarChar, values = vDescription });
                            arr.Add(new parasql { paraname = "@vamount", sqltype = SqlDbType.Float, values = vamount });

                            sql.Data_Execute("proc_register_paymentsub", arr);

                            vTotal_row = i + 1;
                        }
                    }

                    get_sub_info("payment_sub", vCode);
                }
            }
            catch { }
        }


        void payment_signature(string vCode, string vSysdoc, string vrs_id, string vresponder, string vposition, DateTime vrs_date)
        {
            try
            {
                DataTable dt;
                List<parasql> arr = new List<parasql>
                {
                    new parasql { paraname = "@vsysdocnum", sqltype = SqlDbType.NVarChar, values = vSysdoc },
                    new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode },
                    new parasql { paraname = "@vpv_id", sqltype = SqlDbType.NVarChar, values = vCode },
                    new parasql { paraname = "@vrs_id", sqltype = SqlDbType.NVarChar, values = vrs_id },

                    new parasql { paraname = "@vresponder", sqltype = SqlDbType.NVarChar, values = vresponder },
                    new parasql { paraname = "@vposition", sqltype = SqlDbType.NVarChar, values = vposition },
                    new parasql { paraname = "@vinputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter },
                    new parasql
                    {
                        paraname = "@vrs_date",
                        sqltype = SqlDbType.DateTime,
                        values = Convert.ToDateTime(vrs_date)
                    },
                };
                dt = sql.Data_Execute("proc_register_payment_signature", arr);

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

        void add_payment_voucher(string vStatus)
        {
            try
            {
                MakeDraftID("VoucherID");

                DataTable dt;
                List<parasql> arr = new List<parasql>
                    {
                        new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus },
                        new parasql { paraname = "@vpv_id", sqltype = SqlDbType.NVarChar, values = this.vDraftID },
                        new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode },
                        new parasql { paraname = "@vpay_date", sqltype = SqlDbType.Date, values = pv_date.Value.Date },

                        new parasql { paraname = "@vpay_to", sqltype = SqlDbType.NVarChar, values = txtPayto.Text.Trim() },
                        new parasql { paraname = "@vpay_option", sqltype = SqlDbType.NVarChar, values = cboOption.SelectedValue?.ToString() },
                        new parasql { paraname = "@vreceipt", sqltype = SqlDbType.NVarChar, values = txtReceipt.Text.Trim() },
                        new parasql { paraname = "@vinvoice", sqltype = SqlDbType.NVarChar, values = txtinvoice.Text.Trim() },
                        new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter }
                    };

                dt = sql.Data_Execute("proc_register_paymentvoucher", arr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    vDraftID = Convert.ToString(dt.Rows[0]["trancode"]);
                    txtPVID.Text = vDraftID;
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

        void Add_payment_signature(string vCode)
        {
            try
            {
                if (dgsignature.Rows.Count > 0)
                {

                    if (string.IsNullOrWhiteSpace(vCode))
                    {
                        dgsignature.Enabled = false;
                    }
                    else
                    {
                        dgsignature.Enabled = true;
                    }

                    for (int i = 0; i < dgsignature.Rows.Count; i++)
                    {
                        // skip new row
                        if (dgsignature.Rows[i].IsNewRow) continue;

                        string vSysDocNum = string.Empty;
                        string vrs_id = string.Empty;
                        string vresponeby = string.Empty;
                        string vposition = string.Empty;
                        DateTime vdate = DateTime.Today;

                        if (dgsignature.Rows[i].Cells["vsysdoc"].Value != null)
                            vSysDocNum = dgsignature.Rows[i].Cells["vsysdoc"].Value.ToString();

                        if (dgsignature.Rows[i].Cells["vresponeby"].Value != null)
                            vresponeby = dgsignature.Rows[i].Cells["vresponeby"].Value.ToString();

                        if (dgsignature.Rows[i].Cells["vposition"].Value != null)
                            vposition = dgsignature.Rows[i].Cells["vposition"].Value.ToString();

                        if (dgsignature.Rows[i].Cells["vrs_id"].Value != null)
                            vrs_id = dgsignature.Rows[i].Cells["vrs_id"].Value.ToString();

                        if (dgsignature.Rows[i].Cells["vdate"].Value != null)
                            DateTime.TryParse(dgsignature.Rows[i].Cells["vdate"].Value.ToString(), out vdate);

                        if (!string.IsNullOrEmpty(vSysDocNum) ||
                            !string.IsNullOrEmpty(vresponeby) ||
                            !string.IsNullOrEmpty(vposition)
                             )
                        {
                            //void payment_signature(string vCode, string vSysdoc, string vrs_id, string vresponder, string vposition, DateTime vrs_date)
                            payment_signature(vCode, vSysDocNum, vrs_id, vresponeby, vposition, vdate);
                        }
                    }

                    get_sub_info("payment_sub", vCode);
                }
            }
            catch { }
        }
        private void FrmPaymentVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                FormatDataGridview();
                cleartext();
                sql.Filter_ComboBox(cboOption, "exec pro_get_combo_by_branch  'PaymentOption','" + variables.PBranchCode + "'", "title", "code");
                MakeDraftID("VoucherID");
                load_signature("pv_response", this.vDraftID);

                //decimal amount = 1234.56m;
                //string result = MoneyConverter.ToWords(amount);
                //if (!string.IsNullOrEmpty(result))
                //{

                //    txtinvoice.Text = result;
                //}

            }
            catch { }
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


        string MakeSysDoc(string vsysdocnum)
        {
            try
            {
                // If DraftID already exists, return it
                if (!string.IsNullOrEmpty(vsysdocnum))
                    return vsysdocnum;
                vsysdocnum = sql.return_value("PV_SYSDOC", vsysdocnum);
                return vsysdocnum;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                cleartext();
                load_signature("pv_response", this.vDraftID);
                //MakeDraftID("VoucherID");
            }
            catch { }
        }

        private void dgData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                int realRows = dgData.Rows.Count;

                if (dgData.AllowUserToAddRows)
                {
                    realRows--; 
                }
            }
            catch { }
        }

        private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cboOption) == true)
                {
                    string vID_Option = cboOption.SelectedValue.ToString();
                    if (!string.IsNullOrEmpty(this.vDraftID) && sql.Left(this.vDraftID, 2) != "DR")   
                    {
                        DataTable dt = new DataTable();
                        List<parasql> arr = new List<parasql>();

                        arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "check_payment_option" });
                        arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                        arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = this.vDraftID });
                        arr.Add(new parasql { paraname = "@vcode2", sqltype = SqlDbType.NVarChar, values = vID_Option });

                        dt = sql.Data_Execute("proc_get_sql_search", arr);

                        if (dt.Rows.Count > 0)
                        {
                            string msg = dt.Rows[0]["msg"]?.ToString() ?? "";

                            if (!string.IsNullOrEmpty(msg))
                            {
                                MessageBox.Show(msg, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                vIDOption = dt.Rows[0]["id_option"]?.ToString() ?? "";
                                cboOption.SelectedValue = vIDOption;
                            }
                            else
                            {
                                txtOptionNoted.Text = sql.return_value("PaymentAccount", vID_Option);
                            }
                        }
                    }
                    else
                    {
                        txtOptionNoted.Text = sql.return_value("PaymentAccount", vID_Option);
                    }

                    if(vID_Option != string.Empty)
                    {
                        add_payment_voucher("I");
                    }
                }
            }
            catch { }
        }

        private void txtOptionNoted_TextChanged(object sender, EventArgs e)
        {
            if (txtOptionNoted.Text.Trim() == string.Empty)
            {
                txtOptionNoted.Visible = false;
            }
            else
            {
                txtOptionNoted.Visible = true;
            }
        }

        private void dgData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IsOkCommit())
                {
                    add_payment_voucher("I");
                    add_sub_record(this.vDraftID);
                }
            }
            catch { }
        }

        private void _clear_Click(object sender, EventArgs e)
        {
            try
            {
                cleartext();
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

        private void _add_record_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOkCommit())
                {
                    string vSysDoc= sql.return_value("PV_SYSDOC", "");

                    dgData.Rows.Add(
                            vSysDoc,
                            "",
                            "",
                            "0"
                        );
                    add_sub_record(this.vDraftID);

                    FocusLastRow();
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
                    sql.ShowError("Please verify the record information before proceeding. ", txtPayto);
                    return;
                }
                if (IsOkCommit() == true)
                {
                    add_payment_voucher("commit");
                    Add_payment_signature(this.vDraftID);

                    if (MessageBox.Show("Do you want to print reciept ", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        print.PrintPaymentVoucher("una_print", this.vDraftID, variables.pos_flag);
                    }
                    else
                    {
                        MessageBox.Show("The new record has been committed successfully .\nID: " + this.vDraftID, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch { }
        }

        void get_pv_info(string vstatus, string vcode)
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
                this.vDraftID= Convert.ToString(row["pv_id"]);
                pv_date.Value = DateTime.Parse(row["pay_date"].ToString());
                txtPayto.Text = Convert.ToString(row["pay_to"]);
                txtReceipt.Text = Convert.ToString(row["receipt"]);
                txtinvoice.Text = Convert.ToString(row["invoice"]);

                cboOption.SelectedValue = Convert.ToString(row["pay_option"]);
            }
            catch { }
        }

        private void txtPVID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    get_pv_info("pv_una_info", txtPVID.Text.Trim());
                    get_sub_info("payment_sub", this.vDraftID);
                }
            }
            catch { }
        }

        private void _verify_date_Click(object sender, EventArgs e)
        {

        }

        private void dgsignature_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgsignature.Columns.Contains("vsysdoc"))
                {
                    SysDocNum = dgsignature["vsysdoc", e.RowIndex]?.Value?.ToString() ?? "";
                }
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void dgsignature_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var cell = dgsignature["vdate", e.RowIndex];
                var text = cell?.Value?.ToString();

                if (DateTime.TryParse(text, out var vdate))
                {
                    cell.Value = vdate.ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Please enter a valid date.", variables.vTittle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cell.Value = DateTime.Today.ToString("dd/MM/yyyy");
                }
            }
        }

        private void dgsignature_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {

            }
            catch { }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchPaymentVoucher FRM_SEARCH = new FrmSearchPaymentVoucher();
                FRM_SEARCH.Status = "search_payment";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    txtPVID.Text = FRM_SEARCH.Code;
                    get_pv_info("pv_una_info", txtPVID.Text.Trim());
                    get_sub_info("payment_sub", this.vDraftID);
                }
                else
                {
                    txtPVID.Text = string.Empty;
                }
                this.Show();
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
                    get_sub_info("payment_sub", this.vDraftID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _sub_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_record("payment_sub_d", this.PSysDocNum);
            }
            catch { }
        }

        private void dgData_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgData_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.AllowDecimal(sender, e, 2); // 2 decimal places
        }
        private void dgData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgData.CurrentCell.ColumnIndex == 3) // your column index
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= Column1_KeyPress; // prevent duplicate event
                    tb.KeyPress += Column1_KeyPress;
                }
            }
        }
    }
}
