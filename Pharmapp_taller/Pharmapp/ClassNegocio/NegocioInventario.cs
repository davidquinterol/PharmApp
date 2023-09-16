using CapaDatos.Repositorios;
using System.Data;
using CapaEntidad;


namespace Pharmapp.Properties
{
    public class NegocioInventario : INegocioInventario
    {
        public static DataTable Listar()
        {
            ReposInventarioF datos = new ReposInventarioF();
            return datos.Listar();
        }
        public string Insertar(string usuario);
    }
}