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
    }
}
