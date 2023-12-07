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
    public partial class AdivinheSePoderMenu : Form
    {
        Thread menu;
        Thread iniciarJogo;
        public AdivinheSePoderMenu()
        {
            InitializeComponent();
        }

        private void tbn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(SairMenu);
            menu.SetApartmentState(ApartmentState.MTA);
            menu.Start();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            iniciarJogo = new Thread(IniciarAdivinheSePuder);
            iniciarJogo.SetApartmentState(ApartmentState.MTA);
            iniciarJogo.Start();
        }
        private void IniciarAdivinheSePuder(object obj)
        {
            Application.Run(new AdivinheSePuder());
        }
        private void SairMenu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
