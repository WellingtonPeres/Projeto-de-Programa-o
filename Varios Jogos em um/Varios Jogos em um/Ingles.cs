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
    public partial class Ingles : Form
    {
        Thread quiz;
        Thread resultado;
        public Ingles()
        {
            InitializeComponent();
            Perguntas();
        }

        int _questao = 0;
        int _score = 0;
        List<string> listaPerguntas = new List<string>
        {
            "Questão 1 - It's not some kind of puzzle.",
            "Questão 2 - Which of the options below is not part of the tetrad elements.",
            "Questão 3 - _________ invole the manipulation of objects, either in the mind " +
                "or on the playing surface.",
            "Questão 4 - What does scanning mean?",
            "Questão 5 - What is skimming?"
        };
        string[] opcoesPergunta1 = {"Riddles.",
                                    "Lateral thinking.",
                                    "mystery.",
                                    "Patter Recognition."};
        string[] opcoesPergunta2 = { "Mechanics ",
                                     "Aesthetics ",
                                     "BarinStrom",
                                     "Story "};
        string[] opcoesPergunta3 = { "Lateral thinking",
                                     "Spatial puzzles",
                                     "Logic",
                                     "Exploration"};
        string[] opcoesPergunta4 = { "read slowly",
                                     "Read fast",
                                     "use the dictionary",
                                     "Read keywords"};
        string[] opcoesPergunta5 = { "Quick reading to understand the context",
                                     "read slowly",
                                     "Read without understanding" ,
                                     "use the dictionary"};

        private void btn_Desistir_Click(object sender, EventArgs e)
        {
            DialogResult back = MessageBox.Show("Seu progresso será perdido. Tem certeza que deseja voltar?", "", MessageBoxButtons.OKCancel);
            if (back.ToString() == "OK")
            {
                this.Close();
                quiz = new Thread(VoltarQuiz);
                quiz.SetApartmentState(ApartmentState.MTA);
                quiz.Start();
            }
        }
        private void btn_ProximaQuestao_Click(object sender, EventArgs e)
        {
            ChecarReposta();
            ResetarAlternativas();
            Perguntas();
        }

        private void ResetarAlternativas()
        {
            rbt_RespostaA.Checked = false;
            rbt_RespostaB.Checked = false;
            rbt_RespostaC.Checked = false;
            rbt_RespostaD.Checked = false;
        }
        private void Perguntas()
        {
            _questao++;

            if (_questao == 1)
            {
                lbl_pergunta.Text = listaPerguntas[0];
                rbt_RespostaA.Text = opcoesPergunta1[0];
                rbt_RespostaB.Text = opcoesPergunta1[1];
                rbt_RespostaC.Text = opcoesPergunta1[2];
                rbt_RespostaD.Text = opcoesPergunta1[3];
            }
            if (_questao == 2)
            {
                lbl_pergunta.Text = listaPerguntas[1];
                rbt_RespostaA.Text = opcoesPergunta2[0];
                rbt_RespostaB.Text = opcoesPergunta2[1];
                rbt_RespostaC.Text = opcoesPergunta2[2];
                rbt_RespostaD.Text = opcoesPergunta2[3];
            }
            if (_questao == 3)
            {
                lbl_pergunta.Text = listaPerguntas[2];
                rbt_RespostaA.Text = opcoesPergunta3[0];
                rbt_RespostaB.Text = opcoesPergunta3[1];
                rbt_RespostaC.Text = opcoesPergunta3[2];
                rbt_RespostaD.Text = opcoesPergunta3[3];
            }
            if (_questao == 4)
            {
                lbl_pergunta.Text = listaPerguntas[3];
                rbt_RespostaA.Text = opcoesPergunta4[0];
                rbt_RespostaB.Text = opcoesPergunta4[1];
                rbt_RespostaC.Text = opcoesPergunta4[2];
                rbt_RespostaD.Text = opcoesPergunta4[3];
            }
            if (_questao == 5)
            {
                lbl_pergunta.Text = listaPerguntas[4];
                rbt_RespostaA.Text = opcoesPergunta4[0];
                rbt_RespostaB.Text = opcoesPergunta4[1];
                rbt_RespostaC.Text = opcoesPergunta4[2];
                rbt_RespostaD.Text = opcoesPergunta4[3];
            }
            if (_questao == 6)
            {
                this.Close();
                resultado = new Thread(MostrarResultado);
                resultado.SetApartmentState(ApartmentState.MTA);
                resultado.Start();
            }
        }
        private void ChecarReposta()
        {
            if (lbl_pergunta.Text == listaPerguntas[0])
            {
                //opção certa marcada.
                if (rbt_RespostaC.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[1])
            {
                //opção certa marcada.
                if (rbt_RespostaC.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[2])
            {
                //opção certa marcada.
                if (rbt_RespostaB.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[3])
            {
                //opção certa marcada.
                if (rbt_RespostaD.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[4])
            {
                //opção certa marcada.
                if (rbt_RespostaA.Checked == true)
                {
                    _score++;
                }
            }
        }
        private void MostrarResultado()
        {
            Application.Run(new Resultado("Game Designer", _score));
        }
        private void VoltarQuiz()
        {
            Application.Run(new Quiz());
        }
    }
}
