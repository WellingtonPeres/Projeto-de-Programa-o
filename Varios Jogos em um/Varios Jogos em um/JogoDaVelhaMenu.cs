using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Varios_Jogos_em_um
{
    public partial class JogoDaVelhaMenu : Form
    {
        Thread menu;
        Thread jogoDaVelha;
        public JogoDaVelhaMenu()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(SairMenu);
            menu.SetApartmentState(ApartmentState.MTA);
            menu.Start();
        }
        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            jogoDaVelha = new Thread(IniciarJogoDaVelha);
            jogoDaVelha.SetApartmentState(ApartmentState.MTA);
            jogoDaVelha.Start();
        }
        private void SairMenu()
        {
            Application.Run(new Menu());
        }
        private void IniciarJogoDaVelha()
        {
            Application.Run(new Jogo_da_Velha());
        }
    }
}
