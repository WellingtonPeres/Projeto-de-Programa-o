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
    public partial class GameDesigner : Form
    {
        Thread quiz;
        Thread resultado;
        public GameDesigner()
        {
            InitializeComponent();
            Perguntas();
        }

        int _questao = 0;
        int _score = 0;
        List<string> listaPerguntas = new List<string>
        {
            "Questão 1 - Quais das opções a seguir, descreve a seguinte afirmação: " +
            "'A ________ descreve o objetivo de seu jogo, como os jogadores podem " +
            "ou não alcançá-lo  e o que acontece quando tentam'. Jesse Schell (2008).",
            "Questão 2 - Um jogo tem quatro aspectos fundamentais. Quais são eles?",
            "Questão 3 - Qual é a definição de Core mechanic?",
            "Questão 4 - O que é um GDD?",
            "Questão 5 - Os jogadores foram divididos em quatro perfis, quais são eles?"
        };
        string[] opcoesPergunta1 = {"Estética.", 
                                    "Narrativa.", 
                                    "Tecnologia.", 
                                    "Mecânica."};
        string[] opcoesPergunta2 = { "Estética, Narrativa, Tecnologia e Mecânica.",
                                     "Jogo, Computador, Tecnologia e Mecânica.",
                                     "Mecânica, História, Marketing e Console.",
                                     "Estética, Jogo, Tecnologia e Jogador."};
        string[] opcoesPergunta3 = { "Definir uma core mechanic no desenvolvimento de " +
                                     "um jogo prejudica a criar e manter sua identidade.",
                                     "A Core mechanic (ou mecânica núcleo) são " +
                                     "características principais na qual as outras " +
                                     "mecânicas do jogo giram.",
                                     "Um jogo independe de uma Core mechanic.",
                                     "Nenhuma das anteriores."};
        string[] opcoesPergunta4 = { "É um documento qualquer que não serve para nada.",
                                     "Documento que registra uma parte do processo de um jogo.",
                                     "Documento que registra todos elementos pertencente " +
                                     "a um jogo.",
                                     "Documento que só serve para ocupar espaço."};
        string[] opcoesPergunta5 = { "Realizadores, Caçadores, Exploradores, Socializadores.",
                                     "Exploradores, Motivacionais, Realizadores, Socializadores.",
                                     "Predadores, Realizadores, Exploradores, Socializadores.",
                                     "Socializadores, Caçadores, Realizadores, Exploradores, ."};

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
        private void btn_ProximaQuestao_Click_1(object sender, EventArgs e)
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
                if (rbt_RespostaD.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[1])
            {
                //opção certa marcada.
                if (rbt_RespostaA.Checked == true)
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
                if (rbt_RespostaC.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[4])
            {
                //opção certa marcada.
                if (rbt_RespostaC.Checked == true)
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
