using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HMS_TAX.UserDefined;

namespace HMS_TAX.HMS
{
    public partial class FrmSearchProduct : Office2007RibbonForm
    {
        public FrmSearchProduct()
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
                for (int i = 0; i < dgSearch.Columns.Count; i++)
                {
                    dgSearch.Columns[i].ReadOnly = true;
                    dgSearch.Columns[i].Width = 140;
                }

                dgSearch.Columns["vProID"].Width = 150;
                dgSearch.Columns["vName"].Width = 150;
                dgSearch.Columns["vLine"].Width = 150;
                dgSearch.Columns["vMol"].Width = 150;
                dgSearch.Columns["vPack"].Width = 150;

                //txtTypeCode
                this.dgSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;


                this.dgSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgSearch.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgSearch.DefaultCellStyle.ForeColor = Color.Black;
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
                dgSearch.Rows.Clear();
                dblist = sql.proc_getdata("proc_get_sql_search", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgSearch.Rows.Add(
                            dblist.Rows[i]["pro_code"].ToString(),
                            dblist.Rows[i]["pro_name"].ToString(),
                            dblist.Rows[i]["line_name"].ToString(),
                            dblist.Rows[i]["Molecule"].ToString(),
                            dblist.Rows[i]["Packing"].ToString(),
                            dblist.Rows[i]["Active"].ToString()
                        );

                        dgSearch.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            try
            {
                load_view(PStatus, PCode);
                FormatDataGridview();
            }
            catch { }
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgSearch[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        
        private void dgSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgSearch[0, e.RowIndex].Value.ToString();
                this.Close();
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
    }
}
