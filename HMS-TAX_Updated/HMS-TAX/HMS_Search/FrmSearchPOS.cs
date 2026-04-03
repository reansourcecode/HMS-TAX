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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace HMS_TAX.HMS
{
    public partial class FrmSearchPOS : KryptonForm
    {
        public FrmSearchPOS()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        public string PStatus = string.Empty;
        public string PCode = string.Empty;
        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        public string Code
        {
            get { return PCode; }
            set { PCode = value; }
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

                dgView.Columns["vNum"].Width = 50;
                dgView.Columns["vrcp_num"].Width = 166;
                dgView.Columns["vcustomer"].Width = 166;
                dgView.Columns["vstatus"].Width = 88;
                dgView.Columns["vinputter"].Width = 150;

                //dgView.Columns["vIsdraft"].Visible = false; //
                
                //txtTypeCode vinputter
                this.dgView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;


                this.dgView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgView.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgView.DefaultCellStyle.ForeColor = Color.Black;
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
                     vSearch,
                     variables.pos_flag
                    };
                dgView.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql_search", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgView.Rows.Add(
                            (i+1).ToString(),
                            dblist.Rows[i]["rcp_num"].ToString(),
                            dblist.Rows[i]["cus_name"].ToString(),
                            dblist.Rows[i]["status"].ToString() ,
                            dblist.Rows[i]["inputter"].ToString()
                        );
                    }

                    _POS_delete.Enabled = false;
                }
            }
            catch { }
        }
        private void FrmSearchPOS_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                FormatDataGridview();
                load_view(PStatus, PCode);

            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                load_view(PStatus, txtSearch.Text.Trim());
            }
            catch { }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgView["vrcp_num", e.RowIndex].Value.ToString();

               
            }
            catch { }
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgView["vrcp_num", e.RowIndex].Value.ToString();

                
                this.Close();
            }
            catch { }
        }

        private void _POS_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (PCode.Trim() == string.Empty)
                {
                    MessageBox.Show("Please select a transaction you want to delete.", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (MessageBox.Show("Do you want to delete :" + Code + "  ?", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        DataTable dt = new DataTable();
                        List<parasql> arr = new List<parasql>();
                        arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "del_draf_pos" });
                        arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                        arr.Add(new parasql { paraname = "@vPOS_ID", sqltype = SqlDbType.NVarChar, values = PCode });
                        arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                        dt = sql.Data_Execute("proc_auth_pos", arr);

                      
                        load_view(PStatus, txtSearch.Text.Trim());
                    }
                }

            }
            catch { }
        }

        private void _MenuFunction_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                string v = PCode.Substring(0, 3).ToLower();
                if (PCode.Substring(0, 3).ToLower() == "dra")
                {
                    _POS_delete.Enabled = true;
                }
                else
                {
                    _POS_delete.Enabled = false;
                }
            }
            catch { }
        }
    }
}
