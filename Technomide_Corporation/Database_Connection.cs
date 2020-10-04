using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Technomide_Corporation
{
    class Database_Connection
    {

        public static SqlConnection con;
        public Database_Connection()
        {
            con = new SqlConnection(Login_Signup.FinalConString);
        }


    }
}
