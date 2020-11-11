using Cliente_Zodeiaco_WS.Usuario_CWS;
using System;
using System.Windows.Forms;

namespace Cliente_Zodeiaco_WS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Usuario_CWS.UsuarioWS usuarioWS = new Usuario_CWS.UsuarioWS();
            
            string email = emailTextBox.Text;
            usuario user = usuarioWS.loginUsuario(email);
            Console.WriteLine(email);

            if (user != null)
            {
                Session.User = user;

                this.Hide();
                Horoscopo main = new Horoscopo();
                main.ShowDialog();
                this.Close();
            } else
            {
                errorLabel.Visible = true;
            }
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroForm main = new CadastroForm();
            main.ShowDialog();
            this.Close();
        }
    }
}
