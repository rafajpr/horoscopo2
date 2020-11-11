using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cliente_Zodeiaco_WS
{
    public partial class CadastroForm : Form
    {

        public CadastroForm()
        {
            InitializeComponent();

            comboBox_Planos.Items.AddRange(new []{ "Bronze", "Ouro" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario_CWS.usuario user = new Usuario_CWS.usuario();
            Usuario_CWS.UsuarioWS usuarioWS = new Usuario_CWS.UsuarioWS();

            if(boxNickname.TextLength > 0 && comboBox_Planos.Text != "Plano" && boxSigno.TextLength > 0)
            {
                user.nickname = boxNickname.Text;
                user.plano = comboBox_Planos.Text.ToLower();
                user.signo = boxSigno.Text;
                user.email = emailTextBox.Text;

                //adicioanr user 
                bool sucesso = usuarioWS.cadastrarUsuario(user);
                if (sucesso)
                {
                    label_confirma_cadastro.Text = "Cavaleiro cadastrado com sucesso!";
                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.ShowDialog();
                    this.Close();
                } 
                else
                {
                    label_confirma_cadastro.Text = "ERRO";
                }
            }
            else
            {
                label_confirma_cadastro.Text = "Dados errados ou incompletos";
            }
        }

        private void Signo_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm cadastro = new LoginForm();
            cadastro.ShowDialog();
            this.Close();
        }
    }
}