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
    public partial class AdivinheSePuder : Form
    {
        Thread menu;

        int numeroSorteado;
        int numeroTentativas = 3;

        public AdivinheSePuder()
        {
            InitializeComponent();
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(telaMenu);
            menu.SetApartmentState(ApartmentState.STA);
            menu.Start();
        }

        private void telaMenu(object obj)
        {
            Application.Run(new Menu());
        }

        private void BtnGerarValorAleatorio_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numeroSorteado = rand.Next(0, 10);
            BtnGerarValorAleatorio.Enabled = false;
            TxtChutarValorAleatorio.Enabled = true;
            LtbNumerosTentados.Items.Clear();
            numeroTentativas = 3;
            LblNumeroTentativas.Text = numeroTentativas.ToString();

            LblTituloInterativo.Text = "Estou pensando em um número de 0 a 10. " +
                                       "Tente adivinhar...";
        }

        private void TxtChutarValorAleatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && TxtChutarValorAleatorio.Text != "")
            {
                e.SuppressKeyPress = true;
                if (int.Parse(TxtChutarValorAleatorio.Text) == numeroSorteado)
                {
                    MessageBox.Show("VOCÊ ACERTOU!!!", "PARABÉNS");
                    TxtChutarValorAleatorio.Enabled = false;
                    BtnGerarValorAleatorio.Enabled = true;
                }
                else if (int.Parse(TxtChutarValorAleatorio.Text) > numeroSorteado)
                {
                    VerificacaoDeDerrota();
                    LblTituloInterativo.Text = "Que pena... Você errou!!!" +
                                               "O número que eu pensei é menor.";
                    numeroTentativas--;
                    LblNumeroTentativas.Text = numeroTentativas.ToString();
                }
                else
                {
                    VerificacaoDeDerrota();
                    LblTituloInterativo.Text = "Que pena... Você errou!!!" +
                                               "O número que eu pensei é maior.";
                    numeroTentativas--;
                    LblNumeroTentativas.Text = numeroTentativas.ToString();
                }
                LtbNumerosTentados.Items.Add(TxtChutarValorAleatorio.Text);
                TxtChutarValorAleatorio.Clear();
            }
        }

        private void VerificacaoDeDerrota()
        {
            if (numeroTentativas == 1)
            {
                MessageBox.Show("Que trisque, Você perdeu!!!", "DERROTA");
                TxtChutarValorAleatorio.Enabled = false;
                BtnGerarValorAleatorio.Enabled = true;
            }
        }
    }
}
