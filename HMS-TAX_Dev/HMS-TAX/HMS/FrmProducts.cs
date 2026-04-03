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
using System.Windows.Forms;

namespace HMS_TAX.HMS
{
    public partial class FrmProducts : KryptonForm
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
            txtDiscount.Text = "0.00";
            txtUnitPrice.Text = "0.00";
            txtRemark.Text = string.Empty;
            cboActive.SelectedValue = string.Empty;
            cboLine.SelectedValue = string.Empty;
            cboMolecule.SelectedValue = string.Empty;
            cboPacking.SelectedValue = string.Empty;
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
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vpro_code", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vbarcode", sqltype = SqlDbType.NVarChar, values = "none" });
                arr.Add(new parasql { paraname = "@vBranchCode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vpro_name", sqltype = SqlDbType.NVarChar, values = txtName.Text.Trim() });
                arr.Add(new parasql { paraname = "@vactive", sqltype = SqlDbType.NVarChar, values = cboActive.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vcost", sqltype = SqlDbType.NVarChar, values = txtCost.Text.Trim() });
                arr.Add(new parasql { paraname = "@vunitprice", sqltype = SqlDbType.NVarChar, values = txtUnitPrice.Text.Trim() });
                arr.Add(new parasql { paraname = "@vdiscount", sqltype = SqlDbType.NVarChar, values = txtDiscount.Text.Trim() });
                arr.Add(new parasql { paraname = "@vremark", sqltype = SqlDbType.NVarChar, values = txtRemark.Text.Trim() });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });


                arr.Add(new parasql { paraname = "@vline_id", sqltype = SqlDbType.NVarChar, values = cboLine.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vMol_id", sqltype = SqlDbType.NVarChar, values = cboMolecule.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vPack_id", sqltype = SqlDbType.NVarChar, values = cboPacking.SelectedValue.ToString() });

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
                    txtProID.Text = dt.Rows[0]["pro_code"].ToString();
                    txtName.Text = dt.Rows[0]["pro_name"].ToString();
                    txtRemark.Text = dt.Rows[0]["Remark"].ToString();

                    txtCost.Text = String.Format("{0:0.##}", dt.Rows[0]["cost"]);
                    txtUnitPrice.Text = String.Format("{0:0.##}", dt.Rows[0]["unitprice"]);
                    txtDiscount.Text = dt.Rows[0]["discount"].ToString();

                    cboLine.SelectedValue = dt.Rows[0]["line_id"].ToString();
                    cboMolecule.SelectedValue = dt.Rows[0]["mol_id"].ToString();
                    cboPacking.SelectedValue = dt.Rows[0]["pack_id"].ToString();
                    cboActive.SelectedValue = dt.Rows[0]["active"].ToString();
                    btn_edit_record();
                }
                else
                {
                    MessageBox.Show("Record id does not exist !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                btn_save_record();
                sql.Filter_ComboBox(cboActive, "exec pro_get_combo  'Active'", "title", "code");
                sql.Filter_ComboBox(cboLine, "exec pro_get_combo  'Line' , '" + variables.PBranchCode + "'", "title", "code");
                sql.Filter_ComboBox(cboPacking, "exec pro_get_combo  'Pack' , '" + variables.PBranchCode + "'", "title", "code");
                sql.Filter_ComboBox(cboMolecule, "exec pro_get_combo  'Mol' , '" + variables.PBranchCode + "'", "title", "code");

                cleartext();

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

        private void txtProID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetInfor("show_product", txtProID.Text.Trim());
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {

                FrmSearchProduct FRM_SEARCH = new FrmSearchProduct();
                FRM_SEARCH.Status = "search_product";

                FRM_SEARCH.StartPosition = FormStartPosition.CenterParent;
                FRM_SEARCH.ShowDialog();
                if (FRM_SEARCH.Code != string.Empty)
                {
                    txtProID.Text = FRM_SEARCH.Code;
                    GetInfor("show_product", txtProID.Text.Trim());
                }
                else
                {
                    txtProID.Text = string.Empty;
                }
                this.Show();
            }
            catch { }
        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }
    }
}
