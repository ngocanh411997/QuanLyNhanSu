using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.helper
{
    internal class setupConnection
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        public static class ConnectionString
        {
            public static string Connection = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
        }
    }
}
