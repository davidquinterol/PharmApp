using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class inventarioReg
    {
        public int idInventariod { get; set; }
        public string idUsuario { get; set; }
        public string fechaCreacion { get; set; }
        public string nEstante { get; set; }
        public string codProducto { get; set; }
        public string nProducto { get; set; }
        public string presentacion { get; set; }
        public string concentracion { get; set; }
        public string disponible { get; set; }
        public string fechaVencimiento { get; set; }
    }
}
