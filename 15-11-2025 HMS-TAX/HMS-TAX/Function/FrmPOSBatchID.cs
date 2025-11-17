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
    public partial class FrmPOSBatchID : KryptonForm
    {
        public FrmPOSBatchID()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();


        public string PStatus = string.Empty;
        public string PCode = string.Empty;
        public string PSysDocNum = string.Empty;

        public string SysDocNum
        {
            get { return PSysDocNum; }
            set { PSysDocNum = value; }
        }

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


        void load_batch_id()
        {
            try
            {
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();

                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = "batch_id_menu" });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = Code });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });
                dt = sql.Data_Execute("proc_get_sql_pos", arr);
                if (dt.Rows.Count > 0)
                {
                    cboBatchID.DataSource = dt;
                    cboBatchID.DisplayMember = "batch_id";
                    cboBatchID.ValueMember = "batch_id";
                }
            }
            catch { }
        }

        void view_data(string vStatus,string vCode)
        {
            try
            {
                int Qty = 0;
                DataTable dt = new DataTable();
                List<parasql> arr = new List<parasql>();
                arr.Add(new parasql { paraname = "@vstatus", sqltype = SqlDbType.NVarChar, values = vStatus });
                arr.Add(new parasql { paraname = "@vBranchcode", sqltype = SqlDbType.NVarChar, values = variables.PBranchCode });
                arr.Add(new parasql { paraname = "@vcode1", sqltype = SqlDbType.NVarChar, values = vCode });
                arr.Add(new parasql { paraname = "@vInputter", sqltype = SqlDbType.NVarChar, values = variables.PInputter });

                dt = sql.Data_Execute("proc_get_sql_pos", arr);

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["pro_name"].ToString();
                    cboStock.SelectedValue = dt.Rows[0]["sto_id"].ToString();

                    int.TryParse(dt.Rows[0]["qty"].ToString(), out Qty);
                    txtQty.Text = String.Format("{0:0}", Qty).ToString();

                }
            }
            catch { }
        }
        private void FrmPOSBatchID_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                sql.Filter_ComboBox(cboStock, "exec proc_get_sql_pos  'stock_menu','" + variables.PBranchCode + "','%'", "name", "code");
             
                view_data(Status, SysDocNum);

            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
