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
    public partial class Jogo_da_Velha : Form
    {
        Thread menuJogoVelha;

        string turnoJogador = "X";

        int pontosJogador1 = 0;
        int pontosJogador2 = 0;

        int contagemDeRodadas = 1;

        public Jogo_da_Velha()
        {
            InitializeComponent();
        }

        private void telaMenu(object obj)
        {
            Application.Run(new JogoDaVelhaMenu());
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            menuJogoVelha = new Thread(telaMenu);
            menuJogoVelha.SetApartmentState(ApartmentState.STA);
            menuJogoVelha.Start();
        }

        private void VerificarVitoiria()
        {
            // Diagonais
            if (LblQuadrado1.Text == LblQuadrado5.Text && LblQuadrado5.Text == LblQuadrado9.Text ||
                LblQuadrado3.Text == LblQuadrado5.Text && LblQuadrado5.Text == LblQuadrado7.Text)
            {
                MessageBox.Show($"O Jogador [{turnoJogador}] ganhou!!!!!", "Parabéns");

                if (turnoJogador == "X")
                {
                    pontosJogador1 += 1;
                    LblPontosJogadorX.Text = pontosJogador1.ToString();
                    ImpedirNovasJogadas();
                }
                else
                {
                    pontosJogador2 += 1;
                    LblPontosJogadorO.Text = pontosJogador2.ToString();
                    ImpedirNovasJogadas();
                }
            }

            // Linhas
            if (LblQuadrado1.Text == LblQuadrado2.Text && LblQuadrado2.Text == LblQuadrado3.Text ||
                LblQuadrado4.Text == LblQuadrado5.Text && LblQuadrado5.Text == LblQuadrado6.Text ||
                LblQuadrado7.Text == LblQuadrado8.Text && LblQuadrado8.Text == LblQuadrado9.Text)
            {
                MessageBox.Show($"O jogador [{turnoJogador}] ganhou", "Parabéns");
                if (turnoJogador == "X")
                {
                    pontosJogador1 += 1;
                    LblPontosJogadorX.Text = pontosJogador1.ToString();
                    ImpedirNovasJogadas();
                }
                else
                {
                    pontosJogador2 += 1;
                    LblPontosJogadorO.Text = pontosJogador2.ToString();
                    ImpedirNovasJogadas();
                }
            }
            // Colunas
            if (LblQuadrado1.Text == LblQuadrado4.Text && LblQuadrado4.Text == LblQuadrado7.Text ||
                LblQuadrado2.Text == LblQuadrado5.Text && LblQuadrado5.Text == LblQuadrado8.Text ||
                LblQuadrado3.Text == LblQuadrado6.Text && LblQuadrado6.Text == LblQuadrado9.Text)
            {
                MessageBox.Show($"O jogador [{turnoJogador}] ganhou", "Parabéns");
                if (turnoJogador == "X")
                {
                    pontosJogador1 += 1;
                    LblPontosJogadorX.Text = pontosJogador1.ToString();
                    ImpedirNovasJogadas();
                }
                else
                {
                    pontosJogador2 += 1;
                    LblPontosJogadorO.Text = pontosJogador2.ToString();
                    ImpedirNovasJogadas();
                }
            }
        }

        private void VerificarEmpate()
        {
            if (contagemDeRodadas == 9)
            {
                MessageBox.Show("Infelizmente niguém ganhou!!!!!", "Que Triste");
                ImpedirNovasJogadas();
            }
        }

        private void ReiniciarJogo()
        {
            LblQuadrado1.Text = "1";
            LblQuadrado2.Text = "2";
            LblQuadrado3.Text = "3";
            LblQuadrado4.Text = "4";
            LblQuadrado5.Text = "5";
            LblQuadrado6.Text = "6";
            LblQuadrado7.Text = "7";
            LblQuadrado8.Text = "8";
            LblQuadrado9.Text = "9";
        }

        private void ImpedirNovasJogadas()
        {
            LblQuadrado1.Enabled = false;
            LblQuadrado2.Enabled = false;
            LblQuadrado3.Enabled = false;
            LblQuadrado4.Enabled = false;
            LblQuadrado5.Enabled = false;
            LblQuadrado6.Enabled = false;
            LblQuadrado7.Enabled = false;
            LblQuadrado8.Enabled = false;
            LblQuadrado9.Enabled = false;
        }

        private void PermitirNovasJogadas()
        {
            LblQuadrado1.Enabled = true;
            LblQuadrado2.Enabled = true;
            LblQuadrado3.Enabled = true;
            LblQuadrado4.Enabled = true;
            LblQuadrado5.Enabled = true;
            LblQuadrado6.Enabled = true;
            LblQuadrado7.Enabled = true;
            LblQuadrado8.Enabled = true;
            LblQuadrado9.Enabled = true;
        }

        private void LabelMouse_Click(object sender, MouseEventArgs e)
        {
            Label clickLabel = sender as Label;

            foreach (Control control in TlpTabuleiroJogo.Controls)
            {
                if (clickLabel.Text == "X" || clickLabel.Text == "O")
                {
                    return;
                }
                else
                {
                    clickLabel.Text = turnoJogador;
                }

                VerificarVitoiria();
                VerificarEmpate();

                if (turnoJogador == "X")
                {
                    turnoJogador = "O";
                    LblTurnoJogador.Text = turnoJogador;
                    contagemDeRodadas += 1;
                }
                else
                {
                    turnoJogador = "X";
                    LblTurnoJogador.Text = turnoJogador;
                    contagemDeRodadas += 1;
                }
            }
        }

        private void BtnJogarNovamente_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
            PermitirNovasJogadas();
            contagemDeRodadas = 1;
        }
    }
}
