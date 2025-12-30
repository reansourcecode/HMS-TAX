using ComponentFactory.Krypton.Toolkit;
using DevComponents.DotNetBar;
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
    public partial class FrmPOSBatchID : KryptonForm
    {
        public FrmPOSBatchID()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        private bool _hasInitialized = false;
        modules mod = new modules();

        public bool PIS_CHECK = false;
        public string PStatus = string.Empty;
        public string PCode = string.Empty;
        public string PSysDocNum = string.Empty;
        public string P_Pro_ID = string.Empty;

        public bool IS_CHECK
        {
            get { return PIS_CHECK; }
            set { PIS_CHECK = value; }
        }
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

        public string Rcp_Num
        {
            get { return PCode; }
            set { PCode = value; }
        }

        public string Pro_ID
        {
            get { return P_Pro_ID; }
            set { P_Pro_ID = value; }
        }

        void load_batch_id(string vStatus, string vCode , string vSto_ID)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();

                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vcode2", sqltype = SqlDbType.NVarChar, values = vSto_ID });
                dt = sql.Data_Execute("proc_get_sql", arr);

                if (dt.Rows.Count > 0)
                {
                    cboBatchID.DataSource = dt;
                    cboBatchID.DisplayMember = "code";
                    cboBatchID.ValueMember = "code";
                    cboBatchID.SelectedIndex = 0;
                    cboBatchID.Enabled = true;

                }
                else
                {
                    cboBatchID.Enabled = false;
                    cboBatchID.Text = string.Empty;
                    txtinstock.Text = "0";
                }
            }
            catch { }
        }

        void edit_pos_list(string vStatus , string vCode )
        {
            try
            {
                if (IS_CHECK == true)
                {
                    DataTable dt = new DataTable();
                    List<parasql> arr = new List<parasql>();
                    arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                    arr.Add(new parasql { paraname = "@vSysDoc", sqltype = SqlDbType.NVarChar, values = vCode });
                    arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                    arr.Add(new parasql { paraname = "@vbatch_id", sqltype = SqlDbType.NVarChar, values = cboBatchID.SelectedValue.ToString() });
                    arr.Add(new parasql { paraname = "@vsto_ID", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                    arr.Add(new parasql { paraname = "@vprice", sqltype = SqlDbType.NVarChar, values = "0" });
                    arr.Add(new parasql { paraname = "@vdis", sqltype = SqlDbType.NVarChar, values = "0" });
                    arr.Add(new parasql { paraname = "@vqty", sqltype = SqlDbType.NVarChar, values = txtQty.Text.Trim() });
                    arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });

                    dt = sql.Data_Execute("proc_pos_edit_list", arr);

                }
            }
            catch { }
        }

        void view_data(string vStatus,string vCode)
        {
            try
            {
                _hasInitialized=true;
                int Qty = 0;
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vflag", sqltype = SqlDbType.NVarChar, values = variables.PInputter });

                dt = sql.Data_Execute("proc_get_sql_pos", arr);

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["pro_name"].ToString();
                    this.P_Pro_ID= dt.Rows[0]["pro_code"].ToString();

                    int.TryParse(dt.Rows[0]["qty"].ToString(), out Qty);
                    txtQty.Text = String.Format("{0:0}", Qty).ToString();


                    cboStock.SelectedValue = dt.Rows[0]["sto_id"].ToString();
                    cboBatchID.SelectedValue = dt.Rows[0]["batch_id"].ToString();

                }
            }
            catch { }
        }
        private void FrmPOSBatchID_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cboStock, "exec proc_get_sql_pos  'stock_menu','" + variables.PBranchCode + "','%'", "name", "code");
            }
            catch { }
        }
        bool Isok()
        {
            try
            {
                if (sql.cbo_empty(cboBatchID) == false)
                {
                    MessageBox.Show("Please select batch id", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cboBatchID.Select();
                    cboBatchID.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtQty.Text.Trim()) == true || txtQty.Text.Trim() == "0")
                {
                    MessageBox.Show("Please enter quantity", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtQty.Select();
                    txtQty.Focus();
                    return false;
                }


                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "ch_pos_qty" });
                arr.Add(new parasql { paraname = "@vbranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = Pro_ID });
                arr.Add(new parasql { paraname = "@vsto_id", sqltype = SqlDbType.NVarChar, values = cboStock.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vbatch_id", sqltype = SqlDbType.NVarChar, values = cboBatchID.SelectedValue.ToString() });

                dt = sql.Data_Execute("proc_get_batch_id", arr);

                if (dt.Rows.Count > 0)
                {
                    int available_qty = 0;
                    int.TryParse(dt.Rows[0]["available_qty"].ToString(), out available_qty);
                    int entered_qty = 0;
                    int.TryParse(txtQty.Text.Trim(), out entered_qty);
                    if (entered_qty > available_qty)
                    {
                        MessageBox.Show("Quantity exceeds available stock." + Environment.NewLine + " Available quantity: " + available_qty.ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtQty.Select();
                        txtQty.Focus();
                        return false;
                    }
                }else
                {
                    MessageBox.Show("No stock available for the selected batch ID.", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtQty.Select();
                    txtQty.Focus();
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (Isok() == true)
                {
                    edit_pos_list("pos_edit_bathid", PSysDocNum);
                    this.Close();
                }
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void cboStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cboStock) == false)
                {
                    cboStock.Select();
                    cboStock.Focus();
                }
                else
                {
                    //edit_pos_list("pos_edit_bathid", PSysDocNum);
                    load_batch_id("get_batch_id", PCode, cboStock.SelectedValue.ToString());
                }

            }
            catch { }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    edit_pos_list("pos_edit_bathid", PSysDocNum);
            //}
            //catch { }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                //if (e.KeyChar == '\r')
                //{
                //    edit_pos_list("pos_edit_bathid", PSysDocNum);
                //}

            }
            catch { }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                //edit_pos_list("pos_edit_bathid", PSysDocNum);
            }
            catch { }
        }

        private void FrmPOSBatchID_Shown(object sender, EventArgs e)
        {
            if (!_hasInitialized)
            {
                try
                {

                    ThreadPool.QueueUserWorkItem(state =>
                    {
                        Thread.Sleep(1000); // brief sleep to allow the main thread
                                            // to paint the form nicely
                        this.Invoke((Action)delegate {
                            this.IS_CHECK = true;
                            view_data(Status, SysDocNum);

                        });
                    });
                }
                catch { }
            }
        }

        private void cboBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cboBatchID) == false | sql.cbo_empty(cboStock) == false)
                {
                    cboStock.Select();
                    cboBatchID.Focus();

                    return;
                }

                
                float vqty = mod.pos_get_qty("in_stock_by_sysdoc", SysDocNum, Pro_ID, cboStock.SelectedValue.ToString(), cboBatchID.SelectedValue.ToString());
                if(vqty>0)
                {
                    txtinstock.Text = String.Format("{0:0}", vqty).ToString();
                }
                else
                {
                    txtinstock.Text = "0";
                }
            }
            catch { }
       
        }
    }
}
