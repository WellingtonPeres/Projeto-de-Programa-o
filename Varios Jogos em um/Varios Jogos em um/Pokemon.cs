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
    public partial class Pokemon : Form
    {
        Thread menu;

        int ataquePikachu = 5;
        int levelPikachu;
        int ataquePokemon = 5;
        int evoluindo;

        int[] ataquePokemons = { 5, 10, 20 };

        int[] LevelPokemons = { 1, 2, 3 };

        string[] nomePokemons ={ "Squirtle", "Charmander", "Bulbasauro" };
        string nomePokemonAtual;

        Random randomAtaquePokemos = new Random();

        public Pokemon()
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

        private void BtnAtaque_Click(object sender, EventArgs e)
        {
            int quemAtaca = randomAtaquePokemos.Next(0, 10);

            if (quemAtaca < 3)
            {
                PgbPikachu.Value -= ataquePokemon;
                LblStatusAtaque.Text = "O ataque falhou";
            }
            else
            {
                PgbPokemon.Value -= ataquePikachu;
                LblStatusAtaque.Text = "Ataque bem Sucedido";
            }

            CondicaoDerrota();
        }

        private void BtnProcurarAdiversario_Click(object sender, EventArgs e)
        {
            Evoluir();

            BtnAtaque.Enabled = true;
            BtnProcurarAdiversario.Enabled = false;

            if (levelPikachu == 3)
            {
                PgbPikachu.Value = 40;
                PgbPokemon.Value = 30;
            }
            else
            {
                PgbPikachu.Value = 20;
                PgbPokemon.Value = 20;
            }

            PgbBarraEvoluir.Value = evoluindo;

            int pokemonAleatorio = randomAtaquePokemos.Next(nomePokemons.Count());
            int levelPokemonAtual = LevelPokemons[pokemonAleatorio];
            ataquePokemon = ataquePokemons[pokemonAleatorio];
            nomePokemonAtual = nomePokemons[pokemonAleatorio];
            
            LblAtaquePokemon.Text = ataquePokemon.ToString();
            LblLevelPokemon.Text = levelPokemonAtual.ToString();
            LblNomePokemon.Text = nomePokemonAtual.ToString();
            LblStatusAtaque.Text = "--------------------------";
        }

        private void CondicaoDerrota()
        {
            if (PgbPikachu.Value == 0)
            {
                MessageBox.Show($"O vencedor é {nomePokemonAtual}");
                BtnAtaque.Enabled = false;
                BtnProcurarAdiversario.Enabled = true;
            }
            else if (PgbPokemon.Value == 0)
            {
                evoluindo += 10;
                levelPikachu++;
                MessageBox.Show("O Vencedor é Pikachu");
                BtnAtaque.Enabled = false;
                BtnProcurarAdiversario.Enabled = true;
            }
            
        }        

        private void Evoluir()
        {
            if (levelPikachu == 3)
            {
                ataquePikachu = 10;
                LblLevelPikachu.Text = "2";
                LblAtaquePikachu.Text = ataquePikachu.ToString();

                PgbPikachu.Maximum = 40;
                PgbPikachu.Value = 40;

                PgbPokemon.Maximum = 30;                
                PgbPokemon.Value = 30;
            }
        }
    }
}
