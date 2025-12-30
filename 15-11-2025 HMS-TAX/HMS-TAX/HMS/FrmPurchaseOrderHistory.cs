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

namespace HMS_TAX.HMS
{
    public partial class FrmPurchaseOrderHistory : KryptonForm
    {
        public FrmPurchaseOrderHistory()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vcode = string.Empty;
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

        void cleartext()
        {

            txtID.Text = string.Empty;
            txtRemark.Text = string.Empty;
            cboSupply.Text = string.Empty;
            cboSupply.SelectedValue = "";

            this.Code = string.Empty;
            this.PCode=string.Empty;

            DateTime today = DateTime.Today;
            po_date.Value = today;
        }

        void btn_save_record()
        {
            btnNew.Enabled = true;
            btnCommit.Enabled = true;
        }
        
        void btn_edit_record()
        {
            btnNew.Enabled = true;
            btnCommit.Enabled = false;
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

                dgData.Columns["vPO_ID"].Width = 133;
                dgData.Columns["vSupply"].Width = 133;
                dgData.Columns["vDate"].Width = 99;
                dgData.Columns["vRemark"].Width = 150;

                //txtTypeCode
                //this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                //dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
                //this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                //dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgData.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgData.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }


        bool IsOk()
        {
            if (sql.cbo_empty(cboSupply) == false)
            {
                cboSupply.Select();
                cboSupply.Focus();
                MessageBox.Show("Supplier name has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }


        void Register(string vStatus, string vCode, string vMsg)
        {
            try
            {

                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vpo_id", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vsup_id", sqltype = SqlDbType.NVarChar, values = cboSupply.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vpo_date", sqltype = SqlDbType.Date, values = po_date.Value});
                arr.Add(new parasql { paraname = "@vRemark", sqltype = SqlDbType.NVarChar, values = txtRemark.Text.Trim() });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_register_po", arr);
                if (dt.Rows.Count > 0)
                {
                    this.Code = dt.Rows[0]["TRANCODE"].ToString();
                    MessageBox.Show("New PO ID: " + this.Code, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cleartext();
                    load_view("search_po_history", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        void Delete_PO_History(string vStatus, string vCode)
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
                    cleartext();
                    load_view("search_po_history", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void view_record(string vstatus, string vCode)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vCode
                    };
                dblist = sql.proc_getdata("proc_get_sql_pos", p);
                if (dblist.Rows.Count > 0)
                {
                     cboSupply.SelectedValue = dblist.Rows[0]["sup_id"].ToString();
                     po_date.Value = DateTime.Parse(dblist.Rows[0]["po_date"].ToString()) ;
                    txtRemark.Text = dblist.Rows[0]["remark"].ToString();

                }
            }
            catch { }
        }


        void load_view(string vstatus, string vSearch)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vSearch
                    };
                dgData.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql_search", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgData.Rows.Add(
                            dblist.Rows[i]["po_id"].ToString(),
                            dblist.Rows[i]["sup_name"].ToString(),
                            dblist.Rows[i]["po_date"].ToString(),
                            dblist.Rows[i]["remark"].ToString(),
                            dblist.Rows[i]["status"].ToString()
                        );
                    }
                }
            }
            catch { }
        }


        private void FrmPurchaseOrderHistory_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cboSupply, "exec pro_get_combo_by_branch  'SupplyActive','" + variables.PBranchCode + "'", "title", "code");
                cleartext();
                FormatDataGridview();

                load_view("search_po_history","");
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                cleartext();
                btn_save_record();
            }
            catch { }
        }

       

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk() == true)
                {
                    if (PCode == string.Empty)
                    {
                        Register("I", "", variables.vMsg_insert);
                    }
                    else
                    {
                        Register("E", PCode, variables.vMsg_update);
                    }
                }
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void _PurchaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPurchaseorder PO = new FrmPurchaseorder();
                PO.Status = "search_po_history";
                PO.StartPosition = FormStartPosition.CenterParent;
                PO.PCode = PCode;
                PO.ShowDialog();
                if (PO.Code != string.Empty)
                {
                     
                }
                else
                {
                    txtID.Text = string.Empty;
                }
                this.Show();
            }
            catch { }
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgData[0, e.RowIndex].Value.ToString();
                txtID.Text = PCode;
                view_record("view_po", PCode);

            }
            catch { }
        }

        private void _PO_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete_PO_History("PO_History_D",this.PCode);
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (Code == string.Empty)
                {
                    _PurchaseOrder.Enabled = false;
                    _PO_delete.Enabled = false;
                }
                else
                {
                    _PurchaseOrder.Enabled = true;
                    _PO_delete.Enabled = true;
                }

            }
            catch { }
        }
    }
}
