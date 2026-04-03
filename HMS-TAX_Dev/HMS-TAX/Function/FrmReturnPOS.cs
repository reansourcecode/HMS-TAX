using ComponentFactory.Krypton.Toolkit;
using ExcelLibrary.BinaryFileFormat;
using HMS_TAX.HMS;
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
using System.Xml.Linq;

namespace HMS_TAX.Function
{
    public partial class FrmReturnPOS : KryptonForm
    {
        public FrmReturnPOS()
        {
            InitializeComponent();
            _gTop.Enabled = false; _gTop.TabIndex = 0;

        }

        sqlexcute sql = new sqlexcute();
        modules mod = new modules();

        private bool _hasInitialized = false;

        public string PStatus = string.Empty;
        public string PReinvoice = string.Empty;
        public string PReferentCode = string.Empty;
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

        public string ReInvoiceCode
        {
            get { return PReinvoice; }
            set { PReinvoice = value; }
        }

        public string ReferentCode
        {
            get { return PReferentCode; }
            set { PReferentCode = value; }
        }
        void clearRecord()
        {
            txtInvoice.Text = string.Empty;
            txtInvoiceReturn.Text = string.Empty;
            txtName.Text = string.Empty;
            txtInfo.Text = string.Empty;
            dgPos.Rows.Clear(); 

            txtInvoice.Enabled = true;
            txtInvoiceReturn.Enabled = true;
            txtName.Enabled = false;
            txtInfo.Enabled = false;
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
                dgPos.Columns["vName"].Width = 222;
                dgPos.Columns["vpro_id"].Width = 250;
                dgPos.Columns["vsto_id"].Width = 100;
                dgPos.Columns["vprice"].Width = 55;
                dgPos.Columns["vqty"].Width = 55;
                dgPos.Columns["vdiscount"].Width = 88;
                dgPos.Columns["vamount"].Width = 150;
                dgPos.Columns["vbatch_id"].Width = 111;

                dgPos.Columns["vSysDocNum"].Visible = false;
                dgPos.Columns["vpro_id"].Visible = false;

                dgPos.Columns["vsto_id"].ReadOnly = false;
                dgPos.Columns["vprice"].ReadOnly = false;
                dgPos.Columns["vqty"].ReadOnly = false;
                dgPos.Columns["vdiscount"].ReadOnly = false;

                //txtTypeCode
                this.dgPos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgPos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgPos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgPos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgPos.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgPos.DefaultCellStyle.ForeColor = Color.Black;
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
                        variables.pos_flag
                    };
                dt = sql.proc_getdata("proc_get_sql_pos", d);

                if (dt.Rows.Count > 0)
                {
                    this.SysDocNum = string.Empty;
                    dgPos.Rows.Clear();

                    PReferentCode = dt.Rows[0]["referent"].ToString().Trim();
                    PReinvoice = dt.Rows[0]["rcp_num"].ToString().Trim();
                    txtInvoice.Text = dt.Rows[0]["rcp_num"].ToString();
                    txtInvoiceReturn.Text = dt.Rows[0]["referent"].ToString();
                    txtName.Text = dt.Rows[0]["cus_name"].ToString();
                    txtInfo.Text = dt.Rows[0]["info"].ToString();

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
                                String.Format("{0:0}", dt.Rows[i]["discount"]).ToString() + " %",
                                String.Format("{0:0.00}", dt.Rows[i]["amount"]).ToString(),
                                String.Format("{0:0.00}", dt.Rows[i]["batch_id"]).ToString()
                            );
                    }


                    txtInvoiceReturn.Enabled = false;
                    txtName.Enabled = false;
                    txtInfo.Enabled = false;

                    calculator();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        void return_pos(string vStatus, string vcode)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vPOS_ID", sqltype = SqlDbType.NVarChar, values = vcode });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_return_pos", arr);

                if (dt.Rows.Count > 0)
                {
                    clearRecord();

                    PReinvoice= dt.Rows[0]["rcp_num"].ToString();
                    draft_list("rcp_get_return", PReinvoice);
                }
            }
            catch { }
        }

        void GetInfor(string vstatus, string vcode)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vcode
                    };
                dt = sql.proc_getdata("proc_get_sql_pos", p);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["status"].ToString() == "YES")
                    {
                        MessageBox.Show("Invoice already existing processing returns!", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Do you want to return :" + vcode + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        return_pos("POS_Return", vcode);
                    }
                }
                else {                    
                    MessageBox.Show("Invoice not found!", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearRecord();
                }
            }
            catch { }
        }


        private void LoadData()
        {
            try
            {
                // do the data loading
                _hasInitialized = true;

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

                _gTop.Enabled = true;

            }
            catch { }
        }

        void delete_pos_sysdoc()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "POS_D" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vTran_ID", sqltype = SqlDbType.NVarChar, values = SysDocNum });
                dt = sql.Data_Execute("proc_delete_trans", arr);
                if (dt.Rows.Count > 0)
                {
                    draft_list("rcp_get_return", PReinvoice);
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
                    lbltotal.Text = "                 Total : " + String.Format("{0:0.00}", T_Amount).ToString();
                }
            }
            catch { }
        }

        private void FrmReturnPOS_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;

                FormatDataGridview();
            }
            catch { }
        }

        private void _clear_Click(object sender, EventArgs e)
        {
            clearRecord();
        }

        private void txtInvoiceReturn_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
              
            }
            catch { }
        }

        private void txtInvoiceReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    GetInfor("rcp_ch_exists", txtInvoiceReturn.Text.Trim());
                }

            }
            catch { }
        }

        private void FrmReturnPOS_Shown(object sender, EventArgs e)
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

        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                draft_list("rcp_get_return", txtInvoice.Text.Trim());
            }
        }

        private void _draft_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchPOS FRM_SEARCH = new FrmSearchPOS();
                FRM_SEARCH.Status = "search_pos_rcp_re";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    this.PReinvoice = FRM_SEARCH.Code;
                    draft_list("rcp_get_return", this.PReinvoice);
                }
                else
                {
                    this.PReinvoice = string.Empty;
                    this.SysDocNum = string.Empty;
                    draft_list("rcp_get_return", this.PReinvoice);
                }
                this.Show();
            }
            catch { }
        }

        private void dgPos_Click(object sender, EventArgs e)
        {
             
        }

        private void dgPos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PSysDocNum = dgPos["vSysDocNum", e.RowIndex].Value.ToString();

                if (PSysDocNum != string.Empty)
                {
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_delete.Enabled = false;
                }
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (PSysDocNum != string.Empty)
                {
                    _POS_delete.Enabled = true;
                }
                else
                {
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



        void edit_pos_list(string vStatus, string vSysDoc, string vbatch_id, string vsto_id, double vprice, double vdis, double vqty)
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



        bool IsOk_commit()
        {
            try
            {

                if (this.PReinvoice == string.Empty)
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

                        float vqty_pos = mod.pos_get_qty("pos_return_qty", PReferentCode, vpro_id, vsto_id, vbatch_id);
                        if (vqty_pos < vqty)
                        {
                            dgPos.Rows[i].Selected = true;
                            MessageBox.Show("Product in list sold out only : " + vqty_pos, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch { return false; }
        }

        private void _POS_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk_commit() == true)
                {
                    DataTable dts = new DataTable();
                    List<parasql> arr = new List<parasql>();
                    arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "rcp_commit_re" });
                    arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                    arr.Add(new parasql { paraname = "@vPOS_ID", sqltype = SqlDbType.NVarChar, values = PReinvoice });
                    arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                    arr.Add(new parasql { paraname = "@vCus_ID", sqltype = SqlDbType.NVarChar, values = PReferentCode });
                    dts = sql.Data_Execute("proc_auth_pos", arr);

                    if (dts.Rows.Count > 0)
                    {
                        
                        txtInvoice.Text = dts.Rows[0]["trancode"].ToString();
                        MessageBox.Show("POS successfully ! , invoice : " + dts.Rows[0]["trancode"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearRecord();
                    }
                }
            }
            catch { }
        }

        private void _invoice_Click(object sender, EventArgs e)
        {

        }
    }
}
