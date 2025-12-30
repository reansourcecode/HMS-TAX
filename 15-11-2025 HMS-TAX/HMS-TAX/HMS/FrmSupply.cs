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

namespace HMS_TAX.HMS
{
    public partial class FrmSupply : KryptonForm
    {
        public FrmSupply()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();

        public string PStatus = string.Empty;
        public string P_Code = string.Empty;
        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        public string Code
        {
            get { return P_Code; }
            set { P_Code = value; }
        }
        void btn_save_record()
        {
            btnNew.Enabled = true;
            btnCommit.Enabled = true;
            btnEdit.Enabled = false;
        }


        void btn_edit_record()
        {
            btnNew.Enabled = true;
            btnCommit.Enabled = false;
            btnEdit.Enabled = true;
        }

        void cleartext()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRemark.Text = string.Empty;
            cboActive.Text = string.Empty;
            cboActive.SelectedValue = "";
        }

        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgView.Columns.Count; i++)
                {
                    dgView.Columns[i].ReadOnly = true;
                }

                dgView.Columns["vNum"].HeaderText = "Nº";
                dgView.Columns["vNum"].Width = 44;
                dgView.Columns["vid"].Width = 30;
                dgView.Columns["vName"].Width = 150;
                dgView.Columns["vphone"].Width = 88;
                dgView.Columns["vremark"].Width = 166;
                dgView.Columns["vstatus"].Width = 88;

                dgView.Columns["vid"].Visible = false;


                //txtTypeCode
                this.dgView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgView.DefaultCellStyle.Font = new Font("Times New Roman", 15F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgView.DefaultCellStyle.ForeColor = Color.Black;
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
                dt = sql.proc_getdata("proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0]["sup_id"].ToString();
                    txtName.Text = dt.Rows[0]["sup_name"].ToString();
                    txtPhone.Text = dt.Rows[0]["phone"].ToString();
                    txtRemark.Text = dt.Rows[0]["Remark"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();

                    cboActive.SelectedValue = dt.Rows[0]["active"].ToString();
                    btn_edit_record();
                }
                else
                {
                    MessageBox.Show(variables.vMsgNotExits, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }

        bool IsOk()
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                txtName.Select();
                txtName.Focus();
                MessageBox.Show("Customer name has been required  !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtPhone.Text.Trim() == string.Empty)
            {
                txtPhone.Select();
                txtPhone.Focus();
                MessageBox.Show("Phone has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cboActive) == false)
            {
                cboActive.Select();
                cboActive.Focus();
                MessageBox.Show("Status active has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                arr.Add(new parasql { paraname = "@vID", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vName", sqltype = SqlDbType.NVarChar, values = txtName.Text.Trim() });
                arr.Add(new parasql { paraname = "@vActive", sqltype = SqlDbType.NVarChar, values = cboActive.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vPhone", sqltype = SqlDbType.NVarChar, values = txtPhone.Text.Trim() });
                arr.Add(new parasql { paraname = "@vAddress", sqltype = SqlDbType.NVarChar, values = txtAddress.Text.Trim() });
                arr.Add(new parasql { paraname = "@vRemark", sqltype = SqlDbType.NVarChar, values = txtRemark.Text.Trim() });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_register_supply", arr);
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0]["TRANCODE"].ToString();
                    MessageBox.Show(vMsg, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartext();
                    btn_save_record();
                    load_view("search_supply", "%");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                dgView.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql_search", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgView.Rows.Add(
                            (i+1).ToString(),
                            dblist.Rows[i]["sup_id"].ToString(),
                            dblist.Rows[i]["sup_name"].ToString(),
                            dblist.Rows[i]["phone"].ToString(),
                            dblist.Rows[i]["remark"].ToString(),
                            dblist.Rows[i]["Active"].ToString()
                        );

                        dgView.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void FrmSupply_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                FormatDataGridview();
                sql.Filter_ComboBox(cboActive, "exec pro_get_combo  'Active'", "title", "code");

                btn_save_record();
                cleartext();

                load_view("search_supply", "%");

            }
            catch { }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetInfor("show_supply", txtId.Text.Trim());
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk() == true)
                {
                    Register("I", "", variables.vMsg_insert);
                }
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsOk() == true)
            {
                if (MessageBox.Show("Do you want to update " + txtId.Text.Trim() + " now ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Register("U", txtId.Text.Trim(), variables.vMsg_update);
                }
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                P_Code = dgView["vid", e.RowIndex].Value.ToString();

                if (P_Code != string.Empty)
                {
                    GetInfor("show_supply", P_Code);
                }
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
    }
}
