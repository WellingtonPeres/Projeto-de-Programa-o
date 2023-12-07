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
    public partial class Resultado : Form
    {
        Thread menu;
        Thread categorias;
        public Resultado(string _yourScore, int _totalScore)
        {
            InitializeComponent();
            lbl_Pontuacao.Text = _totalScore.ToString();
            lbl_Categoria.Text = _yourScore;
        }

        private void btn_JogarNovamente_Click(object sender, EventArgs e)
        {
            this.Close();
            categorias = new Thread(JogarNovamente);
            categorias.SetApartmentState(ApartmentState.MTA);
            categorias.Start();
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(SairQuiz);
            menu.SetApartmentState(ApartmentState.MTA);
            menu.Start();
        }
        private void JogarNovamente()
        {
            Application.Run(new Categorias());
        }
        private void SairQuiz()
        {
            Application.Run(new Menu());
        }
    }
}
