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

namespace HMS_TAX.Setting
{
    public partial class FrmBackup : KryptonForm
    {
        public FrmBackup()
        {
            InitializeComponent();
        }
        DateTime Date = DateTime.Now;
        string dbname=String.Empty;
        sqlexcute sql = new sqlexcute();


        private const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }
        private void FrmBackup_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                  dbname = variables.PDatabaseName;
                this.TxtFileName.Enabled = false;
                TxtLocaiton.Enabled = false;

                //TxtFileName.Text = dbname + " " + "Date " + Date.ToString("dd-MM-yyy") + " Time " + Date.ToString("H-mm-ss");
                TxtFileName.Text = dbname + " " + "Date " + Date.ToString("dd-MM-yyy") + "-" + Date.ToString("H-mm-ss");
                this.Text = "Backup DATABASE ";
            }
            catch { }
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            try
            {
                TxtLocaiton.Text = "";
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Select a folder";
                    dialog.ShowNewFolderButton = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        TxtLocaiton.Text= dialog.SelectedPath;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstring = "";
                string FileName = "";
                if (TxtLocaiton.Text == "")
                {
                    MessageBox.Show("Please select drive location ! ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TxtFileName.Text == "")
                {
                    MessageBox.Show("Please Inputer file name ! ", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FileName = TxtLocaiton.Text + "\\" + TxtFileName.Text + ".bak";
                    sqlstring = "BACKUP DATABASE " + dbname + " TO  DISK ='" + FileName + "'";
                    try
                    {
                        sql.ds_getdata(sqlstring);
                        MessageBox.Show("Backup completed successfully. Please check your backup path.", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch { }
                }
            }
            catch { }
        }
    }
}
