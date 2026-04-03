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
    public partial class FrmLine : KryptonForm
    {
        public FrmLine()
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
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            cboActive.Text = string.Empty;
            cboActive.SelectedValue = "";
            btn_save_record();
        }

        void FormatDataGridview()
        {
            try
            {
                for (int i = 0; i < dgView.Columns.Count; i++)
                {
                    dgView.Columns[i].ReadOnly = true;
                }

                dgView.Columns["vNum"].HeaderText = "Nº";
                dgView.Columns["vNum"].Width = 30;
                dgView.Columns["vid"].Width = 30;
                dgView.Columns["vName"].Width = 150;
                dgView.Columns["vtype"].Width = 88;
                dgView.Columns["vstatus"].Width = 88;

                dgView.Columns["vid"].Visible = false;


                //txtTypeCode
                this.dgView.ColumnHeadersDefaultCellStyle.Font = new Font("Cooper Black", 16F, FontStyle.Bold, GraphicsUnit.Pixel);

                this.dgView.DefaultCellStyle.Font = new Font("Cooper Black", 15F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgView.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }

        private void FrmLine_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                btn_save_record();
                sql.Filter_ComboBox(cboActive, "exec pro_get_combo  'Active'", "title", "code");
                sql.Filter_ComboBox(cboType, "exec pro_get_combo  'type_of_line' , '" + variables.PBranchCode + "'", "title", "code");

                cleartext();
                load_view("search_type_line", "%");
                FormatDataGridview();
            }
            catch { }
        }


        void load_view(string vstatus, string vSearch)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                     vstatus,
                     variables.PBranchCode,
                     vSearch
                    };
                dgView.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql_search", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgView.Rows.Add(
                            (i + 1).ToString(),
                            dblist.Rows[i]["line_id"].ToString(),
                            dblist.Rows[i]["line_name"].ToString(),
                            dblist.Rows[i]["type_line"].ToString(),
                            dblist.Rows[i]["Active"].ToString()
                        );

                        dgView.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (sql.cbo_empty(cboType) == true)
                {
                    load_view("search_type_line", cboType.SelectedValue.ToString());

                }

            }
            catch { }
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
                    txtId.Text = dt.Rows[0]["line_id"].ToString();
                    txtName.Text = dt.Rows[0]["line_name"].ToString();

                    cboType.SelectedValue = dt.Rows[0]["line"].ToString();
                    cboActive.SelectedValue = dt.Rows[0]["active"].ToString();
                    btn_edit_record();
                }
                else
                {
                    MessageBox.Show(variables.vMsgNotExits, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
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
            else if (sql.cbo_empty(cboType) == false)
            {
                cboActive.Select();
                cboActive.Focus();
                MessageBox.Show("Type of line has been required !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                string vtype = cboType.SelectedValue.ToString();
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vID", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vName", sqltype = SqlDbType.NVarChar, values = txtName.Text.Trim() });
                arr.Add(new parasql { paraname = "@vType", sqltype = SqlDbType.NVarChar, values = vtype });
                arr.Add(new parasql { paraname = "@vActive", sqltype = SqlDbType.NVarChar, values = cboActive.SelectedValue.ToString() });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_register_type_line", arr);
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0]["TRANCODE"].ToString();
                    MessageBox.Show(vMsg, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_save_record();
                    cleartext();

                    load_view("search_type_line", vtype);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                P_Code = dgView["vid", e.RowIndex].Value.ToString();
                if (P_Code != string.Empty)
                {
                    GetInfor("show_type_line", P_Code);
                }
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                cleartext();
                load_view("search_type_line", "%");
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
                if (MessageBox.Show("Do you want to update " + txtId.Text.Trim() + " now ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Register("U", txtId.Text.Trim(), variables.vMsg_update);
                }
            }
        }
    }
}
