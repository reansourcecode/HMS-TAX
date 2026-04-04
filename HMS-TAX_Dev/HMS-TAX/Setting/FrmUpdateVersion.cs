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
    public partial class FrmUpdateVersion : KryptonForm
    {
        public FrmUpdateVersion()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();

        private void FrmUpdateVersion_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.vTittle;
                for (int i = 1; i <= 50; i++)
                {
                    try
                    {
                        if(!string.IsNullOrWhiteSpace(((TextBox)(this.Controls[("textBox" + i.ToString())])).Text))
                        {
                            sql.dt_getdata(((TextBox)(this.Controls[("textBox" + i.ToString())])).Text);
                        }
                    }
                    catch
                    {
                    }
                }
                sql.dt_getdata("INSERT INTO sysversions (version,date_at,tag) VALUES ('" + variables.vNewVersion + "',GETDATE(),'1')");
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
    }
}
