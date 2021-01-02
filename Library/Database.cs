using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = "data source = DESKTOP-118E5D9\\SQL2014; database = Library; integrated security = true";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
