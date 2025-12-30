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
    public partial class FrmChangeProfile : KryptonForm
    {
        public FrmChangeProfile()
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

        private void FrmChangeProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cboActive, "exec pro_get_combo  'user_profile'", "title", "code");

                cboActive.SelectedValue = vPro_Id;  
            }
            catch { }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (vuser_id != string.Empty)
                {
                    string[] p = {
                    "PROFILE",
                    vuser_id,
                    variables.PBranchCode,
                    cboActive.SelectedValue.ToString() };
                    sql.proc_getdata("pro_edit_user", p);
                    MessageBox.Show("User profile information updated !! ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch { }
        }
    }
}
