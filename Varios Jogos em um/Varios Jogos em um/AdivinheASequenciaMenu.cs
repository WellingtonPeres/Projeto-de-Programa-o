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
    public partial class AdivinheASequenciaMenu : Form
    {
        Thread menu;
        Thread IniciarJogo;
        public AdivinheASequenciaMenu()
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
            IniciarJogo = new Thread(JogoAdivinheASequencia);
            IniciarJogo.SetApartmentState(ApartmentState.MTA);
            IniciarJogo.Start();
        }

        private void JogoAdivinheASequencia(object obj)
        {
            Application.Run(new Sequencia_Correta());
        }
        private void SairMenu()
        {
            Application.Run(new Menu());
        }
    }
}
