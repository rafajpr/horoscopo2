using Cliente_Zodeiaco_WS.CavaleiroOuroCWS;
using System;
using System.Windows.Forms;

namespace Cliente_Zodeiaco_WS
{
    public partial class Horoscopo : Form
    {
        private Usuario_CWS.usuario user;
        private CavaleiroOuroWS cavaleiro;

        public Horoscopo()
        {
            InitializeComponent();

            user = Session.User;
            cavaleiro = new CavaleiroOuroWS();

            nicknameLabel.Text = Session.User.nickname;

            ouroButton.Enabled = false;

            if (Session.User.plano == "ouro")
            {
                ouroButton.Enabled = true;
            }
        }

        private void bronzeButton_Click(object sender, EventArgs e)
        {
            string message = cavaleiro.msgDia(user.signo);

            messageLabel.Text = message;
        }

        private void ouroButton_Click(object sender, EventArgs e)
        {
            string message = cavaleiro.qualCavaleiro(user.signo);

            messageLabel.Text = message;
        }
    }
}
