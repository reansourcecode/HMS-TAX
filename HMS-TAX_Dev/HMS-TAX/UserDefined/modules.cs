using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_TAX.UserDefined
{
    internal class modules
    {

        sqlexcute sql = new sqlexcute();

        public float pos_get_qty(string vstatus ,string vsysdoc, string vpro_id , string vsto_id , string vbath_id )
        {
           try
            {
                float vqty = 0;
                DataTable dt = new DataTable();
                string[] p =
                {
                    vstatus,
                    variables.PBranchCode,
                    vsysdoc,
                    vpro_id,
                    vsto_id,
                    vbath_id
                };
                dt = sql.proc_getdata("proc_pos_get_qty", p);
                if (dt.Rows.Count > 0)
                {
                    float.TryParse(dt.Rows[0]["qty"].ToString(), out vqty);
                }

                return vqty;
            }
            catch  
            {
                return 0;
            }
        }

    }
}
