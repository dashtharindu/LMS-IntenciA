using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace LMS_IntenciA
{
    class conman
    {
        public static MySqlConnection connection()
        {
            String constr = @"server=localhost;user id=root;database=lms";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            return con;
        }
    }
}
