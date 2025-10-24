using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using HMS_TAX.UserDefined;

namespace HMS_TAX
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        void LoadChild(Form vFrm, string FrmTag)
        {
            try
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                vFrm.Tag = FrmTag;
                vFrm.MdiParent = FrmMain.ActiveForm;
                vFrm.StartPosition = FormStartPosition.CenterScreen;
                vFrm.Show();
                vFrm.Activate();
            }
            catch { }
        }
        public void Open_Frm(string vFrmName)
        {
            try
            {
                Form FormShow;
                Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\HMS_TAX.exe");
                System.Reflection.Assembly assembly1 = Assembly.LoadFile(Application.StartupPath + "\\HMS_TAX.exe");
                FormShow = (Form)assembly1.CreateInstance("HMS-TAX." + vFrmName);
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("HMS_TAX.HMS." + vFrmName);
                }
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("HMS_TAX.Setting." + vFrmName);
                }
                if (FormShow != null)
                {
                    this.AddOwnedForm(FormShow);
                    LoadChild(FormShow, FormShow.Name);
                }
            }
            catch { }
        }


        private void _logout_sub_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
            }
            catch { }
        }

        private void _Exit_sub_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _register_customer_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmCustomers");
        }

        private void _permission_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmPermission");
        }

        private void _register_product_sub_Click(object sender, EventArgs e)
        {
            Open_Frm("FrmProducts");
        }

         
    }
}
