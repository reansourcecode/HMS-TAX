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
using static System.Net.Mime.MediaTypeNames;

namespace HMS_TAX.HMS
{
    public partial class FrmSearchAccountPaid : KryptonForm
    {
        public FrmSearchAccountPaid()
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
                    dgView.SuspendLayout();
                    dgView.Rows.Clear();

                    foreach (DataRow row in dblist.Rows)
                    {
                        // Safe value extraction
                        string apId = row["ap_id"]?.ToString() ?? "";
                        string supName = row["sup_name"]?.ToString() ?? "";
                        string invoice = row["invoice"]?.ToString() ?? "";

                        // Safe date parsing
                        string receiptDate = "";
                        if (DateTime.TryParse(row["ap_date"]?.ToString(), out DateTime vdate))
                        {
                            receiptDate = vdate.ToString("dd/MM/yyyy");
                        }

                        dgView.Rows.Add(apId, supName, invoice, receiptDate);
                    }

                    dgView.Visible = dgView.Rows.Count > 0;
                    dgView.ResumeLayout();
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
                FG.SetColumn(dgView, "vID", 177, true);
                FG.SetColumn(dgView, "vsupply", 200, true);
                FG.SetColumn(dgView, "vinvoice", 150, true);
                FG.SetColumn(dgView, "vdate", 88, true);

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

        private void FrmSearchAccountPayable_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Payments History";
                load_view(PStatus, PCode);
                FormatDataGridview();
            }
            catch { }
        }
    }
}
