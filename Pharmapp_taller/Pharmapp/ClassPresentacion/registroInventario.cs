using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmapp.Properties
{
    public partial class registroInventario : Form
    {
        public registroInventario()
        {
            InitializeComponent();
        }

        private void guardarInBtt_Click(object sender, EventArgs e, MessageBoxButtons messageBoxButtons)
        {
            try
            {
                if (ValidarDatos)
                {
                    var fechaInventario = fechaInvTxt.Text;
                    var numeroEstante = estanteTxt.Text;
                    var codigoProducto = codProductoTxt.Text;
                    var nombreProducto = productoTxt.Text;
                    var presentacion = listBoxPresenta.SelectedItem as string;
                    var concentracion = concentracionTxt.Text;
                    var cantidadDisponible = cantidadTxt.Text;
                    var fechaVencimiento = dateTime.Text;
                    //decimal copago = 0;
                    //decimal.TryParse(copagoTxt.Text, out copago);

                    string mensajeConfirmacion = $"Fecha de Registro: {fechaInventario}    \n" +
                                     $"Número de Estante: {numeroEstante}  \n" +
                                     $"Código de Producto: {codigoProducto}    \n" +
                                     $"Nombre del Producto: {nombreProducto}  \n" +
                                     $"Presentación: {presentacion}  \n" +
                                     $"Concentración: {concentracion}  \n" +
                                     $"Cantidad Disponible: {cantidadDisponible}   \n" +
                                     $"Fecha de Vencimiento: {fechaVencimiento} \n";

                    MessageBox.Show(mensajeConfirmacion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor revisar los datos ingresados");
                    this.Text = string.Empty;
                    messageBoxButtons.Equals(MessageBoxButtons.OK);
#pragma warning disable CS0219 // La variable está asignada pero nunca se usa su valor
                    MessageBoxIcon icon = MessageBoxIcon.Error;
#pragma warning restore CS0219 // La variable está asignada pero nunca se usa su valor
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Por favor revisar los datos ingresados" + x.Message);
                this.Text = string.Empty;
                messageBoxButtons.Equals(MessageBoxButtons.OK);
#pragma warning disable CS0219 // La variable está asignada pero nunca se usa su valor
                MessageBoxIcon icon = MessageBoxIcon.Error;
            }

        }



        private void exitBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarDatos
        {
            get
            {
                errorProv.SetError(fechaInvTxt, null);
                errorProv.SetError(estanteTxt, null);
                errorProv.SetError(codProductoTxt, null);
                errorProv.SetError(productoTxt, null);
                errorProv.SetError(listBoxPresenta, null);
                errorProv.SetError(concentracionTxt, null);
                errorProv.SetError(cantidadTxt, null);
                errorProv.SetError(dateTime, null);

                if (string.IsNullOrEmpty(fechaInvTxt.Text))
                {
                    errorProv.SetError(fechaInvTxt, "Ingrese el primer nombre");
                    return false;
                }
                if (string.IsNullOrEmpty(estanteTxt.Text))
                {
                    errorProv.SetError(estanteTxt, "Ingrese primer apellido");
                    return false;
                }
                if (string.IsNullOrEmpty(codProductoTxt.Text))
                {
                    errorProv.SetError(codProductoTxt, "Ingrese número de ID");
                    return false;
                }
                if (string.IsNullOrEmpty(productoTxt.Text))
                {
                    errorProv.SetError(productoTxt, "Ingrese el copago");
                    return false;
                }
                if (listBoxPresenta.SelectedItem == null)
                {
                    errorProv.SetError(listBoxPresenta, "Seleccione tipo de documento");
                    return false;
                }
                if (string.IsNullOrEmpty(concentracionTxt.Text))
                {
                    errorProv.SetError(concentracionTxt, "Ingrese el copago");
                    return false;
                }
                if (string.IsNullOrEmpty(cantidadTxt.Text))
                {
                    errorProv.SetError(cantidadTxt, "Ingrese el copago");
                    return false;
                }
                for (int i = 0; i < cantidadTxt.Text.Length; i++)
                {
                    if (cantidadTxt.Text[i] != '0' && cantidadTxt.Text[i] != '1' &&
                        cantidadTxt.Text[i] != '2' && cantidadTxt.Text[i] != '3' &&
                        cantidadTxt.Text[i] != '4' && cantidadTxt.Text[i] != '5' &&
                        cantidadTxt.Text[i] != '6' && cantidadTxt.Text[i] != '7' &&
                        cantidadTxt.Text[i] != '8' && cantidadTxt.Text[i] != '9')
                    {
                        errorProv.SetError(cantidadTxt, "La cantidad disponible debe tener números solamente");
                        return false;
                    }
                }
                if (dateTime.Value < DateTime.Now)
                {
                    errorProv.SetError(dateTime, "La fecha de vencimiento " + "debe ser mayor a la fecha actual");
                    return false;
                }
                return true;
            }
        }
    }
}
