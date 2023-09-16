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
    public partial class areaPQRS : Form
    {
        private object messageBoxButtons;

        public areaPQRS()
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
                    var contacto = contactoTxt.Text;
                    var direccionBarrio = direccionTxt.Text;
                    var email = emailTxt.Text;
                    var recurso = PButton.Checked ? "Petición" :
                       QButton.Checked ? "Queja" :
                       FButton.Checked ? "Felicitación" : "No Establecido";
                    var fechaPQRS = dateTime.Text;
                    var situacionPresentada = situacionTxt.Text;


                    string mensajeConfirmacion = $"Nombre Completo: {nombreCompleto}    \n" +
                                     $"ID usuario: {usuarioID}  \n" +
                                     $"Contacto: {contacto}  \n" +
                                     $"Dirección y Barrio: {direccionBarrio}    \n" +
                                     $"Presentación: {email}  \n" +
                                     $"Concentración: {recurso}  \n" +
                                     $"Cantidad Solicitada: {fechaPQRS}   \n" +
                                     $"Valor Unitario: {situacionPresentada} \n";

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
            var form = new pharmApp();
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
                errorProv.SetError(emailTxt, null);
                errorProv.SetError(PButton, null);
                errorProv.SetError(QButton, null);
                errorProv.SetError(FButton, null);
                errorProv.SetError(dateTime, null);
                errorProv.SetError(situacionTxt, null);

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
                if (string.IsNullOrEmpty(emailTxt.Text))
                {
                    errorProv.SetError(emailTxt, "Ingrese el copago");
                    return false;
                }
                if (!PButton.Checked && !QButton.Checked && !FButton.Checked)
                {
                    errorProv.SetError(FButton, "Seleccione el sexo");
                    return false;
                }
                if (dateTime.Value < DateTime.Now)
                {
                    errorProv.SetError(dateTime, "La fecha de vencimiento " + "debe ser mayor a la fecha actual");
                    return false;
                }
                if (string.IsNullOrEmpty(situacionTxt.Text))
                {
                    errorProv.SetError(situacionTxt, "Ingrese el copago");
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
