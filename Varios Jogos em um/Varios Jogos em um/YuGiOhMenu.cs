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
    public partial class YuGiOhMenu : Form
    {
        Thread menu;
        Thread iniciarJogo;
        public YuGiOhMenu()
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
            iniciarJogo = new Thread(IniciarYugioh);
            iniciarJogo.SetApartmentState(ApartmentState.MTA);
            iniciarJogo.Start();
        }
        private void SairMenu(object obj)
        {
            Application.Run(new Menu());
        }
        private void IniciarYugioh(object obj)
        {
            Application.Run(new Yu_gi_oh());
        }
    }
}
