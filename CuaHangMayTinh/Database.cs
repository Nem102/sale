using Microsoft.Data.SqlClient;
using System.Configuration;

namespace CuaHangMayTinh
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["CuaHangMayTinhDB"].ConnectionString;

            return new SqlConnection(connectionString);
        }
    }
}
