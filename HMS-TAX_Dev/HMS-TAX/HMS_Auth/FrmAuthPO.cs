using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;

namespace HMS_TAX.HMS_Auth
{
    public partial class FrmAuthPO : KryptonForm
    {
        public FrmAuthPO()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();

        public string PStatus = string.Empty;
        public string PCode = string.Empty;
        
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
            txtid.Text = string.Empty;
            txtInputter.Text = string.Empty;
            txtsupply.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtInputter.Enabled = false;
            txtsupply.Enabled = false;
            dgData.Rows.Clear();
            dgSearch.Visible = false;
        }

        void auth_po(string vStatus, string vTracode ,string vMsg)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vPO_ID", sqltype = SqlDbType.NVarChar, values = vTracode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_auth_po", arr);

                if (dt.Rows.Count > 0 )
                {
                    MessageBox.Show(vMsg + Environment.NewLine + "Batch : " + dt.Rows[0]["TRANCODE"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartext();
                }
               
            }
            catch { }
        }

        bool ch_ok(string vStatus ,string vTracode)
        {

            DataTable dt = new DataTable();
            List<parasql> arr = new List<parasql>();
            arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vStatus });
            arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
            arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = vTracode });
            dt = sql.Data_Execute("proc_get_isok", arr);
            if (dt.Rows.Count > 0 && dt.Rows[0]["Msg"].ToString()!=string.Empty)
            {
                MessageBox.Show(dt.Rows[0]["Msg"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please check purchase order information !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        bool IsOk()
        {
            if (this.Code == string.Empty || this.Code == "")
            {
                MessageBox.Show("Please check transaction purchase to reject !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }
        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgSearch.Columns.Count; i++)
                {
                    dgSearch.Columns[i].ReadOnly = true;
                }

                dgSearch.Columns["vNo"].HeaderText = "Nº";
                dgSearch.Columns["vNo"].Width = 30;
                dgSearch.Columns["vTranCode"].Width = 155;
                dgSearch.Columns["vSupply"].Width = 100;

                for (int i = 0; i < dgData.Columns.Count; i++)
                {
                    dgData.Columns[i].ReadOnly = true;
                }

                dgData.Columns["vID"].HeaderText = "Nº";
                dgData.Columns["vID"].Width = 30;
                dgData.Columns["vName"].Width = 160;
                dgData.Columns["vStock"].Width = 150;
                dgData.Columns["vCost"].Width = 88;
                dgData.Columns["vQty"].Width = 88;
                dgData.Columns["vDis"].Width = 100;

                //txtTypeCode 
                this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgData.DefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgData.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }

        void load_view(string vstatus , string vSearch)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vSearch
                    };
                dgSearch.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql_search", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgSearch.Rows.Add(
                            (i + 1).ToString(),
                            dblist.Rows[i]["po_id"].ToString(),
                            dblist.Rows[i]["sup_name"].ToString()
                        );

                        dgSearch.Visible = true;
                    }

                    btnCommit.Enabled = true;
                    btnNew.Enabled = true;
                    btnReject.Enabled = true;
                }
                else
                {
                    btnCommit.Enabled = false;
                    btnNew.Enabled = false;
                    btnReject.Enabled = false;
                }
            }
            catch { }
        }

        void view_sub(string vstatus, string vID)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vID
                    };
                dgData.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    txtsupply.Text = dblist.Rows[0]["sup_name"].ToString();
                    txtRemark.Text = dblist.Rows[0]["remark"].ToString();
                    txtInputter.Text = dblist.Rows[0]["inputter"].ToString();

                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgData.Rows.Add(
                            (i + 1).ToString(),
                            dblist.Rows[i]["pro_name"].ToString(),
                            dblist.Rows[i]["stock_name"].ToString(),
                             string.Format("{0:0.00}", dblist.Rows[i]["cost"]).ToString(),
                             string.Format("{0:0.00}", dblist.Rows[i]["oth_cost"]).ToString(),
                             string.Format("{0:0}", dblist.Rows[i]["qty"]).ToString(),
                             string.Format("{0:0}", dblist.Rows[i]["discount"]).ToString()+" %",
                             string.Format("{0:0.00}", dblist.Rows[i]["amount"]).ToString(),
                            dblist.Rows[i]["exp_date"].ToString()
                        );
                    }
                }
            }
            catch { }
        }


        private void FrmAuthPO_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Text = variables.vTittle + " - Authorize Purchase Order";
                this.gb.Text = "Information";
                cleartext();
                FormatDataGridview();
            }
            catch { }
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSearch.Visible == true)
                {
                    dgSearch.Visible = false;
                    cleartext();
                }
                else
                {
                    dgSearch.Location = new Point(208, 57);
                    dgSearch.Size = new Size(320, 144);
                    load_view("view_po_una",txtid.Text.Trim());
                }
            }
            catch { }
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Code = dgSearch[1, e.RowIndex].Value.ToString();
                txtid.Text = this.Code;
                dgSearch.Visible = false;

                view_sub("UNA_PO_Sub", this.Code);

            }
            catch { }
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Code = dgSearch[1, e.RowIndex].Value.ToString();
                txtid.Text = dgSearch[1, e.RowIndex].Value.ToString();
                dgSearch.Visible = false;
                view_sub("UNA_PO_Sub", this.Code);
            }
            catch { }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgSearch.Visible = false;
            }
            catch { }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ch_ok("ch_po", Code) == true)
                {
                    if (MessageBox.Show("Do you want to authorize :" + Code + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        auth_po("PO_Auth", Code , variables.vMsg_Auth);
                    }
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

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (PCode.Trim() == string.Empty) {
                    
                    MessageBox.Show("Please check transaction purchase to reject !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (MessageBox.Show("Do you want to reject :" + Code + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        auth_po("PO_Reject", Code, variables.vMsg_Reject);
                    }
                }
               
            }
            catch { }
        }
    }
}
