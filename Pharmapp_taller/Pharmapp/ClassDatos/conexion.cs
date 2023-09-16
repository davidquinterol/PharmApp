using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Azure.Cosmos;

namespace ClassDatos
{
    internal class conexion
    {
        private string Base;
        private string Servidor;
        private bool Seguridad;
        private static conexion con = null;


        private conexion()
        {
            this.Base = "pharmappDB";
            this.Servidor = "DESKTOP-S3MP41";
            this.Seguridad = true;
        }

        public SqlConnection crearconexion()
        {
            SqlConnection cadena = new SqlConnection (this.Base);
            try
            {
                cadena.ConnectionString = "Servidor=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad) 
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
            }
            catch (Exception ex) 
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static conexion crearInstancia()
        {
            if(con == null) 
            {
                con = new conexion();
            }
            return con;
        }
    }
}
