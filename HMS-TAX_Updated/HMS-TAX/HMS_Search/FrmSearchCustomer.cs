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
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS_TAX.HMS
{
    public partial class FrmSearchCustomer : KryptonForm
    {
        public FrmSearchCustomer()
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
        void FormatDataGridview()
        {
            try
            {

                FG.FormatGrid(dgView);
                //---------------------------------
                // dgView Columns 
                //---------------------------------
                FG.SetColumn(dgView, "vCusID", 150, true);
                FG.SetColumn(dgView, "vName", 200, true);
                FG.SetColumn(dgView, "vPhone", 200, true);
                FG.SetColumn(dgView, "vStatus", 100, true);

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
                            dblist.Rows[i]["cus_id"].ToString(),
                            dblist.Rows[i]["cus_name"].ToString(),
                            dblist.Rows[i]["phone"].ToString(),
                            dblist.Rows[i]["Active"].ToString()
                        );

                        dgView.Visible = true;
                    }
                }
            }
            catch { }
        }
        private void FrmSearchCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text=variables.vTittle+" - Search Customer";
                load_view(PStatus, PCode);
                FormatDataGridview();
            }
            catch { }
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgView[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                load_view(PStatus, txtSearch.Text.Trim());
            }
            catch { }
        }

        private void dgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PCode = dgView[0, e.RowIndex].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}
