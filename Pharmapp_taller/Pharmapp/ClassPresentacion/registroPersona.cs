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

namespace Pharmapp.Properties
{
    public partial class registroPersona : Form
    {
        public registroPersona()
        {
            InitializeComponent();
        }

        private void guardarBtt_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter registrarUsuario = new StreamWriter(@"C:\Users\usuario\Desktop\Pharmapp_taller\Pharmapp\Pharmapp\bin\Debug\" + regiusuarioTxt.Text + ".txt", true);
                registrarUsuario.WriteLine(regispassTxt.Text);

                MessageBox.Show("Se ha registrado correctamente");

                var form = new inicioSesion();
                form.Show();
                Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un Error" + x, "Error");
            }
        }

        private void exitBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
