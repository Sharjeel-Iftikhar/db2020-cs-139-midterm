using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FYP
{
    class Configuration
    {
        String ConnectionStr = @"Data Source=DESKTOP-25V2BLB\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection con;
        private static Configuration _instance;
        public static Configuration getInstance()
        {
            if (_instance == null)
                _instance = new Configuration();
            return _instance;
        }
        private Configuration()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}

