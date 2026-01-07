using ComponentFactory.Krypton.Toolkit;
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

namespace HMS_TAX.HMS_Auth
{
    public partial class FrmAuthStockTransfer : KryptonForm
    {
        public FrmAuthStockTransfer()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();

        public string PStatus = string.Empty;
        public string P_ST_NUM = string.Empty;

        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        public string ST_CODE
        {
            get { return P_ST_NUM; }
            set { P_ST_NUM = value; }
        }
        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgData.Columns.Count; i++)
                {
                    dgData.Columns[i].ReadOnly = true;
                }

                dgData.Columns["gNum"].HeaderText = "Nº";
                dgData.Columns["gNum"].Width = 33;
                dgData.Columns["vcode"].Width = 125;
                dgData.Columns["vinputter"].Width = 88;
                dgData.Columns["vdate"].Width = 200;

                for (int i = 0; i < dgView.Columns.Count; i++)
                {
                    dgView.Columns[i].ReadOnly = true;
                }

                dgView.Columns["vNum"].HeaderText = "Nº";
                dgView.Columns["vNum"].Width = 30;
                dgView.Columns["vName"].Width = 200;
                dgView.Columns["vst_from"].Width = 100;
                dgView.Columns["vst_to"].Width = 100;
                dgView.Columns["vqty"].Width = 77;
                dgView.Columns["vbatch_id"].Width = 155;
                dgView.Columns["vexp"].Width = 155;

                
                //txtTypeCode
                this.dgData.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgView.DefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgView.DefaultCellStyle.ForeColor = Color.Black;

            }
            catch { }
        }
        void record_list(string vstatus, string vSearch)
        {
            try
            {
                DataTable record = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vSearch
                    };
                dgData.Rows.Clear();
                dgView.Rows.Clear();
                record = sql.proc_getdata("proc_get_sql_pos", p);
                if (record.Rows.Count > 0)
                {
                    dg_action.Enabled = true;
                    ST_CODE=String.Empty;

                    for (int i = 0; i < record.Rows.Count; i++)
                    {
                        dgData.Rows.Add(
                            (i + 1).ToString(),
                            record.Rows[i]["ts_id"].ToString(),
                            record.Rows[i]["inputter"].ToString(),
                            record.Rows[i]["create_at"].ToString()
                        );
                    }
                }
                else
                {
                    dg_action.Enabled = false;
                }
            }
            catch { }
        }
        void list_details(string vstatus, string vCode)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vCode
                    };
                dgView.Rows.Clear();
                dt = sql.proc_getdata("proc_get_sql_pos", p);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgView.Rows.Add(
                            (i + 1).ToString(),
                            dt.Rows[i]["pro_name"].ToString(),
                            dt.Rows[i]["sto_from_name"].ToString(),
                            dt.Rows[i]["sto_to_name"].ToString(),
                            string.Format("{0:0}", Convert.ToDouble(dt.Rows[i]["qty"])),
                            dt.Rows[i]["batch_id"].ToString(),
                            dt.Rows[i]["expired_at"].ToString()

                        );
                    }
                }
            }
            catch { }
        }
        private void FrmAuthStockTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle + " - Authorize Stock Transfer";
                FormatDataGridview();
                record_list("st_main_una_list", "%");
            }
            catch {}
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ST_CODE = dgData["vcode", e.RowIndex].Value.ToString();
                if (P_ST_NUM != string.Empty)
                {
                    list_details("ts_una_list", P_ST_NUM);
                }
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (P_ST_NUM == string.Empty)
                {
                    _Approved.Enabled = false;
                    _Rejected.Enabled = false;
                    dg_action.Enabled = false;

                }
                else
                {
                    _Approved.Enabled = true;
                    _Rejected.Enabled = true;
                    dg_action.Enabled = true;
                }

            }
            catch { }
        }
        bool ch_ok(string vStatus, string vTracode)
        {

            DataTable dt = new DataTable();
            List<parasql> arr = new List<parasql>();
            arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vStatus });
            arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
            arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = vTracode });
            dt = sql.Data_Execute("proc_get_isok", arr);
            if (dt.Rows.Count > 0 && dt.Rows[0]["Msg"].ToString() != string.Empty)
            {
                MessageBox.Show(dt.Rows[0]["Msg"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (P_ST_NUM == string.Empty)
            {
                MessageBox.Show("Please check POS information again !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        void auth_record(string vStatus, string vTracode, string vMsg)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vts_ID", sqltype = SqlDbType.NVarChar, values = vTracode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_auth_stock_transfer", arr);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(vMsg + Environment.NewLine + " invoice : " + dt.Rows[0]["TRANCODE"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    record_list("st_main_una_list", "%");
                }
            }
            catch { }
        }
        private void _Approved_Click(object sender, EventArgs e)
        {
            try
            {
                if (ch_ok("ch_pos", P_ST_NUM) == true)
                {
                    if (MessageBox.Show("Do you want to authorize :" + P_ST_NUM + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        auth_record("ST_Auth", P_ST_NUM, variables.vMsg_Auth);
                    }
                }
            }
            catch { }
        }

        private void _Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                record_list("st_main_una_list", "%");
            }
            catch { }
        }

        private void _Rejected_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to reject :" + P_ST_NUM + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    auth_record("reject_stock_transfer", P_ST_NUM, variables.vMsg_Reject);
                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                record_list("st_main_una_list", txtSearch.Text.Trim());
            }
            catch { }
        }
    }
}
