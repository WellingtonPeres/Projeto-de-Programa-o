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
    public partial class Quiz1 : Form
    {
        Thread menu;
        
        bool pergunta1 = true;
        bool pergunta2 = false;
        bool pergunta3 = false;
        bool pergunta4 = false;

        int acertos;

        List<string> listaPerguntas = new List<string>
        {
            "1 - Quais das opções a seguir, descreve a seguinte afirmação: " +
            "'A ________ descreve o objetivo de seu jogo, como os jogadores podem " +
            "ou não alcançá-lo  e o que acontece quando tentam'. Jesse Schell (2008).",
            "2 - Um jogo tem quatro aspectos fundamentais. Quais são eles?",
            "3 - Qual é a definição de Core mechanic?",
            "4 - O que é um GDD?",
        };

        // Pergunta 2
        string[] opcoesPergunta2 = { "Estética, Narrativa, Tecnologia e Mecânica.",
                                     "Jogo, Computador, Tecnologia e Mecânica.",
                                     "Mecânica, História, Marketing e Console.",
                                     "Estética, Jogo, Tecnologia e Jogador."};

        string[] opcoesPergunta3 = { "Definir uma core mechanic no desenvolvimento de " +
                                     "um jogo prejdica a criar e manter sua identidade.",
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

        Random random = new Random();   

        public Quiz1()
        {
            InitializeComponent();

            LblDescricaoPergunta.Text = listaPerguntas[0];
        }

        public void telaMenu()
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

        private void BtnRespotaA_Click(object sender, EventArgs e)
        {
            if (pergunta1)
            {
                QuestoesSegundaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[1];
                pergunta1 = false;
                pergunta2 = true;
            }
            else if (pergunta2)
            {
                acertos++;
                QuestoesTerceiraPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[2];
                pergunta2 = false;
                pergunta3 = true;
            }
            else if (pergunta3)
            {
                QuestoesQuartaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[3];
                pergunta3 = false;
                pergunta4 = true;
            }
            else if (pergunta4)
            {
                pergunta4 = false;
            }
            if (pergunta1 == false &&
                pergunta2 == false &&
                pergunta3 == false &&
                pergunta4 == false)
            {
                MessageBox.Show($"Você acertou {acertos} de 4 perguntas.", "Fim de Jogo");
            }
        }

        private void BtnRespotaB_Click(object sender, EventArgs e)
        {
            if (pergunta1)
            {
                QuestoesSegundaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[1];
                pergunta1 = false;
                pergunta2 = true;
            }
            else if (pergunta2)
            {
                QuestoesTerceiraPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[2];
                pergunta2 = false;
                pergunta3 = true;
            }
            else if (pergunta3)
            {
                acertos++;
                QuestoesQuartaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[3];
                pergunta3 = false;
                pergunta4 = true;
            }
            else if (pergunta4)
            {
                pergunta4 = false;
            }
            if (pergunta1 == false &&
                pergunta2 == false &&
                pergunta3 == false &&
                pergunta4 == false)
            {
                MessageBox.Show($"Você acertou {acertos} de 4 perguntas.", "Fim de Jogo");
            }
        }

        private void BtnRespotaC_Click(object sender, EventArgs e)
        {
            if (pergunta1)
            {
                QuestoesSegundaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[1];
                pergunta1 = false;
                pergunta2 = true;
            }
            else if (pergunta2)
            {
                QuestoesTerceiraPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[2];
                pergunta2 = false;
                pergunta3 = true;
            }
            else if (pergunta3)
            {
                QuestoesQuartaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[3];
                pergunta3 = false;
                pergunta4 = true;
            }
            else if (pergunta4)
            {
                acertos++;
                pergunta4 = false;
            }
            if (pergunta1 == false &&
                pergunta2 == false &&
                pergunta3 == false &&
                pergunta4 == false)
            {
                MessageBox.Show($"Você acertou {acertos} de 4 perguntas.", "Fim de Jogo");
            }
        }

        private void BtnRespotaD_Click(object sender, EventArgs e)
        {
            if (pergunta1)
            {
                acertos++;
                QuestoesSegundaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[1];
                pergunta1 = false;
                pergunta2 = true;
            }
            else if (pergunta2)
            {
                QuestoesTerceiraPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[2];
                pergunta2 = false;
                pergunta3 = true;
            }
            else if (pergunta3)
            {
                QuestoesQuartaPergunda();
                LblDescricaoPergunta.Text = listaPerguntas[3];
                pergunta3 = false;
                pergunta4 = true;
            }
            else if (pergunta4)
            {
                pergunta4 = false;
            }
            if (pergunta1 == false &&
                pergunta2 == false &&
                pergunta3 == false &&
                pergunta4 == false)
            {
                MessageBox.Show($"Você acertou {acertos} de 4 perguntas.", "Fim de Jogo");
            }
        }

        private void BtnJogarNovamente_Click(object sender, EventArgs e)
        {
            LblDescricaoPergunta.Text = listaPerguntas[0];

            acertos = 0;

            pergunta1 = true;
            pergunta2 = false;
            pergunta3 = false;
            pergunta4 = false;

            BtnRespotaA.Text = "Estética.";
            BtnRespotaB.Text = "Narrativa.";
            BtnRespotaC.Text = "Tecnologia.";
            BtnRespotaD.Text = "Mecânica.";
        }

        private void QuestoesSegundaPergunda()
        {
            BtnRespotaA.Text = opcoesPergunta2[0];
            BtnRespotaB.Text = opcoesPergunta2[1];
            BtnRespotaC.Text = opcoesPergunta2[2];
            BtnRespotaD.Text = opcoesPergunta2[3];
        }

        private void QuestoesTerceiraPergunda()
        {
            BtnRespotaA.Text = opcoesPergunta3[0];
            BtnRespotaB.Text = opcoesPergunta3[1];
            BtnRespotaC.Text = opcoesPergunta3[2];
            BtnRespotaD.Text = opcoesPergunta3[3];
        }

        private void QuestoesQuartaPergunda()
        {
            BtnRespotaA.Text = opcoesPergunta4[0];
            BtnRespotaB.Text = opcoesPergunta4[1];
            BtnRespotaC.Text = opcoesPergunta4[2];
            BtnRespotaD.Text = opcoesPergunta4[3];
        }
    }
}
