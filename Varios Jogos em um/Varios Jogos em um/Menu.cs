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
    public partial class Menu : Form
    {
        Thread telas;

        public Menu()
        {
            InitializeComponent();
        }
        // 1 - Adivinhe se Puder
        private void AdivinheSePuder(object obj)
        {
            Application.Run(new AdivinheSePoderMenu());
        }

        private void BtnMenuAdivinheSePuder_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(AdivinheSePuder);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 2 - Jogo da Velha
        private void JogoDaVelha(object obj)
        {
            Application.Run(new JogoDaVelhaMenu());
        }

        private void BtnJogoDaVelha_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(JogoDaVelha);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 3 - Joga da Forca
        private void JogoDaForca(object onj)
        {
            Application.Run(new Jogo_da_Forca());
        }

        private void BtnMenuJogoDaForca_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(JogoDaForca);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 4 - Jogo da Memória
        private void JogoDaMemoria(object obj)
        {
            Application.Run(new JogoDaMemoriaMenu());
        }

        private void BtnMenuJogaDaMemoria_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(JogoDaMemoria);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 5 - Pseudo Pokemon
        private void Pokemon(object obj)
        {
            Application.Run(new PokemonMenu());
        }

        private void BtnMenuPokemon_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(Pokemon);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 6 - Pseudo Yugioh
        private void Yugioh(object obj)
        {
            Application.Run(new YuGiOhMenu());
        }

        private void BtnMenuYugioh_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(Yugioh);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 7 - Batalha Naval
        private void BatalhaNaval(object obj)
        {
            Application.Run(new BatalhaNavalMenu());
        }

        private void BtnMenuBatalhaNaval_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(BatalhaNaval);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 8 - Sequência Correta
        private void SequenciaCorreta(object obj)
        {
            Application.Run(new AdivinheASequenciaMenu());
        }

        private void BtnMenuSequenciaCorreta_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(SequenciaCorreta);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 9 - Pedra, Papel, Tesoura - Jokenpo
        private void Jokenpo(object obj)
        {
            Application.Run(new JokenpoMenu());
        }

        private void BtnMenuJokenpo_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(Jokenpo);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
        // 10 - Quiz
        private void Quiz()
        {
            Application.Run(new Quiz());
        }
        private void BtnMenuQuiz_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(Quiz);
            telas.SetApartmentState(ApartmentState.MTA);
            telas.Start();
        }
    }
}
