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
    public partial class LogProgramacao : Form
    {
        Thread quiz;
        Thread resultado;
        public LogProgramacao()
        {
            InitializeComponent();
            Perguntas();
        }

        int _questao = 0;
        int _score = 0;
        List<string> listaPerguntas = new List<string>
        {
            "Questão 1 - Quais os 4 princípios básicos da " +
                "Programação Orientada a Objetos?",
            "Questão 2 - Qual das formas de se criar um array está errado?",
            "Questão 3 - No C#, qual a palavra reservada utilizada " +
                "para lançar uma exceção em determinado local do seu programa?",
            "Questão 4 - Qual das opções abaixo não se configura como uma boa " +
                "prática para a criação de métodos:",
            "Questão 5 - Qual é o princípio de projeto da orientação a objetos" +
                "que significa decompor um sistema complexo em suas partes " +
                "fundamentais e descrevê-las em uma linguagem simples e precisa?"
        };
        string[] opcoesPergunta1 = {"Classe, Atributos, Métodos e construtores.",
                                    "Herança, Polimorfismo, Abstração e Encapsulamento.",
                                    "Polimorfismo, Abstração, Construção, e Encapsulamento.",
                                    "Seleção, Abstração, Construção e Polimorfismo."};
        string[] opcoesPergunta2 = { "string[] familia = new string[4]{“Alexandre”, “Juliana”, “Clarisse”, “João”} ;",
                                     "string[] familia = new string[] {“Alexandre”, “Juliana”, “Clarisse”, “João”} ;",
                                     "string[] familia = new {“Alexandre”, “Juliana”, “Clarisse”, “João”} ;",
                                     "string[] familia = {“Alexandre”, “Juliana”, “Clarisse”, “João”} ;"};
        string[] opcoesPergunta3 = { "Catch.",
                                     "Finally.",
                                     "Try.",
                                     "Nenhuma das alternativas anteriores."};
        string[] opcoesPergunta4 = { "Cada método deve executar uma simples e bem definida tarefa.",
                                     "O nome do método deve descrever de forma clara a tarefa.",
                                     "Métodos longos devem ser evitados, pois evidenciam " +
                                     "que mais de uma tarefa está sendo executada.",
                                     "São bons exemplos de nomes de métodos: Metodo2, Calcular, Auxiliar."};
        string[] opcoesPergunta5 = { "Abstração.",
                                     "Modularidade.",
                                     "Encapsulamento.",
                                     "Herança."};
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

        private void ChecarReposta()
        {
            if (lbl_pergunta.Text == listaPerguntas[0])
            {
                if (rbt_RespostaB.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[1])
            {
                if (rbt_RespostaC.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[2])
            {
                if (rbt_RespostaD.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[3])
            {
                if (rbt_RespostaD.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[4])
            {
                if (rbt_RespostaA.Checked == true)
                {
                    _score++;
                }
            }
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
                rbt_RespostaA.Text = opcoesPergunta5[0];
                rbt_RespostaB.Text = opcoesPergunta5[1];
                rbt_RespostaC.Text = opcoesPergunta5[2];
                rbt_RespostaD.Text = opcoesPergunta5[3];
            }
            if (_questao == 6)
            {
                this.Close();
                resultado = new Thread(MostrarResultado);
                resultado.SetApartmentState(ApartmentState.MTA);
                resultado.Start();
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
