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
    public partial class Jokenpo : Form
    {

        Thread menu;

        Random random = new Random();

        int pontosJogador;
        int pontosComputador;

        public Jokenpo()
        {
            InitializeComponent();
        }

        public void MenuJokenpo()
        {
            Application.Run(new JokenpoMenu());
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            menu = new Thread(MenuJokenpo);
            menu.SetApartmentState(ApartmentState.STA);
            menu.Start();
        }

        private void ImagePedra_Click(object sender, EventArgs e)
        {
            PtbJogadorPedra.Visible = true;
            PtbJogadorPapel.Visible = false;
            PtbJogadorTesoura.Visible = false;
            PtbImagemNeutroJogador.Visible = false;
            GerarValorAleatorio();
            VitoriaJogador();
            VitoriaComputador();
        }

        private void ImagePapel_Click(object sender, EventArgs e)
        {
            PtbJogadorPedra.Visible = false;
            PtbJogadorPapel.Visible = true;
            PtbJogadorTesoura.Visible = false;
            PtbImagemNeutroJogador.Visible = false;
            GerarValorAleatorio();
            VitoriaJogador();
            VitoriaComputador();
        }

        private void ImageTesoura_Click(object sender, EventArgs e)
        {
            PtbJogadorPapel.Visible = false;
            PtbJogadorPedra.Visible = false;
            PtbJogadorTesoura.Visible = true;
            PtbImagemNeutroJogador.Visible = false;
            GerarValorAleatorio();
            VitoriaJogador();
            VitoriaComputador();
        }

        private void GerarValorAleatorio()
        {
            int valorAleatorio = random.Next(0, 10);
            if (valorAleatorio < 3)
            {
                PtbComputadorPedra.Visible = true;
                PtbComputadorPapel.Visible = false;
                PtbComputadorTesoura.Visible = false;
                PtbImagemNeutroComputador.Visible = false;
            }
            else if (valorAleatorio < 6)
            {
                PtbComputadorPedra.Visible = false;
                PtbComputadorPapel.Visible = true;
                PtbComputadorTesoura.Visible = false;
                PtbImagemNeutroComputador.Visible = false;
            }
            else
            {
                PtbComputadorPapel.Visible = false;
                PtbComputadorPedra.Visible = false;
                PtbComputadorTesoura.Visible = true;
                PtbImagemNeutroComputador.Visible = false;
            }
        }

        private void VitoriaJogador()
        {
            if (PtbJogadorPedra.Visible == true && PtbComputadorTesoura.Visible == true)
            {
                pontosJogador++;
                LblPontosJogador.Text = pontosJogador.ToString();
            }
            else if (PtbJogadorPapel.Visible == true && PtbComputadorPedra.Visible == true)
            {
                pontosJogador++;
                LblPontosJogador.Text = pontosJogador.ToString();
            }
            else if (PtbJogadorTesoura.Visible == true && PtbComputadorPapel.Visible == true)
            {
                pontosJogador++;
                LblPontosJogador.Text = pontosJogador.ToString();
            }
        }

        private void VitoriaComputador()
        {
            if (PtbComputadorPedra.Visible == true && PtbJogadorTesoura.Visible == true)
            {
                pontosComputador++;
                LblPontosComputador.Text = pontosComputador.ToString();
            }
            else if (PtbComputadorPapel.Visible == true && PtbJogadorPedra.Visible == true)
            {
                pontosComputador++;
                LblPontosComputador.Text = pontosComputador.ToString();
            }
            else if (PtbComputadorTesoura.Visible == true && PtbJogadorPapel.Visible == true)
            {
                pontosComputador++;
                LblPontosComputador.Text = pontosComputador.ToString();
            }
        }
    }
}
