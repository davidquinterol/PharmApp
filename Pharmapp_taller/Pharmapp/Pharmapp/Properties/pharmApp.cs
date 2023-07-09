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
    public partial class pharmApp : Form
    {
        public pharmApp()
        {
            InitializeComponent();
        }

        private void inventarioBtt_Click(object sender, EventArgs e)
        {
            var form = new registroInventario();
            form.Show();
            Hide();
        }

        private void domisBtt_Click(object sender, EventArgs e)
        {
            var form = new areaDomis();
            form.Show();
            Hide();
        }

        private void pqrsBtt_Click(object sender, EventArgs e)
        {
            var form = new areaPQRS();
            form.Show();
            Hide();
        }
    }
}
