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
    public partial class FrmAboutMe : KryptonForm
    {
        public FrmAboutMe()
        {
            InitializeComponent();
        }

        private void FrmAboutMe_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text=variables.vTittle + " - About Me";

                lblInfo.Text = "Develop by : រៀនអាយធី REAN-iT  (Documentary)  ";

                lblsysteminfo.Text =  
                                     "Version: " + variables.vNewVersion + Environment.NewLine +
                                     "Release Date: " + variables.vReleaseDate + Environment.NewLine +
                                     "Developed By: JoinCoder Co., Ltd." + Environment.NewLine +
                                     "Contact: 012 888 005 ";

                lblbranchinfo.Text =
                                     "Branch Name: " + variables.PBranchCode + Environment.NewLine +
                                     "Database Name: " + variables.PDatabaseName + Environment.NewLine +
                                     "Server Name: " + variables.PServerName + Environment.NewLine;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
