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
    public partial class Yu_gi_oh : Form
    {
        Thread menu;

        int pontosJogador = 8000;
        int pontosComputador = 8000;

        int vitoriaJogador;
        int vitoriaComputador;

        Random rand = new Random();
        int gerarCartaJogador;
        int gerarCartaComputador;

        string[] nomeMostros =
        {
            "Dragão Brando",
            "Mago Negro",
            "Arqueiro",
            "Golem",
            "Exodia",
            "Mago do Caus",
            "Dração de 5 Cabeças",
            "Obelisco o Atomentado",
            "Dragão alado de RA",
            "Slifer o Dragão do Céu",
        };

        int[] ataqueMostros =
        {
            3000,
            2500,
            1800,
            2000,
            999999,
            3200,
            5000,
            10000,
            10000,
            10000
        };

        public Yu_gi_oh()
        {
            InitializeComponent();
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

        private void PuxarCartaDeck_Click(object sender, EventArgs e)
        {
            BtnDuelar.Enabled = true;
            gerarCartaJogador = rand.Next(nomeMostros.Length);

            LblNomeDaCartaJogador.Text = nomeMostros[gerarCartaJogador];
            LblAtaqueDaCartaJogador.Text = ataqueMostros[gerarCartaJogador].ToString();

            BloquearDeckJogador();

            LblNomeDaCartaComputador.Text = "?????";
            LblAtaqueDaCartaComputador.Text = "?????";
        }

        private void BtnDuelar_Click(object sender, EventArgs e)
        {
            DesbloquearDeckJogador();

            gerarCartaComputador = rand.Next(nomeMostros.Length);
            LblNomeDaCartaComputador.Text = nomeMostros[gerarCartaComputador];
            LblAtaqueDaCartaComputador.Text = ataqueMostros[gerarCartaComputador].ToString();

            BtnDuelar.Enabled = false;

            ConferirDueloEntreMonstros();

            CondicaoDeVitoria();
        }

        private void DesbloquearDeckJogador()
        {
            pictureBox2.BackColor = Color.Chocolate;
            pictureBox2.Enabled = true;
            LblDeckJogador.BackColor = Color.Chocolate;
        }

        private void BloquearDeckJogador()
        {
            pictureBox2.BackColor = Color.SaddleBrown;
            pictureBox2.Enabled = false;
            LblDeckJogador.BackColor = Color.SaddleBrown;
        }

        private void ConferirDueloEntreMonstros()
        {
            if (ataqueMostros[gerarCartaJogador] < ataqueMostros[gerarCartaComputador])
            {
                pontosJogador += (ataqueMostros[gerarCartaJogador] - ataqueMostros[gerarCartaComputador]);
                LblPontosJogador.Text = pontosJogador.ToString();
            }
            else if (ataqueMostros[gerarCartaComputador] < ataqueMostros[gerarCartaJogador])
            {
                pontosComputador += (ataqueMostros[gerarCartaComputador] - ataqueMostros[gerarCartaJogador]);
                LblPontosComputador.Text = pontosComputador.ToString();
            }
        }

        private void CondicaoDeVitoria()
        {
            if (pontosJogador <= 0)
            {
                vitoriaComputador++;
                LblVitoriaComputador.Text = vitoriaComputador.ToString();
                MessageBox.Show("Vitória do COMPUTADOR!!!", "Derrota");
                BtnRevanche.Enabled = true;
                BloquearDeckJogador();
            }
            if (pontosComputador <= 0)
            {
                vitoriaJogador++;
                LblVitoriaJogador.Text = vitoriaJogador.ToString();
                MessageBox.Show("Vitória do JOGADOR!!!", "Parabéns");
                BtnRevanche.Enabled = true;
                BloquearDeckJogador();
            }           
        }

        private void BtnRevanche_Click(object sender, EventArgs e)
        {
            BtnRevanche.Enabled = false;

            pontosJogador = 8000;
            pontosComputador = 8000;

            LblPontosJogador.Text = pontosJogador.ToString();
            LblPontosComputador.Text = pontosComputador.ToString();

            LblNomeDaCartaComputador.Text = "?????";
            LblAtaqueDaCartaComputador.Text = "?????";

            LblNomeDaCartaJogador.Text = "?????";
            LblAtaqueDaCartaJogador.Text = "?????";

            DesbloquearDeckJogador();
        }
    }
}
