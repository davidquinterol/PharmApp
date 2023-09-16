using Pharmapp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pharmapp
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        private void ingresarBtt_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader inicioSesion = new StreamReader(regiusuarioTxt.Text + ".txt");
                if (inicioSesion.ReadLine() == regispassTxt.Text)
                {
                    MessageBox.Show("Se ha iniciado sesión");
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Hubo un error" + z, "Error");

            }

            var form = new pharmApp();
            form.Show();
            Hide();
        }

        private void registrarseBtt_Click_1(object sender, EventArgs e)
        {
            var form = new registroPersona();
            form.Show();
            Hide();
        }

        private void exitBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}