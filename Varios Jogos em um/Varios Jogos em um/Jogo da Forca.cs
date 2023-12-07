using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Varios_Jogos_em_um
{
    public partial class Jogo_da_Forca : Form
    {
        Thread menu;

        public Jogo_da_Forca()
        {
            InitializeComponent();
        }

        private void telaMenu(object obj)
        {
            Application.Run(new Menu());
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(telaMenu);
            menu.SetApartmentState(ApartmentState.STA);
            menu.Start();
        }
    }
}
