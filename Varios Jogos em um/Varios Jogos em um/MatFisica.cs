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
    public partial class MatFisica : Form
    {
        Thread quiz;
        Thread resultado;
        public MatFisica()
        {
            InitializeComponent();
            Perguntas();
        }

        int _questao = 0;
        int _score = 0;
        List<string> listaPerguntas = new List<string>
        {
            "Questão 1 - A aceleração de um objeto sempre está na mesma direção " +
                "e sentido da força resultante aplicada sobre ele.",
            "Questão 2 - como se descreve a equação da circunfeência. ",
            "Questão 3 - Um sistema de equações lineares classificado como possível " +
                "e indeterminado não tem solução.",
            "Questão 4 - Qual das afirmativas está correta.",
            "Questão 5 - A respeito dos elementos de uma parábola, assinale entre as " +
                "alternativas abaixo aquela que for correta."
        };
        string[] opcoesPergunta1 = {"Verdadeiro.",
                                    "Falso."};
        string[] opcoesPergunta2 = { "Y-Yp = m(X-Xp)",
                                     "D²ab = (Xa - Xb)²+(Ya-Yb)",
                                     "X = a(Y-Yv)²+Xv",
                                     "D²ab = (Xa - Xb)²+(Ya-Yb)²"};
        string[] opcoesPergunta3 = { "Verdadeiro.",
                                     "Falso"};
        string[] opcoesPergunta4 = { "As retas não podem ser definidas, pois são objetos primitivos.",
                                     "Um segmento de reta pode ser compreendido como uma parte da reta que possui início e fim.",
                                     "Não é possível definir uma reta, mas esse " + 
                                        "realmente é o modo como elas podem ser compreendidas.",
                                     "A semirreta é uma parte da reta que possui início, mas não possui fim."};
        string[] opcoesPergunta5 = { "O foco de uma parábola é uma reta, que participa da definição dessa figura.",
                                     "A diretriz de uma parábola é uma reta, que participa da definição dessa figura.",
                                     "O parâmetro, em uma parábola, é a menor distância entre o foco e a própria parábola.",
                                     "O parâmetro, em uma parábola, é a maior distância entre o foco e a própria parábola."};
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
                //opção certa marcada.
                if (rbt_RespostaA.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_pergunta.Text == listaPerguntas[1])
            {
                //opção certa marcada.
                if (rbt_RespostaD.Checked == true)
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
                if (rbt_RespostaB.Checked == true)
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
                rbt_RespostaC.Visible = false;
                rbt_RespostaD.Visible = false;
            }
            if (_questao == 2)
            {
                lbl_pergunta.Text = listaPerguntas[1];
                rbt_RespostaA.Text = opcoesPergunta2[0];
                rbt_RespostaB.Text = opcoesPergunta2[1];
                rbt_RespostaC.Visible = true;
                rbt_RespostaD.Visible = true;
                rbt_RespostaC.Text = opcoesPergunta2[2];
                rbt_RespostaD.Text = opcoesPergunta2[3];
            }
            if (_questao == 3)
            {
                lbl_pergunta.Text = listaPerguntas[2];
                rbt_RespostaA.Text = opcoesPergunta3[0];
                rbt_RespostaB.Text = opcoesPergunta3[1];
                rbt_RespostaC.Visible = false;
                rbt_RespostaD.Visible = false;
            }
            if (_questao == 4)
            {
                lbl_pergunta.Text = listaPerguntas[3];
                rbt_RespostaA.Text = opcoesPergunta4[0];
                rbt_RespostaB.Text = opcoesPergunta4[1];
                rbt_RespostaC.Visible = true;
                rbt_RespostaD.Visible = true;
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
