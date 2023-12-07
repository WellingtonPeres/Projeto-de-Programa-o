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
    public partial class Categorias : Form
    {
        Thread quiz;
        public Categorias()
        {
            InitializeComponent();
        }

        private void rbt_GameDesigner_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.SteelBlue;
        }

        private void rbt_IlustracaoAnatomia_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.Goldenrod;
        }

        private void rbt_Ingles_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.Firebrick;
        }

        private void rbt_LogProgramacao_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.DarkSlateBlue;
        }

        private void rbt_MatFisica_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.SeaGreen;
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            if (rbt_GameDesigner.Checked)
            {
                this.Close();
                quiz = new Thread(QuizGameDesigner);
                quiz.SetApartmentState(ApartmentState.MTA);
                quiz.Start();
            }
            else if (rbt_IlustracaoAnatomia.Checked)
            {
                this.Close();
                quiz = new Thread(QuizIlustracaoAnatomia);
                quiz.SetApartmentState(ApartmentState.MTA);
                quiz.Start();
            }
            else if (rbt_Ingles.Checked)
            {
                this.Close();
                quiz = new Thread(QuizIngles);
                quiz.SetApartmentState(ApartmentState.MTA);
                quiz.Start();
            }
            else if (rbt_LogProgramacao.Checked)
            {
                this.Close();
                quiz = new Thread(QuizLogProgramacao);
                quiz.SetApartmentState(ApartmentState.MTA);
                quiz.Start();
            }
            else if (rbt_MatFisica.Checked)
            {
                this.Close();
                quiz = new Thread(QuizMatFisica);
                quiz.SetApartmentState(ApartmentState.MTA);
                quiz.Start();
            }
        }
        private void QuizGameDesigner()
        {
            Application.Run(new GameDesigner());
        }
        private void QuizIlustracaoAnatomia()
        {
            Application.Run(new IlustracaoAnatomia());
        }
        private void QuizIngles()
        {
            Application.Run(new Ingles());
        }
        private void QuizLogProgramacao()
        {
            Application.Run(new LogProgramacao());
        }
        private void QuizMatFisica()
        {
            Application.Run(new MatFisica());
        }
        private void VoltarMenu()
        {
            Application.Run(new Quiz());
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            quiz = new Thread(VoltarMenu);
            quiz.SetApartmentState(ApartmentState.MTA);
            quiz.Start();
        }
    }
}
