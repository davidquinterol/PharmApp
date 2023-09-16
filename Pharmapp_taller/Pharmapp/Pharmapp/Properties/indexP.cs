namespace Pharmapp
{
    public partial class indexP : Form
    {
        public indexP()
        {
            InitializeComponent();
        }

        private void ingresarBtt_Click(object sender, EventArgs e)
        {
            var form = new inicioSesion();
            form.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void indexP_Load(object sender, EventArgs e)
        {

        }
    }
}