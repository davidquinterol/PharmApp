using CapaDatos.Repositorios;
using Microsoft.Azure.Cosmos.Serialization.HybridRow;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;

namespace CapaDatos.Repositorios
{
    public abstract class RepositorioMaestro : Repositorio
    {
        protected List<SqlParameter> _parameters;

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
                    foreach (SqlParameter item in _parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    _parameters.Clear();
                    return result;
                }
            }
        }

        protected DataTable ExecuteReader(string transactSql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    command.Connection = conexion;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Close();
                        return tabla;
                    }
                }
            }
        }

        protected DataTable ExecuteReaderParameter(string transactSql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    command.Connection = conexion;
                    foreach (SqlParameter item in _parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Close();
                        return tabla;
                    }
                }
            }
        }
    }
}
