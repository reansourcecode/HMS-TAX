using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HMS_TAX.UserDefined;

namespace HMS_TAX.Function
{
    public partial class FrmEditExpired : KryptonForm
    {
        public FrmEditExpired()
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

        private void FrmPO_Edit_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                string[] p = {
                     "UNA_PO_Edit_Expired",
                     variables.PBranchCode,
                     PCode
                    };
                dt = sql.proc_getdata("proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    vexpired_date.Value = Convert.ToDateTime(dt.Rows[0]["exp_date"]);
                }

            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vCMD", sqltype = SqlDbType.NVarChar, values = "Expired" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vSysDocNum", sqltype = SqlDbType.NVarChar, values = PCode });
                arr.Add(new parasql { paraname = "@vExpired_date", sqltype = SqlDbType.Date, values = vexpired_date.Value });
                dt = sql.Data_Execute("proc_update_PO_expired", arr);
                if (dt.Rows.Count > 0)
                {
                    this.Close();
                }

            }
            catch { this.Close(); }
        }
    }
}
