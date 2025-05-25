using Kye.SistemasRegistros.CasosUso.Usuarios;

namespace Kye.SistemasRegistros.Win
{
    public partial class LoginForm : Form
    {
        Login _login;

        public LoginForm(Login login, AgregarUsuario agregarUsuario)
        {
            InitializeComponent();
            _login = login;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {   
            this.Cursor = Cursors.WaitCursor;
            btnIngresar.Enabled = false;

            var ingresar = await _login.Autenticar(txtUsuario.Text, txtPassword.Text);

            if (ingresar.accion)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnIngresar.Enabled = true;
            this.Cursor = Cursors.Default;

        }
    }
}
