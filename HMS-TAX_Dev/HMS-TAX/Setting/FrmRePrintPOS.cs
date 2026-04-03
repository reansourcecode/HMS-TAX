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

namespace HMS_TAX.Setting
{
    public partial class FrmRePrintPOS : KryptonForm
    {
        public FrmRePrintPOS()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        print_invoice print = new print_invoice();
        modules mod = new modules();

        public string PStatus = string.Empty;
        public string P_Code = string.Empty;
        public string P_InvoiceType = string.Empty;
        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }


        public string InvoiceType
        {
            get { return P_InvoiceType; }
            set { P_InvoiceType = value; }
        }

        public string Code
        {
            get { return P_Code; }
            set { P_Code = value; }
        }
        private void FrmRePrintPOS_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                btnPrint.Enabled = false;
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
                    btnPrint.Enabled = true;
                    lblInfo.Text = dt.Rows[0]["info"].ToString();
                    this.Code = dt.Rows[0]["rcp_num"].ToString();
                    this.InvoiceType = dt.Rows[0]["flag"].ToString();

                }
                else
                {
                    MessageBox.Show(variables.vMsgNotExits, variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }
        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetInfor("rePrint_POS", txtInvoice.Text.Trim());
            }
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            lblInfo.Text = "info";
            this.Code=String.Empty;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to export only to Excel? ", variables.vTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    print.RePrintExcelOnly("pos_re_print", this.Code, this.InvoiceType);
                }
                else
                {
                    print.RePrintPOS("pos_re_print", this.Code, this.InvoiceType);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
