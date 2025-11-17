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
        }
        sqlexcute sql = new sqlexcute();
        print_invoice print = new print_invoice();

        double g_totalAmount = 0;
        int vRowsNum = 0;

        string vDraftID = string.Empty;
        string vbarcode = string.Empty;
        string vproductid = string.Empty;
        private bool _hasInitialized = false;


        public string P_RCP_NUM = string.Empty;
        public string P_SysDoc = string.Empty;
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

        private void frmPOS_Shown(object sender, EventArgs e)
        {
            if (!_hasInitialized)
            {
                try
                {
                    ThreadPool.QueueUserWorkItem(state =>
                    {
                        Thread.Sleep(4000); // brief sleep to allow the main thread
                                            // to paint the form nicely
                        this.Invoke((Action)delegate { LoadData(); });
                    });
                }
                catch { }
            }
        }

        void clearText()
        {
            _POS_add_batch.Enabled = false;
            _POS_delete.Enabled = false;
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

 
                cbocustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbocustomer.AutoCompleteSource = AutoCompleteSource.ListItems;

                cboproduct.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboproduct.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch { }
        }

        void cleartext()
        {
            txtinvoice.Text = string.Empty;
            cbocustomer.SelectedValue = string.Empty;
            cboproduct.SelectedValue = string.Empty;

            dgPos.Rows.Clear();

            g_totalAmount = 0;
            vDraftID = string.Empty;
            vbarcode = string.Empty;
            vproductid = string.Empty;
            cbocustomer.SelectedIndex = 0;

            txtexchange.Text = variables.p_exchangerateinfo;
            txtexchange.ReadOnly = true;
            lbltotal.Text = "Total : " + String.Format("{0:0.00}", g_totalAmount).ToString();
            dgPos.Rows.Clear();
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
                dgPos.Columns["vSysdoc"].Width = 30;
                dgPos.Columns["vName"].Width = 250;
                dgPos.Columns["vpro_id"].Width = 250;
                dgPos.Columns["vsto_id"].Width = 200;
                dgPos.Columns["vprice"].Width = 100;
                dgPos.Columns["vqty"].Width = 100;
                dgPos.Columns["vdiscount"].Width = 100;
                dgPos.Columns["vamount"].Width = 150;
                dgPos.Columns["vbatch_id"].Width = 222;

                dgPos.Columns["vSysdoc"].Visible = false;
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
                txtexchange.Text = variables.p_exchangerateinfo;
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
                        "0",
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
                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    this.SysDoc_Code=string.Empty;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgPos.Rows.Add(
                            (i + 1).ToString(),
                                dt.Rows[i]["sysdoc"].ToString(),
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
                if (dgPos.Rows.Count > 25)
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
                        if (sql.Rights(dgPos["gdiscount", i].Value.ToString(), 1) == "%")
                        {
                            Dis = Convert.ToDouble(sql.Left(dgPos["gdiscount", i].Value.ToString(), dgPos["gdiscount", i].Value.ToString().Length - 1));
                        }
                        else
                        {
                            Dis = Convert.ToDouble(dgPos["gdiscount", i].Value);
                        }

                        int.TryParse(dgPos["gqty", i].Value.ToString(), out Qty);
                        double.TryParse(dgPos["gprice", i].Value.ToString(), out Unitprice);
                        double.TryParse(Dis.ToString(), out Discount);
                        double.TryParse(variables.p_exchange_rate.ToString(), out Exchange);

                        Amout = (Qty * Unitprice);
                        TotalAmount = Amout - (Amout * Discount / 100);


                        if (sql.Rights(dgPos["gdiscount", i].Value.ToString(), 1) != "%")
                        {
                            dgPos["gdiscount", i].Value = dgPos["gdiscount", i].Value + "%";
                        }

                        foreach (DataGridViewRow row in dgPos.Rows)
                        {
                            if (row.Index.ToString() == i.ToString())
                                row.Cells[9].Value = TotalAmount;
                        }

                        T_Amount = T_Amount + TotalAmount;
                    }
                    lbltotal.Text = "Total : " + String.Format("{0:0.00}", T_Amount).ToString();
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
                txtexchange.Text = variables.p_exchangerateinfo;
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
                if (dgPos.Rows.Count <=0)
                {
                    MessageBox.Show("No record to POS !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    for (int i = 0; i < dgPos.Rows.Count; i++)
                    {
                        string vbatch_id = dgPos["vbatch_id", i].Value.ToString().Trim();
                        string vpro_id = dgPos["vpro_id", i].Value.ToString().Trim();
                        string vName = dgPos["vName", i].Value.ToString().Trim();

                        dgPos.Rows[i].Selected = false;

                        if (vbatch_id == string.Empty)
                        {
                            for (int ch01 = 0; ch01 < dgPos.Rows.Count; ch01++)
                            {
                                string ch_batch_id = dgPos["vbatch_id", ch01].Value.ToString().Trim();
                                string ch_pro_id = dgPos["vpro_id", ch01].Value.ToString().Trim();

                                if(vpro_id == ch_pro_id && i != ch01)
                                {
                                    MessageBox.Show("Items => : " + vName + " can not double in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    dgPos.Rows[i].Selected = true;

                                    return false;
                                }

                                if (vbatch_id == ch_batch_id && i != ch01 && ch_batch_id!=string.Empty)
                                {
                                    MessageBox.Show("Batch id: " + ch_batch_id + " can not double in list", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    dgPos.Rows[i].Selected = true;

                                    return false;
                                }

                            }
                        }
                        
                    }

                }

                return true;
            }
            catch { return false; }
        }

        private void _POS_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk_commit() == true)
                {

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
                P_SysDoc = dgPos["vSysdoc", e.RowIndex].Value.ToString();

                if (P_SysDoc != string.Empty)
                {
                    _POS_add_batch.Enabled = true;
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_add_batch.Enabled = false;
                    _POS_delete.Enabled = false;
                }
            }
            catch { }
        }

        private void _POS_delete_Click(object sender, EventArgs e)
        {

        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (P_SysDoc != string.Empty)
                {
                    _POS_add_batch.Enabled = true;
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_add_batch.Enabled = false;
                    _POS_delete.Enabled = false;
                }

            }
            catch { }
        }
    }
}
