using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letrasNome = new List<string> { };// Pode usar.

            List<string> letrasErradas = new List<string> { };

            List<string> letrasJaUsadas = new List<string> { };

            List<string> nomeCorreto = new List<string> { };

            int condicaoDerrota = 0;

            Console.WriteLine("------------------------------");
            Console.WriteLine("  BEM VINDO AO JOGO DA FORCA");
            Console.WriteLine("------------------------------\n");

            Console.Write("Digite o nome a ser advinhado: ");
            string nome = Console.ReadLine().ToUpper().Trim();
            char [] gravarNome = nome.ToCharArray();

            Console.Write("Digite um DICA: ");
            string dica = Console.ReadLine();

            // Adicionar os valores em letrasJaUsadas.
            for (int i = 0; i < nome.Length; i++)
            {
                nomeCorreto.Add("__ ");
            }

            Console.Clear();

            while (condicaoDerrota < 6)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("  BEM VINDO AO JOGO DA FORCA");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine($"DICA: {dica.ToUpper()}. E a palavra tem [{nome.Length}] letras.");

                string tentativas;

                for (int i = 0; i < nome.Length; i++)
                {
                    letrasNome.Add(gravarNome[i].ToString());
                }

                // substituir letras letrasJaUsadas.
                for (int i = 0; i < nome.Length; i++)
                {
                    if (letrasJaUsadas.Contains(letrasNome[i]))
                    {
                        nomeCorreto[i] = letrasNome[i];
                    }
                }

                Console.Write("\nLETRAS ERRADAS: ");
                foreach (var item in letrasErradas)
                {
                    Console.Write($"{item} ");
                }
                Console.Write("\nLETRAS JÁ USADAS: ");
                foreach (var item in letrasJaUsadas)
                {
                    Console.Write($"{item} ");
                }

                /* Mostra a quantidade de linhas a serem preenchidas.*/
                Console.Write("\n\nO NOME É: ");
                foreach (var item in nomeCorreto)
                {
                    Console.Write(item);
                }

                Console.WriteLine($"\n\nERROS RESTANTES [{6 - condicaoDerrota}]");

                // Condição de vitória.
                if (!nomeCorreto.Contains("__ "))
                {
                    Console.WriteLine("\n------------------------------------------------");
                    Console.WriteLine("Parabéns!!! Você escertou tudo. Imprecionante!!!");
                    Console.WriteLine("------------------------------------------------");
                    break;
                }                

                Console.WriteLine("\n\nQuer tentar adivinhar qual é a palavra? Digite 1 -> [SIM] 2 -> [NÃO]");
                string adivinharPalavra = Console.ReadLine();
                while (adivinharPalavra != "1" && adivinharPalavra != "2")
                {
                    Console.WriteLine("Opção invalida. Tente novamente...");
                    adivinharPalavra = Console.ReadLine();
                }
                if (adivinharPalavra == "1")
                {
                    Console.Write("\nQual é a palavra? ");
                    tentativas = Console.ReadLine().ToUpper().Trim();
                    if (tentativas == nome)
                    {
                        Console.WriteLine("\n-------------------------------------------------------------");
                        Console.WriteLine("WWWOOOWWW!!! Você é MUITO inteligente!!! Acertou em cheio!!!!");
                        Console.WriteLine("-------------------------------------------------------------");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nQue pena!!! Você errou... Perdeu o jogo.");
                        break;
                    }
                }

                // Tentativas para chutar letras.
                Console.Write("\nChute uma letra: ");
                tentativas = Console.ReadLine().ToUpper().Trim();

                while (letrasJaUsadas.Contains(tentativas))
                {
                    Console.WriteLine("Essa letra já foi usada. Tente outra...");
                    Console.Write("\n\nChute uma letra: ");
                    tentativas = Console.ReadLine().ToUpper().Trim();
                }

                if (letrasNome.Contains(tentativas))
                {
                    //Console.WriteLine("\nParabéns!!! Você acertou uma letra.");
                    letrasJaUsadas.Add(tentativas);
                }
                else
                {
                    //Console.WriteLine("\nQue pena!!! Você errou.\n");
                    condicaoDerrota++;
                    letrasErradas.Add(tentativas);
                    letrasJaUsadas.Add(tentativas);
                }  

                if (condicaoDerrota == 6)
                {
                    break;
                }

                Console.Clear();
            }

            Console.WriteLine("------------------");
            Console.WriteLine("  FIM DE JOGO...");
            Console.WriteLine("------------------");

            Console.ReadLine();
        }
    }
}
