using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HMS_TAX.UserDefined
{
    class parasql
    {
        public string paraname { get; set; }
        public SqlDbType sqltype { get; set; }
        public dynamic values { get; set; }
    }
}
