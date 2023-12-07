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
    public partial class Sequencia_Correta : Form
    {
        Thread menu;

        Random random = new Random();

        List<string> sequenciaNumeros = new List<string>()
        {
        };

        int tentativas;
        int acertos;
        int erros;

        bool numero1 = true;
        bool numero2 = false;
        bool numero3 = false;
        bool numero4 = false;
        bool numero5 = false;

        public Sequencia_Correta()
        {
            InitializeComponent();

            IniciarIconsToSquares();
            DesabilitarTabelaJogo();
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

        private void IniciarIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label numberLabel = control as Label;
                if (numberLabel != null)
                {
                    numberLabel.Text = " ";
                    numberLabel.Enabled = false;
                }
            }
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label numberLabel = control as Label;
                if (numberLabel != null)
                {
                    int randomNumber = random.Next(sequenciaNumeros.Count);
                    numberLabel.Text = sequenciaNumeros[randomNumber];
                    numberLabel.ForeColor = Color.Black;
                    sequenciaNumeros.RemoveAt(randomNumber);
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }

            Label numberClick = sender as Label;

            JogadaErrada(numberClick);

            if (numero1 == true && numberClick.Text == "1")
            {
                numberClick.ForeColor = Color.Black;
                numberClick.Enabled = false;
                numero1 = false;
                numero2 = true;

            }
            else if (numero2 == true && numberClick.Text == "2")
            {
                numberClick.ForeColor = Color.Black;
                numberClick.Enabled = false;
                numero2 = false;
                numero3 = true;
            }
            else if (numero3 == true && numberClick.Text == "3")
            {
                numberClick.ForeColor = Color.Black;
                numberClick.Enabled = false;
                numero3 = false;
                numero4 = true;
            }
            else if (numero4 == true && numberClick.Text == "4")
            {
                numberClick.ForeColor = Color.Black;
                numberClick.Enabled = false;
                numero4 = false;
                numero5 = true;
            }
            else if (numero5 == true && numberClick.Text == "5")
            {
                numberClick.ForeColor = Color.Black;
                numberClick.Enabled = false;
                numero5 = false;
            }

            CondicaoVitoria();
        }

        private void BtnJogarDeNovo_Click(object sender, EventArgs e)
        {
            BtnJogarDeNovo.Enabled = false;
            ReiniciandoValoresClicks();

            AdicionadoItensNaListaDeNumeros();

            HabilitarLabels();

            AssignIconsToSquares();

            timer1.Start();
        }

        private void ReiniciandoValoresClicks()
        {
            numero1 = true;
            numero2 = false;
            numero3 = false;
            numero4 = false;
            numero5 = false;
        }

        private void JogadaErrada(Label objeto)
        {
            if (numero1 == true && objeto.Text != "1" ||
                numero2 == true && objeto.Text != "2" ||
                numero3 == true && objeto.Text != "3" ||
                numero4 == true && objeto.Text != "4" ||
                numero5 == true && objeto.Text != "5")
            {
                DesabilitarTabelaJogo();
                MessageBox.Show("Você não memorizou a sequência correta...", "Errou");
                NumerosTentativas();
                erros++;
                LblErros.Text = erros.ToString();
                BtnJogarDeNovo.Enabled = true;
            }
        }

        private void NumerosTentativas()
        {
            tentativas++;
            LblTentativas.Text = tentativas.ToString();
        }

        private void CondicaoVitoria()
        {
            if (numero1 == false &&
                numero2 == false &&
                numero3 == false &&
                numero4 == false &&
                numero5 == false)
            {
                numero1 = true;
                DesabilitarTabelaJogo();
                MessageBox.Show("Parabéns... você tem uma excelente memória!!!", "Conseguiu");
                NumerosTentativas();
                acertos++;
                LblAcertos.Text = acertos.ToString();
                BtnJogarDeNovo.Enabled = true;
            }
        }

        private void AdicionadoItensNaListaDeNumeros()
        {
            List<string> sequenciaNumerosRestart = new List<string>()
            {
                "1", " ", " ", " ",
                " ", "2", " ", " ",
                "5", " ", "3", " ",
                " ", " ", " ", "4"
            };
            foreach (var item in sequenciaNumerosRestart)
            {
                sequenciaNumeros.Add(item);
            }
        }

        private void DesabilitarTabelaJogo()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label numberLabel = control as Label;
                numberLabel.Enabled = false;
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

        private void TimerFlip(object sender, EventArgs e)
        {
            timer1.Stop();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label numberLabel = control as Label;
                if (numberLabel != null)
                {
                    numberLabel.ForeColor = numberLabel.BackColor;
                }
            }
        }
    }
}
