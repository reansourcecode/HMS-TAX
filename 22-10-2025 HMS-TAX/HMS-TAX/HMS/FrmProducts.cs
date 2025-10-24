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

namespace HMS_TAX.HMS
{
    public partial class FrmProducts : Office2007RibbonForm
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vcode = string.Empty;

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
            txtProID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCost.Text = "0.00";
            txtCostTax.Text = "0.00";
            txtDiscount.Text = "0.00";
            txtRemark.Text = string.Empty;
            cboActive.SelectedValue = string.Empty;
        }


        bool IsOk()
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please input item name ",variables.vTittle,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (txtCost.Text.Trim() == string.Empty)
            {
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
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "I" });
                arr.Add(new parasql { paraname = "@vpro_code", sqltype = SqlDbType.NVarChar, values = "0000" });
                arr.Add(new parasql { paraname = "@vbarcode", sqltype = SqlDbType.NVarChar, values = "none" });
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vpro_name", sqltype = SqlDbType.NVarChar, values = txtName.Text.Trim() });
                arr.Add(new parasql { paraname = "@vactive", sqltype = SqlDbType.NVarChar, values = cboActive.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vcost_tax", sqltype = SqlDbType.NVarChar, values = txtCostTax.Text.Trim() });
                arr.Add(new parasql { paraname = "@vcost", sqltype = SqlDbType.NVarChar, values = txtCost.Text.Trim() });
                arr.Add(new parasql { paraname = "@vunitprice", sqltype = SqlDbType.NVarChar, values = txtUnitPrice.Text.Trim() });
                arr.Add(new parasql { paraname = "@vdiscount", sqltype = SqlDbType.NVarChar, values = txtDiscount.Text.Trim() });
                arr.Add(new parasql { paraname = "@vremark", sqltype = SqlDbType.NVarChar, values = txtRemark.Text.Trim() });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_register_product", arr);

                if (dt.Rows.Count > 0)
                {
                    cleartext();
                    txtProID.Text = dt.Rows[0][0].ToString();
                    btn_save_record();
                    MessageBox.Show(vMsg, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                cleartext();
                btn_save_record();
                sql.Filter_ComboBox(cboActive, "exec pro_get_combo  'Active'", "title", "code");
            }
            catch { }
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
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
            }
            catch { }
        }

        private void txtCostTax_KeyPress(object sender, KeyPressEventArgs e)
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
            }
            catch { }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            }
            catch { }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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
            }
            catch { }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk() == true)
                {
                    // Add product to Database 
                    Register("I", "", variables.vMsg_insert);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsOk() == true)
            {
                if (MessageBox.Show("Do you want to update " + txtProID.Text.Trim() + " now ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Register("U", txtProID.Text.Trim(), variables.vMsg_update);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }
    }
}
