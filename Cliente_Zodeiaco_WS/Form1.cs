using Cliente_Zodeiaco_WS.CavaleiroOuroCWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Zodeiaco_WS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_CWS.CadastroWS c_cadastro = new Cadastro_CWS.CadastroWS();
            Cadastro_CWS.usuario user = new Cadastro_CWS.usuario();

            user.nickname = "Raffa";
            user.plano = "prata";
            user.signo = "libra";
            c_cadastro.cadastrarUsuario(user);

            c_cadastro.evoluirPlano(user);

            Console.WriteLine(user.plano);

            CavaleiroOuroCWS.CavaleiroOuroWS cavaleiroOuro = new CavaleiroOuroCWS.CavaleiroOuroWS();
            Console.WriteLine(cavaleiroOuro.qualCavaleiro("leao"));
        }
    }
}