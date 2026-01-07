using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HMS_TAX.UserDefined;
using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.Function;
using System.Globalization;

namespace HMS_TAX.HMS
{
    public partial class FrmPurchaseorder : KryptonForm
    {
        public FrmPurchaseorder()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
 

        public string PStatus = string.Empty;
        public string PCode = string.Empty;
        public string PSysDocNum = string.Empty;

        public string SysDocNum
        {
            get { return PSysDocNum; }
            set { PSysDocNum = value; }
        }

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

        void clearRecord()
        {
            txtID.Text = string.Empty;
            cboProduct.SelectedValue = string.Empty;
            lblInfo.Text = string.Empty;
            lbltotal.Text = "0.00";

            dgData.Rows.Clear();
            load_data();
            DateTime today = DateTime.Today;
            vexpired_date.Value = today;
        }

        void edit_una_list(string vStatus, string vSysDoc, string vsto_id, double vcost, double vother_cost, double vdis, double vqty)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vSysDoc", sqltype = SqlDbType.NVarChar, values = vSysDoc });
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsto_ID", sqltype = SqlDbType.NVarChar, values = vsto_id });
                arr.Add(new parasql { paraname = "@vcost", sqltype = SqlDbType.Float, values = vcost });
                arr.Add(new parasql { paraname = "@vother_cost", sqltype = SqlDbType.Float, values = vother_cost });
                arr.Add(new parasql { paraname = "@vdis", sqltype = SqlDbType.Float, values = vdis });
                arr.Add(new parasql { paraname = "@vqty", sqltype = SqlDbType.Float, values = vqty });
                dt = sql.Data_Execute("proc_PO_edit_list", arr);
                if (dt.Rows.Count > 0)
                {
                    // load_una_list("show_po_una_list", this.PCode);
                }
            }
            catch { }
        }


        void calculator()
        {
            try
            {
                if (dgData.Rows.Count > 0)
                {
                    int vQty = 0;
                    double vCost = 0;
                    double vOtherCost = 0;
                    double vDiscount = 0;
                    double vAmount = 0;
                    double T_Amount = 0;
                    double other_Amount = 0;
                    double Dis = 0;

                    double TotalAmount = 0;
                    double OtherTotalAmount = 0;


                    for (int i = 0; i < dgData.Rows.Count; i++)
                    {
                        if (sql.Rights(dgData["vDiscount", i].Value.ToString(), 1) == "%")
                        {
                            Dis = Convert.ToDouble(sql.Left(dgData["vDiscount", i].Value.ToString(), dgData["vDiscount", i].Value.ToString().Length - 1));
                        }
                        else
                        {
                            Dis = Convert.ToDouble(dgData["vDiscount", i].Value);
                        }

                        int.TryParse(dgData["vQty", i].Value.ToString(), out vQty);
                        double.TryParse(dgData["vCost", i].Value.ToString(), out vCost);
                        double.TryParse(dgData["vOtherCost", i].Value.ToString(), out vOtherCost);
                        double.TryParse(Dis.ToString(), out vDiscount);

                        vAmount = (vQty * vCost);
                        TotalAmount = vAmount - (vAmount * vDiscount / 100);

                        other_Amount = (vQty * vOtherCost);
                        OtherTotalAmount = (other_Amount - (other_Amount * vDiscount / 100));

                        if (sql.Rights(dgData["vDiscount", i].Value.ToString(), 1) != "%")
                        {
                            dgData["vDiscount", i].Value = dgData["vDiscount", i].Value + "%";
                        }

                        foreach (DataGridViewRow row in dgData.Rows)
                        {
                            if (row.Index.ToString() == i.ToString())
                                row.Cells[9].Value = TotalAmount + OtherTotalAmount;
                        }

                        T_Amount = T_Amount + TotalAmount + OtherTotalAmount;
                    }
                    lbltotal.Text = "Total : " + String.Format("{0:0.00}", T_Amount).ToString();
                }
            }
            catch { }
        }

        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgData.Columns.Count; i++)
                {
                    dgData.Columns[i].ReadOnly = true;
                    dgData.Columns[i].Width = 140;
                }
                dgData.Columns["vProID"].Visible = false;
                dgData.Columns["vSysDocNum"].Visible = false;

                dgData.Columns["vNum"].Width = 55;
                dgData.Columns["vProID"].Width = 150;
                dgData.Columns["vName"].Width = 150;
                dgData.Columns["vCost"].Width = 88;
                dgData.Columns["vOtherCost"].Width = 88;
                dgData.Columns["vQty"].Width = 88;
                dgData.Columns["vDiscount"].Width = 88;
                dgData.Columns["vStock"].Width = 111;
                dgData.Columns["vAmount"].Width = 111;
                dgData.Columns["vExp"].Width = 130;


                dgData.Columns["vCost"].ReadOnly = false;
                dgData.Columns["vOtherCost"].ReadOnly = false;
                dgData.Columns["vQty"].ReadOnly = false;
                dgData.Columns["vDiscount"].ReadOnly = false;
                dgData.Columns["vStock"].ReadOnly = false;


                //txtTypeCode
                this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;


                this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgData.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgData.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }


        bool IsOkCommit()
        {
            try
            {
                if (txtID.Text.Trim() == string.Empty && this.PCode == string.Empty)
                {
                    txtID.Select();
                    txtID.Focus();
                    MessageBox.Show("Purchase Order doesn't exist !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (dgData.Rows.Count<=0)
                {
                    MessageBox.Show("Purchase Order doesn't exist items in list!", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                double vqty = 0;

                DateTime vExpired;
                DateTime vToday;

                DateTime.TryParseExact(DateTime.Today.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out vToday);


                for (int i = 0; i < dgData.Rows.Count; i++)
                {
                    dgData.Rows[i].Selected = false;
                    double.TryParse(dgData["vQty", i].Value.ToString(), out vqty);

                    if (vqty <= 0)
                    {
                        dgData.Rows[i].Selected = true;
                        MessageBox.Show("Please verify your purchase order qty  !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    //DateTime.TryParseExact(dgData["vExp", i].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out vExpired);
                    //if (vExpired <= vToday)
                    //{
                    //    dgData.Rows[i].Selected = true;
                    //    MessageBox.Show("Please verify your purchase expired date  !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return false;
                    //}

                    int vqty_in = 0;
                    string vSysDocNum = dgData["vSysDocNum", i].Value.ToString().Trim();
                    string vProID = dgData["vProID", i].Value.ToString().Trim();
                    string vStock = dgData["vStock", i].Value.ToString().Trim();
                    string vName = dgData["vName", i].Value.ToString().Trim();

                    int.TryParse(dgData["vqty", i].Value.ToString(), out vqty_in);

                    for (int ch01 = 0; ch01 < dgData.Rows.Count; ch01++)
                    {
                        string ch_pro_id = dgData["vProID", ch01].Value.ToString().Trim();

                        if (vProID == ch_pro_id && i != ch01)
                        {
                            MessageBox.Show("duplicate items => : " + vName + "  in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dgData.Rows[i].Selected = true;
                            return false;

                        }

                    }
                }
                
                return true;
            }
            catch
            {
                MessageBox.Show(variables.vMsg_wrong, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        public static bool IsDateBeforeOrToday(string input)
        {
            bool result = true;

            if (input != null)
            {
                DateTime dTCurrent = DateTime.Now;
                int currentDateValues = Convert.ToInt32(dTCurrent.ToString("MMddyyyy"));
                int inputDateValues = Convert.ToInt32(input.Replace("/", ""));

                result = inputDateValues <= currentDateValues;
            }
            else
            {
                result = true;
            }

            return result;
        }

        bool IsOk()
        {
            try
            {
                if (txtID.Text.Trim() == string.Empty && this.PCode == string.Empty)
                {
                    txtID.Select();
                    txtID.Focus();
                    MessageBox.Show("Purchase Order doesn't exist !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (sql.cbo_empty(cboProduct) == false)
                {
                    cboProduct.Select();
                    cboProduct.Focus();
                    MessageBox.Show("Product name doesn't exist !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                return true;
            }
            catch  
            {
                MessageBox.Show(variables.vMsg_wrong, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        void Register_Purchase(string vStatus, string vCode)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vPO_ID", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_auth_po", arr);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(variables.vMsg_PO, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearRecord();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void GetInfor(string vstatus, string vcode)
        {
            try
            {
                txtID.Text = vcode;
                DataTable dt = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vcode
                    };
                dt = sql.proc_getdata("proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    dgData.Rows.Clear();
                    dgData.Enabled = true;
                    this.PCode = dt.Rows[0]["po_id"].ToString();
                    lblInfo.Text = dt.Rows[0]["info"].ToString();
                    load_una_list("show_po_una_list", this.PCode);
                }
            }
            catch { }
        }

        void load_una_list(string vStatus, string vCode)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = this.PCode });
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                dt = sql.Data_Execute("proc_get_sql", arr);
                dgData.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        
                        dgData.Rows.Add((i+1).ToString(),
                                 dt.Rows[i]["sysdocnum"].ToString(),
                                 dt.Rows[i]["pro_code"].ToString(),
                                 dt.Rows[i]["pro_name"].ToString(),
                                 dt.Rows[i]["sto_id"].ToString(),
                                  string.Format("{0:0.00}", Convert.ToDouble(dt.Rows[i]["cost"])),
                                  string.Format("{0:0.00}", Convert.ToDouble(dt.Rows[i]["oth_cost"])),
                                  string.Format("{0:0}", Convert.ToDouble(dt.Rows[i]["qty"])),
                                  string.Format("{0:0}", Convert.ToDouble(dt.Rows[i]["discount"]))+" %",
                                  0,
                                 dt.Rows[i]["exp_date"].ToString()
                                );
                    }

                    calculator();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void add_una_list(string vStatus, string vCode)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vPO_ID", sqltype = SqlDbType.NVarChar, values = this.PCode });
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vPro_ID", sqltype = SqlDbType.NVarChar, values = cboProduct.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vExpired_date", sqltype = SqlDbType.Date, values = vexpired_date.Value });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_PO_add_list", arr);
                if (dt.Rows.Count > 0)
                {
                    load_una_list("show_po_una_list", this.PCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void delete_po_sysdoc()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "PO_D" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vTran_ID", sqltype = SqlDbType.NVarChar, values = PSysDocNum });
                dt = sql.Data_Execute("proc_delete_trans", arr);
                if (dt.Rows.Count > 0)
                {
                    GetInfor("show_po_history", txtID.Text.Trim());
                }
            }
            catch { }
        }

        private void load_data()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                        "stock_menu",
                        variables.PBranchCode
                    };
                dt = sql.proc_getdata("pro_get_combo", p);
                if (dt.Rows.Count > 0)
                {
                    vStock.DataSource = dt;
                    vStock.DisplayMember = "title";
                    vStock.ValueMember = "code";
                }
            }
            catch { }
        }


        private void FrmPurchaseorder_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cboProduct, "exec pro_get_combo_by_branch  'ProductActive','" + variables.PBranchCode + "'", "title", "code");
                load_data();
                GetInfor("show_po_history", this.PCode);
                FormatDataGridview();

                cboProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch { }
        }

        private void _add_list_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk() == true)
                {
                    add_una_list("I", this.PCode);
                }
            }
            catch { }
        }
 

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmPurchaseOrderHistory FRM_SEARCH = new FrmPurchaseOrderHistory();
            FRM_SEARCH.Status = "search_customer";
            FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
            FRM_SEARCH.ShowDialog();
            this.PCode = string.Empty;
            
            if (FRM_SEARCH.Code != string.Empty)
            {
                txtID.Text = FRM_SEARCH.Code.Trim();
                this.PCode = FRM_SEARCH.Code.Trim();
            }
        }

        private void btnUnList_Click(object sender, EventArgs e)
        {
            try
            {

                FrmSearchPO FRM_SEARCH = new FrmSearchPO();
                FRM_SEARCH.Status = "search_po_history";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    txtID.Text = FRM_SEARCH.Code;
                    GetInfor("show_po_history", txtID.Text.Trim());
                }
                else
                {
                    txtID.Text = string.Empty;
                }
                this.Show();
            }
            catch { }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetInfor("show_po_history", txtID.Text.Trim());
            }
        }

        private void _PO_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_po_sysdoc();
            }
            catch { }

        }

        private void _PO_Expired_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditExpired PO = new FrmEditExpired();
                PO.StartPosition = FormStartPosition.CenterParent;
                PO.PCode = PSysDocNum;
                PO.ShowDialog();

                if (PO.Code != string.Empty)
                {
                    GetInfor("show_po_history", txtID.Text.Trim());
                }
                
                this.Show();
            }
            catch { }
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PSysDocNum = dgData["vSysDocNum", e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PSysDocNum = dgData["vSysDocNum", e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void dgData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DialogResult dialogResult = MessageBox.Show(variables.vMsg_AreSure, variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    delete_po_sysdoc();
                }
            }
        }



        private void dgData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string vsysdoc_num = string.Empty;
                string vstockid = string.Empty;
                double vcost = 0;
                double vother_cost = 0;
                double vqty = 0;
                double vdiscount = 0;
                vsysdoc_num = dgData["vSysDocNum", e.RowIndex].Value.ToString();
                vstockid = dgData["vStock", e.RowIndex].Value.ToString();


                double.TryParse(dgData["vCost", e.RowIndex].Value.ToString(), out vcost);
                double.TryParse(dgData["vOtherCost", e.RowIndex].Value.ToString(), out vother_cost);

                double.TryParse(dgData["vQty", e.RowIndex].Value.ToString(), out vqty);
                if (sql.Rights(dgData["vDiscount", e.RowIndex].Value.ToString(), 1) == "%")
                {
                    vdiscount = Convert.ToDouble(sql.Left(dgData["vDiscount", e.RowIndex].Value.ToString(), dgData["vDiscount", e.RowIndex].Value.ToString().Length - 1));
                }
                else
                {
                    vdiscount = Convert.ToDouble(dgData["vDiscount", e.RowIndex].Value);
                }

                edit_una_list("PO_Edit", vsysdoc_num, vstockid, vcost, vother_cost, vdiscount, vqty);
                calculator();
            }
            catch { }
        }

        private void _PO_Commit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOkCommit() == true)
                {
                    Register_Purchase("PO_Commit", this.Code);
                }

            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (Code == string.Empty)
                {
                    _PO_Expired.Enabled = false;
                    _PO_delete.Enabled = false;
                }
                else
                {
                    _PO_Expired.Enabled = true ;
                    _PO_delete.Enabled = true;
                }

            }
            catch { }
        }
    }
}
