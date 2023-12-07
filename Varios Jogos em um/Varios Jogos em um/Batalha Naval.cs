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
    public partial class Batalha_Naval : Form
    {
        Thread menuBatalhaNaval;

        string turno = "Jogador1";

        int pontosJogador1 = 0;
        int pontosJogador2 = 0;

        int vitoriasJogador1;
        int vitoriasJogador2;

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "n", "r",  "r", "r", "n", "n", "r", "r",
            "r", "n", "n", "r", "n", "r", "r", "r",
            "n", "n", "r", "r", "r", "r", "r", "r",
            "r", "n", "n", "r", "n", "r", "r", "r",
            "r", "n", "r", "n", "r", "r", "r", "r",
            "n", "r", "r", "n", "n", "r", "r", "n",
            "r", "r", "r", "r", "r", "n", "r", "r",
            "n", "r", "r", "r", "n", "r", "r", "r"
        };

        public Batalha_Naval()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        private void MenuBatalhaNaval(object obj)
        {
            Application.Run(new BatalhaNavalMenu());
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            menuBatalhaNaval = new Thread(MenuBatalhaNaval);
            menuBatalhaNaval.SetApartmentState(ApartmentState.STA);
            menuBatalhaNaval.Start();
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }

            // Pontuação
            if (turno == "Jogador1" && clickedLabel.Text == "n")
            {
                pontosJogador1++;
                LblPontosJogador1.Text = pontosJogador1.ToString();
            }
            else if (turno == "Jogador2" && clickedLabel.Text == "n")
            {
                pontosJogador2++;
                LblPontosJogador2.Text = pontosJogador2.ToString();
            }

            CondicaoVitoria();

            CondicaoEmpate();

            // Alternar Turnos
            if (turno == "Jogador1")
            {
                LblTurno.Text = "Jogador2";
                turno = "Jogador2";
            }
            else
            {
                LblTurno.Text = "Jogador1";
                turno = "Jogador1";
            }            
        }

        private void CondicaoVitoria()
        {
            if (pontosJogador1 > 10)
            {
                vitoriasJogador1++;
                ResetarPontuacaoJogadores();
                LblVitoriasJogador1.Text = vitoriasJogador1.ToString();
                DesabilitarLabels();
                MessageBox.Show($"Parabéns!!! O vencedor é {turno}", "Fim de Jogos");
            }
            else if (pontosJogador2 > 10)
            {
                vitoriasJogador2++;
                ResetarPontuacaoJogadores();
                LblVitoriasJogador2.Text = vitoriasJogador2.ToString();
                DesabilitarLabels();
                MessageBox.Show($"Parabéns!!! O vencedor é {turno}", "Fim de Jogos");
            }            
        }

        private void CondicaoEmpate()
        {
            if (pontosJogador1 == 10 && pontosJogador2 == 10)
            {
                ResetarPontuacaoJogadores();
                DesabilitarLabels();
                MessageBox.Show("Que Pena... Niguém ganhou!!!", "Fim de Jogos");
            }
        }

        private void ResetarPontuacaoJogadores()
        {
            pontosJogador1 = 0;
            pontosJogador2 = 0;
            LblPontosJogador1.Text = 0.ToString();
            LblPontosJogador2.Text = 0.ToString();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            LblTurno.Text = "Jogador1";

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.ForeColor = iconLabel.BackColor;
                }
            }

            AdicionadoItensNaListaDeIcons();

            HabilitarLabels();

            AssignIconsToSquares();
        }

        private void AdicionadoItensNaListaDeIcons()
        {
            List<string> iconsRestart = new List<string>()
            {
                "n", "r",  "r", "r", "n", "n", "r", "r",
                "r", "n", "n", "r", "n", "r", "r", "r",
                "n", "n", "r", "r", "r", "r", "r", "r",
                "r", "n", "n", "r", "n", "r", "r", "r",
                "r", "n", "r", "n", "r", "r", "r", "r",
                "n", "r", "r", "n", "n", "r", "r", "n",
                "r", "r", "r", "r", "r", "n", "r", "r",
                "n", "r", "r", "r", "n", "r", "r", "r"
             };
            foreach (var item in iconsRestart)
            {
                icons.Add(item);
            }
        }

        private void DesabilitarLabels()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.Enabled = false;
                }
            }
        }

        private void HabilitarLabels()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.Enabled = true;
                }
            }
        }
    }
}
