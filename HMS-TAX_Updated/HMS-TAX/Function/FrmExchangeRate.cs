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

namespace HMS_TAX.Function
{
    public partial class FrmExchangeRate : KryptonForm
    {
        public FrmExchangeRate()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vcode = string.Empty;
        void currency_select(string vstatus, KryptonComboBox cbo)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = new string[3];
                p[0] = vstatus;
                p[1] = variables.PBranchCode;
                p[2] = cbo.SelectedValue.ToString();
                dt = sql.proc_getdata("proc_get_sql_exchange", p);

                if (dt.Rows.Count > 0)
                {

                    if (cbo.Name == "cbocurrency")
                    {
                        txtcode1.Text = dt.Rows[0]["currency"].ToString();
                        txtsymbol1.Text = dt.Rows[0]["currencysymbol"].ToString();
                        txtsmallamount1.Text = String.Format("{0:0.00}", dt.Rows[0]["smallestcharge"]).ToString();
                    }
                    else if (cbo.Name == "cbosecond")
                    {
                        txtcode2.Text = dt.Rows[0]["currency"].ToString();
                        txtsymbol2.Text = dt.Rows[0]["currencysymbol"].ToString();
                        txtsmallamount2.Text = String.Format("{0:0.00}", dt.Rows[0]["smallestcharge"]).ToString();
                    }

                }

            }
            catch { }
        }


        void load_currency()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p =
                {
                    "load_currency",
                    variables.PBranchCode,
                };
                dt = sql.proc_getdata("proc_get_sql_exchange", p);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Hasusing"].ToString() == "Yes")
                    {
                        cbocurrency.Enabled = false;
                        cbosecond.Enabled = false;
                        txtcode1.Enabled = false;
                        txtcode2.Enabled = false;
                        txtsymbol1.Enabled = false;
                        txtsymbol2.Enabled = false;
                        txtsmallamount1.Enabled = false;
                        txtsmallamount2.Enabled = false;
                    }
                    else
                    {
                        cbocurrency.Enabled = true;
                        cbosecond.Enabled = true;
                        txtcode1.Enabled = true;
                        txtcode2.Enabled = true;
                        txtsymbol1.Enabled = true;
                        txtsymbol2.Enabled = true;
                        txtsmallamount1.Enabled = true;
                        txtsmallamount2.Enabled = true;
                    }

                    cbocurrency.SelectedValue = dt.Rows[0]["code1"].ToString();
                    cbosecond.SelectedValue = dt.Rows[0]["code2"].ToString();


                    txtcode1.Text = dt.Rows[0]["currency1"].ToString();
                    txtcode2.Text = dt.Rows[0]["currency2"].ToString();
                    txtsymbol1.Text = dt.Rows[0]["sysmbol1"].ToString();
                    txtsymbol2.Text = dt.Rows[0]["sysmbol2"].ToString();

                    txtsmallamount1.Text = String.Format("{0:0.00}", dt.Rows[0]["smallest1"]).ToString();
                    txtsmallamount2.Text = String.Format("{0:0.00}", dt.Rows[0]["smallest2"]).ToString();
                    txtexchange1.Text = String.Format("{0:0.00}", dt.Rows[0]["exchange1"]).ToString();
                    txtexchange2.Text = String.Format("{0:0.00}", dt.Rows[0]["exchange2"]).ToString();


                    cbocurrency.Enabled=false;
                    cbosecond.Enabled=false;
                    txtcode1.Enabled=false;
                    txtcode2.Enabled=false;
                    txtsymbol1.Enabled=false;
                    txtsymbol2.Enabled=false;
                    txtsmallamount1.Enabled=false;
                    txtsmallamount2.Enabled=false;
                    txtcode1.Enabled=false;
                    txtcode2.Enabled=false;
                    txtsymbol1.Enabled=false;
                    txtsymbol2.Enabled=false;
                    txtsmallamount1.Enabled=false;
                    txtexchange1.Enabled = false;

                }

            }
            catch { }
        }


        Boolean IsOk()
        {
            if (sql.cbo_empty(cbocurrency) == false)
            {
                cbocurrency.Select();
                cbocurrency.Focus();
                MessageBox.Show("Best currency has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cbosecond) == false)
            {
                cbosecond.Select();
                cbosecond.Focus();
                MessageBox.Show("Exchang to currency has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtcode1.Text.Trim() == string.Empty)
            {
                txtcode1.Select();
                txtcode1.Focus();
                MessageBox.Show("Currency info has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtcode1.Text.Trim().Length != 3 || txtcode2.Text.Trim().Length != 3)
            {
                txtcode1.Select();
                txtcode1.Focus();
                MessageBox.Show("Currency code three character  has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtcode2.Text.Trim() == string.Empty)
            {
                txtcode1.Select();
                txtcode1.Focus();
                MessageBox.Show("Currency info has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (txtsmallamount1.Text.Trim() == string.Empty)
            {
                txtsmallamount1.Select();
                txtsmallamount1.Focus();
                MessageBox.Show("Currency small amount has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtsmallamount2.Text.Trim() == string.Empty)
            {
                txtsmallamount2.Select();
                txtsmallamount2.Focus();
                MessageBox.Show("Currency small amount has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtexchange1.Text.Trim() == string.Empty)
            {
                txtexchange1.Select();
                txtexchange1.Focus();
                MessageBox.Show("Exchange Rate has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtexchange2.Text.Trim() == string.Empty)
            {
                txtexchange2.Select();
                txtexchange2.Focus();
                MessageBox.Show("Exchange Rate has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (cbocurrency.SelectedValue.ToString() == cbosecond.SelectedValue.ToString())
            {
                cbocurrency.Select();
                cbocurrency.Focus();
                MessageBox.Show("Currency and currency exchange must be different !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }


            double vsmallamount1 = 0;
            double vsmallamount2 = 0;
            double.TryParse(txtsmallamount1.Text.Trim(), out vsmallamount1);
            double.TryParse(txtsmallamount2.Text.Trim(), out vsmallamount2);

            if (vsmallamount1 <= 0)
            {
                txtsmallamount1.Select();
                txtsmallamount1.Focus();
                MessageBox.Show("Small amount has been required greater then zero !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if (vsmallamount2 <= 0)
            {
                txtsmallamount2.Select();
                txtsmallamount2.Focus();
                MessageBox.Show("Small amount has been required greater then zero !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void FrmExchangeRate_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cbocurrency, "exec proc_get_sql_exchange  'cbo_currency','" + variables.PBranchCode + "','%'", "name", "code");
                sql.Filter_ComboBox(cbosecond, "exec proc_get_sql_exchange  'cbo_currency','" + variables.PBranchCode + "','%'", "name", "code");
                load_currency();
            }
            catch { }
        }

        private void cbocurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currency_select("cbo_currency_info", cbocurrency);
            }
            catch { }
        }

        private void cbosecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currency_select("cbo_currency_info", cbosecond);
            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsOk() == true)
            {
                DataTable dt = new DataTable();
                string[] p =
                {
                    variables.PBranchCode,
                    cbocurrency.SelectedValue.ToString(),
                    txtcode1.Text.Trim(),
                    txtsymbol1.Text.Trim(),
                    txtsmallamount1.Text.Trim(),
                    txtexchange1.Text.Trim(),
                    cbosecond.SelectedValue.ToString(),
                    txtcode2.Text.Trim(),
                    txtsymbol2.Text.Trim(),
                    txtsmallamount2.Text.Trim(),
                    txtexchange2.Text.Trim(),
                    variables.PInputter
                };

                dt = sql.proc_getdata("proc_setting_currency", p);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Setting and currency control set completed !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
