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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_TAX.Function
{
    public partial class FrmChangePassword : KryptonForm
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vuser_id = string.Empty;
        string vPro_Id = string.Empty;
        public string User_ID
        {
            get { return vuser_id; }
            set { vuser_id = value; }
        }

        public string Pro_ID
        {
            get { return vPro_Id; }
            set { vPro_Id = value; }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle + " - Change User Password";

            }
            catch { }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpassword.Text.Trim() == string.Empty)
                {
                    txtpassword.Select();
                    txtpassword.Focus();
                    MessageBox.Show("User password has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else if (txtpassword.Text.Trim() != txtConpassword.Text.Trim())
                {
                    txtConpassword.Select();
                    txtConpassword.Focus();
                    MessageBox.Show("Password and confirm password not matched has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var vPassword = xml_security.GenerateKeyHash(txtpassword.Text.ToString());
                    string[] p = {
                     "Change_Password",
                     vuser_id,
                     variables.PBranchCode,
                     vPassword };
                    sql.proc_getdata("pro_edit_user", p);
                    MessageBox.Show("User password changed successfully !! ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
