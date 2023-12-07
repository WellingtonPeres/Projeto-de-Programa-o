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
    public partial class IlustracaoAnatomia : Form
    {
        Thread quiz;
        Thread resultado;
        public IlustracaoAnatomia()
        {
            InitializeComponent();
            Perguntas();
        }
        int _questao = 0;
        int _score = 0;
        List<string> listaPerguntas = new List<string>
        {
            "Questão 1 - Qual músculo não pertence ao grupo muscular das tórax?",
            "Questão 2 - Qual a origem e inserção do músculo deltoide",
            "Questão 3 - Qual o maior osso do corpo humano?",
            "Questão 4 - Onde se localiza o musculo braquial?",
            "Questão 5 - A afirmação: Ombros estreitos, tórax maior, pelve mais curto e sacro " +
                "mais longo define uma estrutura feminina, é?"
        };
        string[] opcoesPergunta1 = {"Serrátio anterior.",
                                    "Oblíquo externo.",
                                    "Vasto medial.",
                                    "Trígono de asculta."};
        string[] opcoesPergunta2 = { "Origem: Externo. Inserção: Clavícula.",
                                     "Origem: Clavícula, Espinha da escápula e Processo " +
                                     "Acrômio da Escápula. Inserção: Úmero.",
                                     "Origem: Processo Acrômio da Escápula. Inserção: Clavícula.",
                                     "Origem: Úmero. Inserção: Ulna."};
        string[] opcoesPergunta3 = { "Sétima costela",
                                     "Úmero",
                                     "Tíbia",
                                     "Fêmur."};
        string[] opcoesPergunta4 = { "Braço",
                                     "Perna",
                                     "Abdomen" ,
                                     "Costas"};
        string[] opcoesPergunta5 = { "Verdadeiro",
                                     "Falso"};

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
                lbl_Pergunta.Text = listaPerguntas[0];
                rbt_RespostaA.Text = opcoesPergunta1[0];
                rbt_RespostaB.Text = opcoesPergunta1[1];
                rbt_RespostaC.Text = opcoesPergunta1[2];
                rbt_RespostaD.Text = opcoesPergunta1[3];
            }
            if (_questao == 2)
            {
                lbl_Pergunta.Text = listaPerguntas[1];
                rbt_RespostaA.Text = opcoesPergunta2[0];
                rbt_RespostaB.Text = opcoesPergunta2[1];
                rbt_RespostaC.Text = opcoesPergunta2[2];
                rbt_RespostaD.Text = opcoesPergunta2[3];
            }
            if (_questao == 3)
            {
                lbl_Pergunta.Text = listaPerguntas[2];
                rbt_RespostaA.Text = opcoesPergunta3[0];
                rbt_RespostaB.Text = opcoesPergunta3[1];
                rbt_RespostaC.Text = opcoesPergunta3[2];
                rbt_RespostaD.Text = opcoesPergunta3[3];
            }
            if (_questao == 4)
            {
                lbl_Pergunta.Text = listaPerguntas[3];
                rbt_RespostaA.Text = opcoesPergunta4[0];
                rbt_RespostaB.Text = opcoesPergunta4[1];
                rbt_RespostaC.Text = opcoesPergunta4[2];
                rbt_RespostaD.Text = opcoesPergunta4[3];
            }
            if (_questao == 5)
            {
                lbl_Pergunta.Text = listaPerguntas[4];
                rbt_RespostaA.Text = opcoesPergunta5[0];
                rbt_RespostaB.Text = opcoesPergunta5[1];
                rbt_RespostaC.Visible = false;
                rbt_RespostaD.Visible = false;
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
            if (lbl_Pergunta.Text == listaPerguntas[0])
            {
                //opção certa marcada.
                if (rbt_RespostaC.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_Pergunta.Text == listaPerguntas[1])
            {
                //opção certa marcada.
                if (rbt_RespostaB.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_Pergunta.Text == listaPerguntas[2])
            {
                //opção certa marcada.
                if (rbt_RespostaB.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_Pergunta.Text == listaPerguntas[3])
            {
                //opção certa marcada.
                if (rbt_RespostaA.Checked == true)
                {
                    _score++;
                }
            }
            if (lbl_Pergunta.Text == listaPerguntas[4])
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
