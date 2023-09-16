using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Repositorios
{
    public abstract class RepositorioBase
    {
        protected int ExecuteNonQuery(string transactSql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    command.Connection = conexion;
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        protected abstract SqlConnection GetConnection();
    }
}
