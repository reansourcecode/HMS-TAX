using HMS_TAX.UserDefined;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HMS_TAX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            xmls xml = new xmls();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                string s = xml.EncryptData("sa");
                //s = xml.EncryptData("System");

                s = xml.EncryptData("love");
                xml.ReadXmlLogIn(Application.StartupPath + @"\sys.xml");

                variables.Pcon.ConnectionString = variables.PConnectionString;
                variables.Pcon.Open();
                variables.Pcon.Close();
                Application.Run(new FrmLogin());
            }
            catch
            {
                MessageBox.Show("The application has a problem. Please contact the IT team. !", variables.vTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
