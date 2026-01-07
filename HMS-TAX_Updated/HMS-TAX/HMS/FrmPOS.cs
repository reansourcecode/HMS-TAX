using ComponentFactory.Krypton.Toolkit;
using DevComponents.AdvTree;
using HMS_TAX.Function;
using HMS_TAX.UserDefined;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS_TAX.HMS
{
    public partial class FrmPOS : KryptonForm
    {
        public FrmPOS()
        {
            InitializeComponent();
            _gTop.Enabled=false; _gTop.TabIndex=0;
        }
        sqlexcute sql = new sqlexcute();
        print_invoice print = new print_invoice();
        modules mod = new modules();    

        double g_totalAmount = 0;
        string vDraftID = string.Empty;
        string vproductid = string.Empty;
        private bool _hasInitialized = false;


        public string P_RCP_NUM = string.Empty;
        public string P_SysDoc = string.Empty;
        public string P_Batch_id = string.Empty;
        public string RCP_Code
        {
            get { return P_RCP_NUM; }
            set { P_RCP_NUM = value; }
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
            RCP_Code = string.Empty;
            P_RCP_NUM = string.Empty;
            SysDoc_Code = string.Empty;
            vDraftID = string.Empty;
            vproductid = string.Empty;

            txtinvoice.Text = string.Empty;
            cbocustomer.SelectedValue = string.Empty;
            cboproduct.SelectedValue = string.Empty;

            g_totalAmount = 0;

            cbocustomer.SelectedIndex = -1;
            cbocustomer.Text = "";

            lblRate.Text = "       " + variables.p_exchangerateinfo;
            lbltotal.Text = "        Total : " + String.Format("{0:0.00}", g_totalAmount).ToString();
            dgPos.Rows.Clear();
            _POS_add_batch.Enabled = false;
            _POS_delete.Enabled = false;


            if (variables.pos_flag == "0")
            {
                lblRunning.Text = "      POS Mode : Sales (TI)";
            }
            else
            {
                lblRunning.Text = "      POS Mode : Sales ( CI )";
            }
        }
        private void frmPOS_Shown(object sender, EventArgs e)
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
 

        private void LoadData()
        {
            try
            {
                // do the data loading
                _hasInitialized = true;
                sql.Filter_ComboBox(cboproduct, "exec proc_get_sql_pos  'pos_product','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cbocustomer, "exec proc_get_sql_pos  'pos_customer','" + variables.PBranchCode + "','%'", "name", "code");


                DataTable dt = new DataTable();
                string[] p = {
                        "stock_menu",
                        variables.PBranchCode
                    };
                dt = sql.proc_getdata("pro_get_combo", p);
                if (dt.Rows.Count > 0)
                {
                    vsto_id.DataSource = dt;
                    vsto_id.DisplayMember = "title";
                    vsto_id.ValueMember = "code";
                }

 
                cbocustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbocustomer.AutoCompleteSource = AutoCompleteSource.ListItems;

                cboproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboproduct.AutoCompleteSource = AutoCompleteSource.ListItems;

 

                _gTop.Enabled = true;

            }
            catch { }
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
                dgPos.Columns["vNum"].Width = 30;
                dgPos.Columns["vSysDocNum"].Width = 30;
                dgPos.Columns["vName"].Width = 250;
                dgPos.Columns["vpro_id"].Width = 250;
                dgPos.Columns["vsto_id"].Width = 155;
                dgPos.Columns["vprice"].Width = 66;
                dgPos.Columns["vqty"].Width = 66;
                dgPos.Columns["vdiscount"].Width = 88;
                dgPos.Columns["vamount"].Width = 150;
                dgPos.Columns["vbatch_id"].Width = 222;

                dgPos.Columns["vSysDocNum"].Visible = false;
                dgPos.Columns["vpro_id"].Visible = false;

                dgPos.Columns["vsto_id"].ReadOnly = false;
                dgPos.Columns["vprice"].ReadOnly = false;
                dgPos.Columns["vqty"].ReadOnly = false;
                dgPos.Columns["vdiscount"].ReadOnly = false;

                //txtTypeCode
                this.dgPos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgPos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgPos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgPos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgPos.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgPos.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }
        private void FrmPOS_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.exchangerate("exchangerate");
                lblRate.Text = "      "+variables.p_exchangerateinfo;
                FormatDataGridview();
                cleartext();
            }
            catch { }
        }

        string DraftInvoice(string vstatus)
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
                        cbocustomer.SelectedValue.ToString(),
                        variables.pos_flag,
                        variables.PInputter
                    };
                    dt = sql.proc_getdata("proc_reg_draft", p);
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
                    dgPos.Rows.Clear();
                    this.SysDoc_Code=string.Empty;
                    cbocustomer.SelectedValue = dt.Rows[0]["cus_id"].ToString();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgPos.Rows.Add(
                            (i + 1).ToString(),
                                dt.Rows[i]["sysdocnum"].ToString(),
                                dt.Rows[i]["pro_name"].ToString(),
                                dt.Rows[i]["pro_code"].ToString(),
                                dt.Rows[i]["sto_id"].ToString(),
                                String.Format("{0:0.0}", dt.Rows[i]["unitprice"]).ToString(),
                                dt.Rows[i]["qty"].ToString(),
                                String.Format("{0:0}", dt.Rows[i]["discount"]).ToString() +" %",
                                String.Format("{0:0.00}", dt.Rows[i]["amount"]).ToString(),
                                String.Format("{0:0.00}", dt.Rows[i]["batch_id"]).ToString()
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    vDraftID = DraftInvoice("pos_draft");
                    this.RCP_Code = vDraftID;

                    DataTable dt = new DataTable();
                    string[] p = {
                        vstatus,
                        variables.PBranchCode,
                        vDraftID,
                        vPro_id
                    };
                    dt = sql.proc_getdata("proc_reg_draft_trans", p);
                    if (dt.Rows.Count > 0)
                    {
                        draft_list("pos_una_list", vDraftID);
                    }
                    else
                    {
                        MessageBox.Show("Product Name :" + cboproduct.Text + " , No product in stock ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }

        }
        void calculator()
        {
            try
            {
                if (dgPos.Rows.Count > 0)
                {
                    int Qty = 0;
                    double Exchange = 0;
                    double Unitprice = 0;
                    double Discount = 0;
                    double Amout = 0;
                    double TotalAmount = 0;
                    double T_Amount = 0;
                    double Dis = 0;

                    for (int i = 0; i < dgPos.Rows.Count; i++)
                    {
                        if (sql.Rights(dgPos["vdiscount", i].Value.ToString(), 1) == "%")
                        {
                            Dis = Convert.ToDouble(sql.Left(dgPos["vdiscount", i].Value.ToString(), dgPos["vdiscount", i].Value.ToString().Length - 1));
                        }
                        else
                        {
                            Dis = Convert.ToDouble(dgPos["vdiscount", i].Value);
                        }

                        int.TryParse(dgPos["vqty", i].Value.ToString(), out Qty);
                        double.TryParse(dgPos["vprice", i].Value.ToString(), out Unitprice);
                        double.TryParse(Dis.ToString(), out Discount);
                        double.TryParse(variables.p_exchange_rate.ToString(), out Exchange);

                        Amout = (Qty * Unitprice);
                        TotalAmount = Amout - (Amout * Discount / 100);


                        if (sql.Rights(dgPos["vdiscount", i].Value.ToString(), 1) != "%")
                        {
                            dgPos["vdiscount", i].Value = dgPos["vdiscount", i].Value + " %";
                        }

                        foreach (DataGridViewRow row in dgPos.Rows)
                        {
                            if (row.Index.ToString() == i.ToString())
                                row.Cells[8].Value = TotalAmount;
                        }

                        T_Amount = T_Amount + TotalAmount;
                    }
                    lbltotal.Text = "       Total : " + String.Format("{0:0.00}", T_Amount).ToString();
                }
            }
            catch { }
        }


        private void _AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cboproduct) == false) 
                {
                    cboproduct.Select();
                    cboproduct.Focus();
                    MessageBox.Show("Please modify product information !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (sql.cbo_empty(cbocustomer) == false)
                {
                    cbocustomer.Select();
                    cbocustomer.Focus();
                    MessageBox.Show("Customer information has bee required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    GetProduct("pos_product", vproductid);
                }
            }
            catch { }
        }

        private void cboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vproductid = string.Empty;

                if ((cboproduct.SelectedValue == null) || string.IsNullOrEmpty(cboproduct.Text))
                {
                    return;
                }
                else
                {
                    vproductid= cboproduct.SelectedValue.ToString();
                }
            }
            catch { }
        }


        bool IsOk_commit()
        {
            try
            {

                if (this.RCP_Code == string.Empty)
                {
                    MessageBox.Show("POS processing failed !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (dgPos.Rows.Count <= 0)
                {
                    MessageBox.Show("No record to POS !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    for (int i = 0; i < dgPos.Rows.Count; i++)
                    {
                        int vqty = 0;
                        string vbatch_id = dgPos["vbatch_id", i].Value.ToString().Trim();
                        string vpro_id = dgPos["vpro_id", i].Value.ToString().Trim();
                        string vsto_id = dgPos["vsto_id", i].Value.ToString().Trim();
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
                        
                        if (vbatch_id == string.Empty)
                        {
                            for (int ch01 = 0; ch01 < dgPos.Rows.Count; ch01++)
                            {
                                string ch_batch_id = dgPos["vbatch_id", ch01].Value.ToString().Trim();
                                string ch_pro_id = dgPos["vpro_id", ch01].Value.ToString().Trim();

                                if (vpro_id == ch_pro_id && i != ch01)
                                {
                                    MessageBox.Show("Items => : " + vName + " can not double in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    dgPos.Rows[i].Selected = true;
                                    return false;

                                }

                                if (vbatch_id == ch_batch_id && i != ch01 && ch_batch_id != string.Empty)
                                {
                                    MessageBox.Show("Batch id: " + ch_batch_id + " can not double in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    dgPos.Rows[i].Selected = true;
                                    return false;
                                }                           

                            }
                        }
                        else
                        {
                            for (int ch01 = 0; ch01 < dgPos.Rows.Count; ch01++)
                            {
                                string ch_batch_id = dgPos["vbatch_id", ch01].Value.ToString().Trim();
                                string ch_pro_id = dgPos["vpro_id", ch01].Value.ToString().Trim();
                                string ch_sto_id = dgPos["vsto_id", ch01].Value.ToString().Trim();

                                if ((vbatch_id == ch_batch_id && i != ch01) && (vpro_id == ch_pro_id && vsto_id == ch_sto_id))
                                {
                                    MessageBox.Show("Batch id: " + ch_batch_id + " can not double in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    dgPos.Rows[i].Selected = true;
                                    return false;
                                }
                            }
                        }

                        float vqty_in_stock=  mod.pos_get_qty("pos_una_qty", vsysdocnum, vpro_id, vsto_id, vbatch_id);
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


        void delete_pos_sysdoc()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "POS_D" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vTran_ID", sqltype = SqlDbType.NVarChar, values = P_SysDoc });
                dt = sql.Data_Execute("proc_delete_trans", arr);
                if (dt.Rows.Count > 0)
                {
                    draft_list("pos_una_list", vDraftID);
                }
            }
            catch { }
        }
        private void _POS_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk_commit() == true)
                {
                    DataTable dts = new DataTable();
                    List<parasql> arr = new List<parasql>();
                    arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "rcp_commit" });
                    arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                    arr.Add(new parasql { paraname = "@vPOS_ID", sqltype = SqlDbType.NVarChar, values = vDraftID });
                    arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                    arr.Add(new parasql { paraname = "@vCus_ID", sqltype = SqlDbType.NVarChar, values = cbocustomer.SelectedValue.ToString() });
                    dts = sql.Data_Execute("proc_auth_pos", arr);

                    if (dts.Rows.Count > 0)
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            string[] p = {
                                    "pos_generate",
                                    variables.PBranchCode,
                                    dts.Rows[0]["trancode"].ToString()
                                };
                            dt = sql.proc_getdata("proc_generate_pos", p);

                            if (MessageBox.Show("Do you want to print reciept ", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                print.PrintExcelFile("una_print", dts.Rows[0]["trancode"].ToString(),variables.pos_flag);
                            }
                        }
                        catch { }
                        txtinvoice.Text = dts.Rows[0]["trancode"].ToString();
                        MessageBox.Show("POS successfully ! , invoice : "+ dts.Rows[0]["trancode"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartext();
                    }
                }
            }
            catch { }
        }

        private void _POS_add_batch_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPOSBatchID batchID = new FrmPOSBatchID();
                batchID.Status = "pos_batchID";
                batchID.StartPosition = FormStartPosition.CenterParent;
                batchID.PCode = SysDoc_Code;
                batchID.PSysDocNum = SysDoc_Code;
                batchID.ShowDialog();

                if (SysDoc_Code != string.Empty)
                {
                    draft_list("pos_una_list", vDraftID);
                }
                else
                {
                    SysDoc_Code = string.Empty;
                }
                this.Show();
            }
            catch { }
        }

        private void dgPos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                P_SysDoc = dgPos["vSysDocNum", e.RowIndex].Value.ToString();
                P_Batch_id = dgPos["vbatch_id", e.RowIndex].Value.ToString();

                if (P_SysDoc != string.Empty)
                {
                    _POS_add_batch.Enabled = true;
                    _POS_merch_batch.Enabled = true;
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_add_batch.Enabled = false;
                    _POS_merch_batch.Enabled = false;
                    _POS_delete.Enabled = false;
                }
            }
            catch { }
        }

        private void _POS_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_pos_sysdoc();
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (P_SysDoc != string.Empty)
                {
                    _POS_add_batch.Enabled = true;
                    _POS_merch_batch.Enabled = true;
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_add_batch.Enabled = false;
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

        void edit_pos_list(string vStatus, string vSysDoc,string vbatch_id, string vsto_id, double vprice, double vdis, double vqty)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vSysDoc", sqltype = SqlDbType.NVarChar, values = vSysDoc });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vbatch_id", sqltype = SqlDbType.NVarChar, values = vbatch_id });
                arr.Add(new parasql { paraname = "@vsto_ID", sqltype = SqlDbType.NVarChar, values = vsto_id });
                arr.Add(new parasql { paraname = "@vprice", sqltype = SqlDbType.NVarChar, values = vprice });
                arr.Add(new parasql { paraname = "@vdis", sqltype = SqlDbType.NVarChar, values = vdis });
                arr.Add(new parasql { paraname = "@vqty", sqltype = SqlDbType.NVarChar, values = vqty });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });

                dt = sql.Data_Execute("proc_pos_edit_list", arr);
            }
            catch { }
        }

        private void dgPos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string vsysdoc_num = string.Empty;
                string vsto_id = string.Empty;
                string vbatch_id = string.Empty;
                double vunitprice = 0;
                double vqty = 0;
                double vdiscount = 0;
                vsysdoc_num = dgPos["vSysDocNum", e.RowIndex].Value.ToString();
                vsto_id = dgPos["vsto_id", e.RowIndex].Value.ToString();
                vbatch_id = dgPos["vbatch_id", e.RowIndex].Value.ToString();


                double.TryParse(dgPos["vprice", e.RowIndex].Value.ToString(), out vunitprice);
                double.TryParse(dgPos["vqty", e.RowIndex].Value.ToString(), out vqty);

                if (sql.Rights(dgPos["vdiscount", e.RowIndex].Value.ToString(), 1) == "%")
                {
                    vdiscount = Convert.ToDouble(sql.Left(dgPos["vdiscount", e.RowIndex].Value.ToString(), dgPos["vdiscount", e.RowIndex].Value.ToString().Length - 1));
                }
                else
                {
                    vdiscount = Convert.ToDouble(dgPos["vdiscount", e.RowIndex].Value);
                }

                edit_pos_list("pos_edit_row", vsysdoc_num, vbatch_id, vsto_id, vunitprice, vdiscount, vqty);
                calculator();
            }
            catch { }
        }

        private void _draft_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchPOS FRM_SEARCH = new FrmSearchPOS();
                FRM_SEARCH.Status = "search_pos_rcp";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    this.vDraftID = FRM_SEARCH.Code;
                    this.RCP_Code = FRM_SEARCH.Code;
                    draft_list("pos_una_list", vDraftID);
                }
                else
                {
                    vDraftID = string.Empty;
                    this.RCP_Code = string.Empty;
                    draft_list("pos_una_list", vDraftID);
                }
                this.Show();
            }
            catch { }
        }

        private void _Customer_Click(object sender, EventArgs e)
        {
            try
            {

                FrmSearchCustomer FRM_SEARCH = new FrmSearchCustomer();
                FRM_SEARCH.Status = "search_customer";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();
                if (FRM_SEARCH.Code != string.Empty)
                {
                    cbocustomer.SelectedValue = FRM_SEARCH.Code;
                }
                this.Show();
            }
            catch { }
        }

        private void _POS_merch_batch_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(variables.vMsg_AreMerch, variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    List<parasql> arr = new List<parasql>();
                    arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "merch_batch_id" });
                    arr.Add(new parasql { paraname = "@vSysDoc", sqltype = SqlDbType.NVarChar, values = SysDoc_Code });
                    arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                    arr.Add(new parasql { paraname = "@vbatch_id", sqltype = SqlDbType.NVarChar, values = P_Batch_id });

                    dt = sql.Data_Execute("proc_pos_merch_batch_id", arr);

                    if (dt.Rows.Count > 0)
                    {
                        draft_list("pos_una_list", vDraftID);
                    }
                }

            }
            catch { }
        }

        private void Function_Click(object sender, EventArgs e)
        {

        }

        private void _exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _invoice_Click(object sender, EventArgs e)
        {

        }

        private void dgPos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DialogResult dialogResult = MessageBox.Show(variables.vMsg_AreSure, variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    delete_pos_sysdoc();
                }
            }
        }
    }
}
