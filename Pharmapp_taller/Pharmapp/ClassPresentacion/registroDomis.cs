using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmapp.Properties
{
    public partial class registroDomis : Form
    {
        private readonly object messageBoxButtons;

        public registroDomis()
        {
            InitializeComponent();
        }

        private void guardarDomisBtt_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos)
                {
                    var nombreCompleto = nombreTxt.Text;
                    var usuarioID = usuarioIDTxt.Text;
                    var direccionBarrio = direccionTxt.Text;
                    var contacto = contactoTxt.Text;
                    var presentacion = listBoxPresenta.SelectedItem as string;
                    var concentracion = concentracionTxt.Text;
                    var cantidadSolicitada = cantidadSolTxt.Text;
                    var valorUnitario = valorUTxt.Text;
                    var valorTotal = valorTotalTxt.Text;
                    var domiciliario = domiciliarioTxt.Text;


                    string mensajeConfirmacion = $"Nombre Completo: {nombreCompleto}    \n" +
                                     $"ID usuario: {usuarioID}  \n" +
                                     $"Dirección y Barrio: {direccionBarrio}    \n" +
                                     $"Contacto: {contacto}  \n" +
                                     $"Presentación: {presentacion}  \n" +
                                     $"Concentración: {concentracion}  \n" +
                                     $"Cantidad Solicitada: {cantidadSolicitada}   \n" +
                                     $"Valor Unitario: {valorUnitario} \n" +
                                     $"Valor Total: {valorTotal} \n" +
                                     $"Domiciliario Encargado: {domiciliario} \n";

                    MessageBox.Show(mensajeConfirmacion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor revisar los datos ingresados");
                    this.Text = string.Empty;
                    messageBoxButtons.Equals(messageBoxButtons.ToString());
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

            var form = new areaDomis();
            form.Show();
            Hide();
        }
        private bool ValidarDatos
        {
            get
            {
                errorProv.SetError(nombreTxt, null);
                errorProv.SetError(usuarioIDTxt, null);
                errorProv.SetError(direccionTxt, null);
                errorProv.SetError(contactoTxt, null);
                errorProv.SetError(listBoxPresenta, null);
                errorProv.SetError(concentracionTxt, null);
                errorProv.SetError(cantidadSolTxt, null);
                errorProv.SetError(valorUTxt, null);
                errorProv.SetError(valorTotalTxt, null);
                errorProv.SetError(domiciliarioTxt, null);

                if (string.IsNullOrEmpty(nombreTxt.Text))
                {
                    errorProv.SetError(nombreTxt, "Ingrese el primer nombre");
                    return false;
                }
                if (string.IsNullOrEmpty(usuarioIDTxt.Text))
                {
                    errorProv.SetError(usuarioIDTxt, "Ingrese primer apellido");
                    return false;
                }
                if (string.IsNullOrEmpty(direccionTxt.Text))
                {
                    errorProv.SetError(direccionTxt, "Ingrese número de ID");
                    return false;
                }
                if (string.IsNullOrEmpty(contactoTxt.Text))
                {
                    errorProv.SetError(contactoTxt, "Ingrese el copago");
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
                if (string.IsNullOrEmpty(cantidadSolTxt.Text))
                {
                    errorProv.SetError(cantidadSolTxt, "Ingrese el copago");
                    return false;
                }
                if (string.IsNullOrEmpty(valorUTxt.Text))
                {
                    errorProv.SetError(valorUTxt, "Ingrese el copago");
                    return false;
                }
                for (int i = 0; i < valorUTxt.Text.Length; i++)
                {
                    if (valorUTxt.Text[i] != '0' && valorUTxt.Text[i] != '1' &&
                        valorUTxt.Text[i] != '2' && valorUTxt.Text[i] != '3' &&
                        valorUTxt.Text[i] != '4' && valorUTxt.Text[i] != '5' &&
                        valorUTxt.Text[i] != '6' && valorUTxt.Text[i] != '7' &&
                        valorUTxt.Text[i] != '8' && valorUTxt.Text[i] != '9')
                    {
                        errorProv.SetError(valorUTxt, "El valor unitario debe tener números solamente");
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(valorTotalTxt.Text))
                {
                    errorProv.SetError(valorTotalTxt, "Ingrese el copago");
                    return false;
                }
                for (int i = 0; i < valorTotalTxt.Text.Length; i++)
                {
                    if (valorTotalTxt.Text[i] != '0' && valorTotalTxt.Text[i] != '1' &&
                        valorTotalTxt.Text[i] != '2' && valorTotalTxt.Text[i] != '3' &&
                        valorTotalTxt.Text[i] != '4' && valorTotalTxt.Text[i] != '5' &&
                        valorTotalTxt.Text[i] != '6' && valorTotalTxt.Text[i] != '7' &&
                        valorTotalTxt.Text[i] != '8' && valorTotalTxt.Text[i] != '9')
                    {
                        errorProv.SetError(valorTotalTxt, "El valor total debe tener números solamente");
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(domiciliarioTxt.Text))
                {
                    errorProv.SetError(domiciliarioTxt, "Ingrese el copago");
                    return false;
                }
                return true;
            }
        }
        private void exitBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
