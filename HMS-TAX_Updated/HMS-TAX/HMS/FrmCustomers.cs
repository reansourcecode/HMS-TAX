using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HMS_TAX.HMS
{
    public partial class FrmCustomers : KryptonForm
    {
        public FrmCustomers()
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
            txtCusID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRemark.Text = string.Empty;
            cboActive.Text = string.Empty;
            cboActive.SelectedValue = "";
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
                arr.Add(new parasql { paraname = "@vCus_ID", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vName", sqltype = SqlDbType.NVarChar, values = txtName.Text.Trim() });
                arr.Add(new parasql { paraname = "@vGender", sqltype = SqlDbType.NVarChar, values = "01" });
                arr.Add(new parasql { paraname = "@vActive", sqltype = SqlDbType.NVarChar, values = cboActive.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vPhone", sqltype = SqlDbType.NVarChar, values = txtPhone.Text.Trim() });
                arr.Add(new parasql { paraname = "@vAddress", sqltype = SqlDbType.NVarChar, values = txtAddress.Text.Trim() });
                arr.Add(new parasql { paraname = "@vRemark", sqltype = SqlDbType.NVarChar, values = txtRemark.Text.Trim() });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_register_customer", arr);
                if (dt.Rows.Count > 0)
                {
                    txtCusID.Text = dt.Rows[0]["TRANCODE"].ToString();
                    MessageBox.Show(vMsg, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartext();
                    btn_save_record();
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
                string[] p =
                {
                    vstatus,
                    variables.PBranchCode,
                    vcode
                };

                DataTable dt = sql.proc_getdata("proc_get_sql", p);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        variables.vMsgNotExits,
                        variables.vTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                    return;
                }

                DataRow row = dt.Rows[0];
                txtCusID.Text = Convert.ToString(row["cus_id"]);
                txtName.Text = Convert.ToString(row["cus_name"]);
                txtPhone.Text = Convert.ToString(row["phone"]);
                txtRemark.Text = Convert.ToString(row["Remark"]);
                txtAddress.Text = Convert.ToString(row["Address"]);

                cboActive.SelectedValue = Convert.ToString(row["active"]);
                btn_edit_record();
            }
            catch { }
        }


        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cboActive, "exec pro_get_combo  'Active'", "title", "code");

                btn_save_record();
                cleartext();
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
                    Register("I", "", variables.vMsg_insert);
                }
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsOk() == true)
            {
                if (MessageBox.Show("Do you want to update " + txtCusID.Text.Trim() + " now ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Register("U", txtCusID.Text.Trim(), variables.vMsg_update);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {

                FrmSearchCustomer FRM_SEARCH = new FrmSearchCustomer();
                FRM_SEARCH.Status = "search_customer";
                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty)
                {
                    txtCusID.Text = FRM_SEARCH.Code;
                    GetInfor("show_customer", txtCusID.Text.Trim());
                }
                else
                {
                    txtCusID.Text = string.Empty;
                }
                this.Show();
            }
            catch { }
        }

        private void txtCusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    GetInfor("show_customer", txtCusID.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
