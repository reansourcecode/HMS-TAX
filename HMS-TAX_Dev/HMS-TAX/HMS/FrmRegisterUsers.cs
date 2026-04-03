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
using System.Xml.Linq;

namespace HMS_TAX.HMS
{
    public partial class FrmRegisterUsers : KryptonForm
    {
        public FrmRegisterUsers()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();

        public string PStatus = string.Empty;
        public string vPro_Id = string.Empty;
        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        public string Pro_ID
        {
            get { return vPro_Id; }
            set { vPro_Id = value; }
        }
        
        void cleartext()
        {
            txtId.Text = string.Empty;
            txtuserlogin.Text = string.Empty;
        }

        bool IsOk()
        {
            if (txtuserlogin.Text.Trim() == string.Empty)
            {
                txtuserlogin.Select();
                txtuserlogin.Focus();
                MessageBox.Show("User login has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtpassword.Text.Trim() == string.Empty)
            {
                txtpassword.Select();
                txtpassword.Focus();
                MessageBox.Show("User password has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (txtpassword.Text.Trim() != txtConpassword.Text.Trim())
            {
                txtConpassword.Select();
                txtConpassword.Focus();
                MessageBox.Show("Password and confirm password not matched has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }


            DataTable user = new DataTable();
            string[] p = {
                    "check_user_exists",
                    variables.PBranchCode,
                    txtuserlogin.Text.Trim()
                };
            user = sql.proc_getdata("proc_get_sql", p);

            if ((user.Rows.Count>0))
            {
                txtuserlogin.Select();
                txtuserlogin.Focus();
                MessageBox.Show("Username :" + txtuserlogin.Text.Trim() + " , already exists", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void FrmRegisterUsers_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                cleartext();
            }
            catch { }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (IsOk() == true)
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                var vPassword = xml_security.GenerateKeyHash(txtpassword.Text.ToString());

                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "I" });
                arr.Add(new parasql { paraname = "@vuser_id", sqltype = SqlDbType.NVarChar, values = "" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vloginname", sqltype = SqlDbType.NVarChar, values = txtuserlogin.Text.Trim() });
                arr.Add(new parasql { paraname = "@vpassword", sqltype = SqlDbType.NVarChar, values = vPassword });
                arr.Add(new parasql { paraname = "@vpro_id", sqltype = SqlDbType.NVarChar, values = Pro_ID });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_register_user", arr);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("User ID : " + dt.Rows[0]["TRANCODE"].ToString(), variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vPro_Id = dt.Rows[0]["TRANCODE"].ToString();
                    this.Close();
                }
            }
        }

        private void txtuserlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch { }
        }
    }
}
