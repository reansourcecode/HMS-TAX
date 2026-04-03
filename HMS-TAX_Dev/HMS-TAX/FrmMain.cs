using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.Function;
using HMS_TAX.HMS_Auth;
using HMS_TAX.Setting;
using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HMS_TAX
{
    public partial class FrmMain : KryptonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        modules mod = new modules();
        void LoadChild(Form vFrm, string FrmTag)
        {
            try
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                vFrm.Tag = FrmTag;
                vFrm.MdiParent = FrmMain.ActiveForm;
                vFrm.StartPosition = FormStartPosition.CenterScreen;
                vFrm.Show();
                vFrm.Activate();
            }
            catch { }
        }
        public void Open_Frm(string vFrmName)
        {
            try
            {
                Form FormShow;
                Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\HMS_TAX.exe");
                System.Reflection.Assembly assembly1 = Assembly.LoadFile(Application.StartupPath + "\\HMS_TAX.exe");
                FormShow = (Form)assembly1.CreateInstance("HMS-TAX." + vFrmName);
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("HMS_TAX.HMS." + vFrmName);
                }
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("HMS_TAX.Setting." + vFrmName);
                }
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("HMS_TAX.HMS_Auth." + vFrmName);
                }
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("HMS_TAX.Function." + vFrmName);
                }
                if (FormShow != null)
                {
                    this.AddOwnedForm(FormShow);
                    LoadChild(FormShow, FormShow.Name);
                }
            }
            catch { }
        }


        private void _logout_sub_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }

         string check_version ()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();

                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "CH_VERSION" });
                arr.Add(new parasql { paraname = "@vCurrentVersion", sqltype = SqlDbType.NVarChar, values = variables.vlastVersion });
                arr.Add(new parasql { paraname = "@vNewVersion", sqltype = SqlDbType.NVarChar, values = variables.vNewVersion });
                dt = sql.Data_Execute("proc_version", arr);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["STATUS"].ToString();
                }
            }
            catch {  }
            return "UPDATED";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                lblShowDeveloper.Text = "Developed by Team REAN Dev Solution";
                lblShowUserlogin.Text = "User : " + variables.PInputter.ToUpper();
                LblVersion.Text = "Version : " + variables.vNewVersion + "(" + variables.PDatabaseName + ")";

                if (check_version() == "UPDATED")
                {
                    FrmUpdateVersion version = new FrmUpdateVersion();
                    version.ShowDialog();
                }
                else if (check_version() == "DB-HIGH")
                {
                    MessageBox.Show("The database version is newer than the application version.", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                else if (check_version() == "DB-LOWER")
                {
                    MessageBox.Show("The application version is newer than the database version.", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                //this._Payment_Menu.Visible = false;

            }
            catch { }
        }

        private void _Exit_sub_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _register_customer_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmCustomers");
        }

        private void _permission_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmPermission");
        }

        private void _register_product_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmProducts");
        }

        private void _purchase_order_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmPurchaseorder");

        }

        private void _ticket_PurchaseOrder_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmPurchaseOrderHistory");
        }

        private void _authorizePO_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAuthPO");

        }

        private void _report_list_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmReports");

        }

        private void _pos_sub_Click(object sender, EventArgs e)
        {
            try
            {
                variables.pos_flag="0";
                Open_Frm("FrmPOS");
            }
            catch { }
        }

        private void _PurchaseOrder_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmPurchaseorder");
        }

        private void _authorize_POS_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAuthPOS");
        }

        private void _pos_ci_sub_Click(object sender, EventArgs e)
        {
            variables.pos_flag = "1";
            Open_Frm("FrmPOS");
        }

        private void _NBC_Exchange_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmExchangeRate");
        }

        private void _return_pos_sub_Click(object sender, EventArgs e)
        {
            variables.pos_flag="2";
            Open_Frm("FrmReturnPOS");
        }

        private void _stock_transfer_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmStockTransfers");
        }

        private void _auth_stock_transfer_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAuthStockTransfer");
        }

        private void _register_supply_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmSupply");
        }

        private void _product_line_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmLine");
        }

        private void _user_Account_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmUserAccounts");

        }

        private void _about_me_sub_Click(object sender, EventArgs e)
        {
            
            Open_Frm("FrmAboutMe");

        }

        private void _backup_db_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmBackup");
        }

        private void _payment_voucher_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmPaymentVoucher");
        }

        private void _reprint_pos_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmRePrintPOS");
        }

        private void _auth_paymentvoucher_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAuthPaymentVoucher");

        }

        private void _accountsPayable_sub_Click(object sender, EventArgs e)
        {
           
        }

        private void _auth_account_payable_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAuthAccountPayable");
        }

        private void _make_payment_ap_sub_Click(object sender, EventArgs e)
        {
            
        }

        private void _booking_acc_ap_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAccountPayable");
        }

        private void _payment_acc_ap_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmMakePaymentAP");
        }
        private void _auth_acc_ap_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmAuthAccountPayable");
        }
    }
}
