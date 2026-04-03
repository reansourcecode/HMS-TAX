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
    public partial class FrmSearchPaymentVoucher : KryptonForm
    {
        public FrmSearchPaymentVoucher()
        {
            InitializeComponent();
        }
        FormatGrids FG = new FormatGrids();
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
                            dblist.Rows[i]["pv_id"].ToString(),
                            dblist.Rows[i]["pay_to"].ToString(),
                            dblist.Rows[i]["option_title"].ToString(),
                            dblist.Rows[i]["receipt"].ToString()
                        );

                        dgView.Visible = true;
                    }
                }
            }
            catch { }
        }

        void FormatDataGridview()
        {
            try
            {

                FG.FormatGrid(dgView);
                //---------------------------------
                // dgView Columns 
                //---------------------------------
                FG.SetColumn(dgView, "vID", 150, true);

            }
            catch { }
        }

        private void FrmSearchPaymentVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Empty;
                load_view(PStatus, PCode);
                FormatDataGridview();
            }
            catch { }
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    load_view(PStatus, txtSearch.Text.Trim());
                }
            }
            catch { }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgView[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgView[0, e.RowIndex].Value.ToString();
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
