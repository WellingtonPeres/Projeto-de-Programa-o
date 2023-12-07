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
    public partial class JokenpoMenu : Form
    {
        Thread menu;
        Thread iniciarJKP;
        public JokenpoMenu()
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
            iniciarJKP = new Thread(IniciarJokenpo);
            iniciarJKP.SetApartmentState(ApartmentState.MTA);
            iniciarJKP.Start();
        }
        private void SairMenu(object obj)
        {
            Application.Run(new Menu());
        }
        private void IniciarJokenpo(object obj)
        {
            Application.Run(new Jokenpo());
        }
    }
}
