using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    class DBC
    {

        public static SqlConnection getConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-PF9NVK5;Initial Catalog=PMS;Integrated Security=True;Pooling=False");
        }
    }
}