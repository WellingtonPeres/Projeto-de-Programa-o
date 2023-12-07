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
    public partial class BatalhaNavalMenu : Form
    {
        Thread menu;
        Thread batalhaNaval;
        public BatalhaNavalMenu()
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
            batalhaNaval = new Thread(IniciarBatalhaNaval);
            batalhaNaval.SetApartmentState(ApartmentState.MTA);
            batalhaNaval.Start();
        }
        private void SairMenu()
        {
            Application.Run(new Menu());
        }
        private void IniciarBatalhaNaval()
        {
            Application.Run(new Batalha_Naval());
        }
    }
}
