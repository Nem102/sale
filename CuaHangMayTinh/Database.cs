using Microsoft.Data.SqlClient;

namespace CuaHangMayTinh
{
    public static class DbHelper
    {
        private static readonly string connectionString =
            @"Data Source=.;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
