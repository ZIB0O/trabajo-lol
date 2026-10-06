using Microsoft.Data.SqlClient;
using System.Data;

namespace trabajo_de_profe_jamil_xd
{
    public static class Db
    {
        // Ajusta el Server según la compu donde estés:
        //   "."                       -> instancia por defecto
        //   ".\\SQLEXPRESS"           -> SQL Server Express
        //   "(localdb)\\MSSQLLocalDB" -> LocalDB (viene con Visual Studio)
        public static string ConnStr = @"Server=(localdb)\MSSQLLocalDB;Database=TiendaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using var cn = new SqlConnection(ConnStr);
            using var da = new SqlDataAdapter(sql, cn);
            if (ps != null) da.SelectCommand.Parameters.AddRange(ps);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int Exec(string sql, params SqlParameter[] ps)
        {
            using var cn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, cn);
            if (ps != null) cmd.Parameters.AddRange(ps);
            cn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
