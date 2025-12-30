using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.Function;
using HMS_TAX.UserDefined;
using System;
using System.Collections;
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
    public partial class FrmUserAccounts : KryptonForm
    {
        public FrmUserAccounts()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vprofile = string.Empty;
        string vuser_id = string.Empty;
        void Profile()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    "load_profile",
                    variables.PBranchCode
                };
                dt = sql.proc_getdata("proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tvProfile.Nodes[0].Nodes.Add(dt.Rows[i]["name"].ToString());
                        tvProfile.Nodes[0].Nodes[i].Tag = dt.Rows[i]["id"].ToString();
                    }
                }
            }
            catch { }
        }

        void load_user(string vprofile)
        {
            try
            {
                DataTable user = new DataTable();
                string[] p = {
                    "load_user_by_profile",
                    variables.PBranchCode,
                    vprofile
                };
                user = sql.proc_getdata("proc_get_sql", p);
                dgView.Rows.Clear();

                if (user.Rows.Count > 0)
                {
                    vuser_id = string.Empty;

                    for (int i = 0; i < user.Rows.Count; i++)
                    {
                        dgView.Rows.Add(
                           user.Rows[i]["user_id"].ToString(),
                           user.Rows[i]["user_login"].ToString(),
                           user.Rows[i]["pro_name"].ToString(),
                           user.Rows[i]["status"].ToString()
                       );
                    }
                }
            }
            catch { }
        }

        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgView.Columns.Count; i++)
                {
                    dgView.Columns[i].ReadOnly = true;
                    dgView.Columns[i].Width = 140;
                }

                dgView.Columns["vNum"].Width = 66;
                dgView.Columns["vusername"].Width = 166;
                dgView.Columns["vuserprofile"].Width = 166;
                dgView.Columns["vactive"].Width = 88;

                this.dgView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;


                this.dgView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgView.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgView.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }


        private void FrmUserAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Profile();
                FormatDataGridview();
            }
            catch { }
        }

        private void tvProfile_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                vprofile = string.Empty;
                TreeNode node = tvProfile.SelectedNode;

                if (node != null)
                {
                    if (e.Node.Tag != null)
                    {
                        vprofile = e.Node.Tag.ToString();
                        load_user(vprofile);
                    }
                }
            }
            catch { }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vuser_id = dgView["vNum", e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            if (vuser_id != string.Empty)
            {
                _active_user.Enabled = true;
                _disable_user.Enabled = true;
                _create_user.Enabled = true;
                _change_profile.Enabled = true;
                _change_password.Enabled = true;

            }
            else
            {
                _active_user.Enabled = false;
                _disable_user.Enabled = false;
                _create_user.Enabled = false;
                _change_profile.Enabled = false;
                _change_password.Enabled = false;
            }

            if (vprofile !=string.Empty)
            {
                _create_user.Enabled = true;
            }
        }

        private void _create_user_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegisterUsers Users = new FrmRegisterUsers();
                Users.Status = "create_user";
                Users.StartPosition = FormStartPosition.CenterParent;
                Users.Pro_ID = vprofile;
                Users.ShowDialog();

                load_user(vprofile);
                this.Show();
            }
            catch { }
        }

        private void _active_user_Click(object sender, EventArgs e)
        {
            try
            {

                if (vuser_id != string.Empty)
                {
                    string[] p = {
                    "Active",
                    vuser_id,
                    variables.PBranchCode,
                    "1" };
                    sql.proc_getdata("pro_edit_user", p);

                    load_user(vprofile);
                    MessageBox.Show("User information updated !! ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch { }
        }

        private void _disable_user_Click(object sender, EventArgs e)
        {
            try
            {

                if (vuser_id != string.Empty)
                {
                    string[] p = {
                    "Active",
                    vuser_id,
                    variables.PBranchCode,
                    "0" };
                    sql.proc_getdata("pro_edit_user", p);
                    load_user(vprofile);
                    MessageBox.Show("User information updated !! ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void _change_profile_Click(object sender, EventArgs e)
        {
            try
            {
                FrmChangeProfile Users = new FrmChangeProfile();
                Users.StartPosition = FormStartPosition.CenterParent;
                Users.Pro_ID = vprofile;
                Users.User_ID = vuser_id;
                Users.ShowDialog();

                load_user(vprofile);
                this.Show();
            }
            catch { }
        }
 

        private void _change_password_Click(object sender, EventArgs e)
        {
            try
            {
                FrmChangePassword Users = new FrmChangePassword();
                Users.StartPosition = FormStartPosition.CenterParent;
                Users.Pro_ID = vprofile;
                Users.User_ID = vuser_id;
                Users.ShowDialog();
                this.Show();
            }
            catch { }
        }
    }
}
