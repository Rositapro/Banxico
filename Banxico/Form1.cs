namespace Banxico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "Rosalinda";
            string contrasenaCorrecta = "Rosalinda2020";

            if (txtUser.Text == usuarioCorrecto && txtPass.Text == contrasenaCorrecta)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUser.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
