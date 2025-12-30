using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_TAX.Function
{
    public partial class FrmStockTransfers : KryptonForm
    {
        public FrmStockTransfers()
        {
            InitializeComponent();
            _gTop.Enabled = false; _gTop.TabIndex = 0;

        }
        sqlexcute sql = new sqlexcute();
        modules mod = new modules();

        private bool _hasInitialized = false;

        string vDraftID = string.Empty;
        string vproductid = string.Empty;

        public string P_ST_CODE = string.Empty;
        public string P_SysDoc = string.Empty;
        public string P_Batch_id = string.Empty;
        public string st_code
        {
            get { return P_ST_CODE; }
            set { P_ST_CODE = value; }
        }

        public string SysDoc_Code
        {
            get { return P_SysDoc; }
            set { P_SysDoc = value; }
        }

        public string Batch_id
        {
            get { return P_Batch_id; }
            set { P_Batch_id = value; }
        }


        void cleartext()
        {
            st_code = string.Empty;
            P_ST_CODE = string.Empty;
            SysDoc_Code = string.Empty;
            vDraftID = string.Empty;
            vproductid = string.Empty;

            cboStockFrom.Text = string.Empty;
            cboStockTo.SelectedValue = string.Empty;
            cboProduct.SelectedValue = string.Empty;
           dgPos.Rows.Clear();  
        }

        string DraftStockTransfer(string vstatus)
        {
            try
            {
                if (vDraftID != string.Empty)
                {
                    return vDraftID;
                }
                else
                {
                    DataTable dt = new DataTable();
                    string[] p = {
                        vstatus,
                        variables.PBranchCode,
                        vDraftID,
                        variables.PInputter
                    };
                    dt = sql.proc_getdata("proc_transfer_draft", p);
                    if (dt.Rows.Count > 0)
                    {
                        vDraftID = dt.Rows[0]["trancode"].ToString();
                        return vDraftID;
                    }
                }
                return string.Empty;
            }
            catch { return string.Empty; }
        }
        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgPos.Columns.Count; i++)
                {
                    dgPos.Columns[i].ReadOnly = true;
                }

                dgPos.Columns["vNum"].HeaderText = "Nº";
                dgPos.Columns["vNum"].Width = 44;
                dgPos.Columns["vSysDocNum"].Width = 30;
                dgPos.Columns["vName"].Width = 150;
                dgPos.Columns["vstockFrom"].Width = 100;
                dgPos.Columns["vstockTo"].Width = 100;
                dgPos.Columns["vqty"].Width = 60;
                dgPos.Columns["vqty"].ReadOnly = false;


                dgPos.Columns["vSysDocNum"].Visible = false;
                dgPos.Columns["vst_code_from"].Visible = false;
                dgPos.Columns["vst_code_to"].Visible = false;
                dgPos.Columns["vpro_id"].Visible = false;


                //txtTypeCode
                this.dgPos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgPos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgPos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgPos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgPos.DefaultCellStyle.Font = new Font("Times New Roman", 15F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgPos.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }


        private void LoadData()
        {
            try
            {
                // do the data loading
                _hasInitialized = true;
                sql.Filter_ComboBox(cboStockFrom, "exec proc_get_sql_pos  'stock_menu','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboStockTo, "exec proc_get_sql_pos  'stock_menu','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboProduct, "exec proc_get_sql_pos  'pos_product','" + variables.PBranchCode + "','%'", "name", "code");

                _gTop.Enabled = true;

            }
            catch { }
        }


        private void FrmStockTransfers_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
               
                FormatDataGridview();
            }
            catch { }
        }
        void GetProduct(string vstatus, string vPro_id)
        {
            try
            {
                if (dgPos.Rows.Count > 12)
                {
                    MessageBox.Show("Can't add new product to list , because full list!", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    vDraftID = DraftStockTransfer("transfer_draft");
                    this.st_code = vDraftID;
                    txtId.Text = vDraftID;

                    DataTable dt = new DataTable();
                    string[] p = {
                        vstatus,
                        variables.PBranchCode,
                        vDraftID,
                        cboStockFrom.SelectedValue.ToString(),
                        cboStockTo.SelectedValue.ToString(),
                        cboProduct.SelectedValue.ToString(),
                        cboBatchId.SelectedValue.ToString(),
                    };
                    dt = sql.proc_getdata("proc_transfer_details", p);
                    if (dt.Rows.Count > 0)
                    {
                        draft_list("ts_una_list", vDraftID);
                    }
                }
            }
            catch { }

        }

        void draft_list(string vstatus, string vRcp_num)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] d = {
                        vstatus,
                        variables.PBranchCode,
                        vRcp_num,
                        variables.PInputter
                    };
                dt = sql.proc_getdata("proc_get_sql_pos", d);

                if (dt.Rows.Count > 0)
                {
                    this.SysDoc_Code = string.Empty;
                    st_code = dt.Rows[0]["ts_id"].ToString();
                    vDraftID = dt.Rows[0]["ts_id"].ToString();

                    dgPos.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgPos.Rows.Add(
                            (i + 1).ToString(),
                                dt.Rows[i]["sysdocnum"].ToString(),
                                dt.Rows[i]["pro_id"].ToString(),
                                dt.Rows[i]["sto_from"].ToString(),
                                dt.Rows[i]["sto_to"].ToString(),
                                dt.Rows[i]["pro_name"].ToString(),
                                dt.Rows[i]["sto_from_name"].ToString(),
                                dt.Rows[i]["sto_to_name"].ToString(),
                                String.Format("{0:0}", dt.Rows[i]["qty"]).ToString(),
                                dt.Rows[i]["batch_id"].ToString()
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sql.cbo_empty(cboStockFrom) == false) || (sql.cbo_empty(cboStockTo) == false))
                {
                    cboStockFrom.Select();
                    cboStockFrom.Focus();
                    MessageBox.Show("Please something when wrong stock information !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }else if (cboStockFrom.SelectedValue.ToString() == cboStockTo.SelectedValue.ToString())
                {
                    cboStockFrom.Select();
                    cboStockFrom.Focus();
                    MessageBox.Show("Stock transfer must be defferent !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (sql.cbo_empty(cboProduct) == false)
                {
                    cboProduct.Select();
                    cboProduct.Focus();
                    MessageBox.Show("Product information has bee required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (sql.cbo_empty(cboBatchId) == false)
                {
                    cboProduct.Select();
                    cboProduct.Focus();
                    MessageBox.Show("Batch ID information has bee required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    GetProduct("I", vproductid);
                }
            }
            catch { }
        }

        private void FrmStockTransfers_Shown(object sender, EventArgs e)
        {
            if (!_hasInitialized)
            {
                try
                {
                    ThreadPool.QueueUserWorkItem(state =>
                    {
                        Thread.Sleep(2000); // brief sleep to allow the main thread
                                            // to paint the form nicely
                        this.Invoke((Action)delegate { LoadData(); });
                    });
                }
                catch { }
            }
        }

        void list_product(string vstatus, string vstockcode)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vstatus });
                arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vstockFrom", sqltype = SqlDbType.NVarChar, values = vstockcode });
                arr.Add(new parasql { paraname = "@vstockTo", sqltype = SqlDbType.NVarChar, values = vstockcode });
                dt = sql.Data_Execute("proc_get_sql_transfer", arr);
                if (dt.Rows.Count > 0)
                {

                    cboProduct.DataSource = dt;
                    cboProduct.ValueMember = "code";
                    cboProduct.DisplayMember = "title";
                    cboProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch { }
        }

        void listBatchID(string vstatus, string vstockcode,string vproduct)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vstatus });
                arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vstockFrom", sqltype = SqlDbType.NVarChar, values = vstockcode });
                arr.Add(new parasql { paraname = "@vstockTo", sqltype = SqlDbType.NVarChar, values = "" });
                arr.Add(new parasql { paraname = "@vpro_code", sqltype = SqlDbType.NVarChar, values = vproduct });
                dt = sql.Data_Execute("proc_get_sql_transfer", arr);
                if (dt.Rows.Count > 0)
                {
                    cboBatchId.DataSource = dt;
                    cboBatchId.ValueMember = "code";
                    cboBatchId.DisplayMember = "code";
                    cboBatchId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboBatchId.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch { }
        }

        private void cboStockFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cboStockFrom) == true) 
                {
                    list_product("get_product", cboStockFrom.SelectedValue.ToString());
                }

            }
            catch { }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sql.cbo_empty(cboProduct) == true) && (sql.cbo_empty(cboStockFrom) == true))
                {
                    listBatchID("get_batch_id", cboStockFrom.SelectedValue.ToString() , cboProduct.SelectedValue.ToString());
                }

            }
            catch { }
        }

        private void dgPos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                P_SysDoc = dgPos["vSysDocNum", e.RowIndex].Value.ToString();
                P_Batch_id = dgPos["vbatch_id", e.RowIndex].Value.ToString();

                if (P_SysDoc != string.Empty)
                {
                    _POS_merch_batch.Enabled = true;
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_merch_batch.Enabled = false;
                    _POS_delete.Enabled = false;
                }
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (P_SysDoc != string.Empty)
                {
                    _POS_merch_batch.Enabled = true;
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_merch_batch.Enabled = false;
                    _POS_delete.Enabled = false;
                }

                if (P_Batch_id == string.Empty)
                {
                    _POS_merch_batch.Enabled = false;
                }

            }
            catch { }
        }


        void edit_list(string vStatus, string vSysDoc, string vbatch_id, double vqty)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vSysDoc", sqltype = SqlDbType.NVarChar, values = vSysDoc });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vbatch_id", sqltype = SqlDbType.NVarChar, values = vbatch_id });
                arr.Add(new parasql { paraname = "@vqty", sqltype = SqlDbType.NVarChar, values = vqty });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });

                dt = sql.Data_Execute("proc_stocktransfer_edit", arr);
            }
            catch { }
        }

        private void dgPos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string vsysdoc_num = string.Empty;
                string vbatch_id = string.Empty;
                double vqty = 0;
                vsysdoc_num = dgPos["vSysDocNum", e.RowIndex].Value.ToString();
                vbatch_id = dgPos["vbatch_id", e.RowIndex].Value.ToString();
                double.TryParse(dgPos["vqty", e.RowIndex].Value.ToString(), out vqty);

                edit_list("stock_edit_row", vsysdoc_num, vbatch_id, vqty);
            }
            catch { }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                draft_list("ts_una_list", txtId.Text.Trim());
            }
        }

        bool IsOk_commit()
        {
            try
            {

                if (this.st_code == string.Empty)
                {
                    MessageBox.Show("Stock transfer processing failed !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (dgPos.Rows.Count <= 0)
                {
                    MessageBox.Show("No record for transfer to stock !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    for (int i = 0; i < dgPos.Rows.Count; i++)
                    {
                        int vqty = 0;
                        string vbatch_id = dgPos["vbatch_id", i].Value.ToString().Trim();
                        string vpro_id = dgPos["vpro_id", i].Value.ToString().Trim();
                        string vst_code_from = dgPos["vst_code_from", i].Value.ToString().Trim();
                        string vName = dgPos["vName", i].Value.ToString().Trim();
                        string vsysdocnum = dgPos["vSysDocNum", i].Value.ToString().Trim();

                        int.TryParse(dgPos["vqty", i].Value.ToString(), out vqty);
                        dgPos.Rows[i].Selected = false;

                        if (vbatch_id == string.Empty)
                        {
                            MessageBox.Show(" Field 'Batch id' must be filled in list ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dgPos.Rows[i].Selected = true;
                            return false;
                        }

                        for (int ch01 = 0; ch01 < dgPos.Rows.Count; ch01++)
                        {
                            string ch_batch_id = dgPos["vbatch_id", ch01].Value.ToString().Trim();
                            string ch_pro_id = dgPos["vpro_id", ch01].Value.ToString().Trim();
                            string ch_sto_id = dgPos["vst_code_from", ch01].Value.ToString().Trim();

                            if (vpro_id == ch_pro_id && i != ch01)
                            {
                                MessageBox.Show("Product Name : " + vName + " can not double in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                dgPos.Rows[i].Selected = true;
                                return false;
                            }
                        }

                        float vqty_in_stock = mod.pos_get_qty("pos_una_qty", vsysdocnum, vpro_id, vst_code_from, vbatch_id);
                        if (vqty_in_stock < vqty)
                        {
                            dgPos.Rows[i].Selected = true;
                            MessageBox.Show("Product in list qty only : " + vqty_in_stock, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch { return false; }
        }

        void delete_po_sysdoc()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "ST_D" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vTran_ID", sqltype = SqlDbType.NVarChar, values = SysDoc_Code });
                dt = sql.Data_Execute("proc_delete_trans", arr);
                if (dt.Rows.Count > 0)
                {
                    draft_list("ts_una_list", st_code);

                }
            }
            catch { }
        }

        void action_commit(string vStatus, string vCode)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vts_ID", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_auth_stock_transfer", arr);

                if (dt.Rows.Count > 0)
                {
                    st_code = dt.Rows[0]["TRANCODE"].ToString();
                    vDraftID = st_code;
                    txtId.Text= st_code;

                    MessageBox.Show(variables.vMsg_ST, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartext();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void _POS_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk_commit() == true)
                {
                    action_commit("ts_commit", this.st_code);
                }
            }
            catch { }
        }

        private void _POS_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_po_sysdoc();
            }
            catch { }
        }
    }
}
