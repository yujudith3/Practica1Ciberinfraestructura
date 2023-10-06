using System.Text.RegularExpressions;

namespace formularioJN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");

            if (string.IsNullOrEmpty(txtcontrasenauno.Text) &&
                string.IsNullOrEmpty(txtcontrasenados.Text))

            {
                MessageBox.Show("*los campos estan vacios");
                return;
            }

            //condicional que valida
            //si no son iguales los textos contenidos
            //el signo de exclamacion indica negacion
            if (txtcontrasenauno.Text.Equals(txtcontrasenados.Text))
            {
                MessageBox.Show("Bienvenido");
                return;
            }
            if (txtcontrasenauno.Text != (txtcontrasenados.Text))
            {
                MessageBox.Show("las contraseñas no son iguales");
                return;
            }
        }
    }
}