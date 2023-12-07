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
    public partial class Quiz : Form
    {
        Thread menu;
        public Quiz()
        {
            InitializeComponent();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(CategoriasMenu);
            menu.SetApartmentState(ApartmentState.MTA);
            menu.Start();
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(SairMenu);
            menu.SetApartmentState(ApartmentState.MTA);
            menu.Start();
        }
        private void CategoriasMenu()
        {
            Application.Run(new Categorias());
        }
        private void SairMenu()
        {
            Application.Run(new Menu());
        }
    }
}
