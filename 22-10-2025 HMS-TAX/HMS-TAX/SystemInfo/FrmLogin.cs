using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMS_TAX.UserDefined;

namespace HMS_TAX
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                txtUserName.Text = "reanit";
                txtPassword.Text = "love";

                // convert to dynamic 
                variables.PConnectionString = "Data Source=JOINCODER-SV;Initial Catalog=HMS_TAX;User ID=sa;Password=love;";
                variables.Pcon.ConnectionString = variables.PConnectionString;
                variables.Pcon.Open();
                variables.Pcon.Close();

                txtUserName.Focus();

            }
            catch { }
        }


        bool isOk()
        {
            if (txtUserName.Text.Trim() == string.Empty)
            {
                // check user info 
                MessageBox.Show(variables.vMsg_user, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                // check user password 
                MessageBox.Show(variables.vMsg_user, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            return true;
        }
 
        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOk()==true)
                {

                    DataTable dt = new DataTable();
                    List<parasql> arr = new List<parasql>();
                    arr.Add(new parasql { paraname = "@vUserlogin", sqltype = SqlDbType.NVarChar, values = txtUserName.Text.Trim() });
                    dt = sql.Data_Execute("proc_user_login", arr);

                    if (dt.Rows.Count > 0)
                    {
                        bool vpwd = xml_security.ComparePasswords(dt.Rows[0]["user_pwd"].ToString(), txtPassword.Text.ToString());
                        if (vpwd == true)
                        {

                            variables.PBranchCode = dt.Rows[0]["branchcode"].ToString();
                            variables.PInputter = dt.Rows[0]["user_login"].ToString();
                            variables.PProfileID = dt.Rows[0]["profile_id"].ToString();
                            variables.PProfileTitle = dt.Rows[0]["pro_name"].ToString();
                            variables.PUser_ID = dt.Rows[0]["user_id"].ToString();


                            FrmMain Main = new FrmMain();
                            this.Hide();
                            Main.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(variables.vMsg_user_Invalid, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(variables.vMsg_user_Invalid, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
