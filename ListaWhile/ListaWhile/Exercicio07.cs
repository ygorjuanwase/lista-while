using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int QuantidadeJogador = 2;
            double MenorPeso = 9999;
            double MaiorPeso = 0;
            int QuantidadeJogadorf = 0;
            int QuantidadeJogadorm = 0;
            double MenorAltura = 99999;
            double MaiorAltura = 0;
            int MenorNome = 999;
            int Maiornome = 0;
            int MenorCartaoAmarelo = 999;
            int MaiorCartaoAmarelo = 0;
            int MenorCartaoVermelho = 999;
            int MaiorCartaoVermelho = 0;
            int QuanridadeLetram = 0;
            int QuantidadeLetraf = 0;
            int MaiorNumerodeLetras = 0;
            int MenorNumerodeLetras = 0;
            string jogadorMenorNome = "";
            string JogadorMaiorNome = "";
            string JogadorMenorCartaoAmrelo = "";
            string JogadorMaiorCartaoAmerlo = "";
            string jogadormenorcartaovemelho = "";
            string jogadormaiorcartaovemelho = "";
            string JogadorMenorPeso = "";
            string jJogadorMaiorPeso = "";
            string jogadorMenorAltura = "";
            string JogadorMaiorAltura = "";
            string JogadorLetraMaior = "";
            string JogadorMenorLetra = "";
            
            while (QuantidadeJogador > 0)
            {
                Console.Clear();
                Console.Write("Nome do Jogador: ");
                string nome = Console.ReadLine().ToLower();

                Console.Write("Idade Do Jogador: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sexo Do jogador: ");
                string sexo = Console.ReadLine().ToLower();

                Console.Write("Peso Do Jogador: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura Do jogador: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade De Gols Marcados: ");
                int gols = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade De Cartões Amarelos Recebidos: ");
                int cartoesamarelos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade De Cartões Vermelhos Recebidos: ");
                int cartoesvermelhos = Convert.ToInt32(Console.ReadLine());
                QuantidadeJogador = QuantidadeJogador - 1;
                if (peso < MenorPeso)
                {
                    MenorPeso = peso;
                    JogadorMenorPeso = nome;
                }
                if (peso > MaiorPeso)
                {
                    MaiorPeso = peso;
                    jJogadorMaiorPeso = nome;
                }
                if (altura < MenorAltura)
                {
                    MenorAltura = altura;
                    jogadorMenorAltura = nome;
                }
                if (altura > MaiorAltura)
                {
                    MaiorAltura = altura;
                    JogadorMaiorAltura = nome;
                }
                if (nome.Length > Maiornome)
                {
                    Maiornome = nome.Length;
                    JogadorMaiorNome = nome;
                }
                if (nome.Length < MenorNome)
                {
                    MenorNome = nome.Length;
                    jogadorMenorNome = nome;
                }
                if (cartoesamarelos < MenorCartaoAmarelo)
                {
                   MenorCartaoAmarelo = cartoesamarelos;
                   JogadorMenorCartaoAmrelo = nome;
                }
                if (cartoesamarelos > MaiorCartaoAmarelo)
                {
                    MaiorCartaoAmarelo = cartoesamarelos;
                    JogadorMaiorCartaoAmerlo = nome;
                }
                if (cartoesvermelhos < MenorCartaoVermelho)
                {
                    MenorCartaoVermelho = cartoesvermelhos;
                    jogadormenorcartaovemelho = nome;
                }
                if (cartoesvermelhos > MaiorCartaoVermelho)
                {
                    MaiorCartaoVermelho = cartoesvermelhos;
                    jogadormaiorcartaovemelho = nome;
                }
                if (QuantidadeJogadorf == 'f'){
                    QuantidadeJogadorf = QuantidadeJogadorf + 1;
                }
                if (QuantidadeJogadorm == 'm'){
                    QuantidadeJogadorm = QuantidadeJogadorm + 1;
                }
                
            }
            Console.Clear();
            Console.WriteLine("jogador com Maior Peso: " + jJogadorMaiorPeso);
            Console.WriteLine("Jogador Com Menor Peso: " + JogadorMenorPeso);
            Console.WriteLine("Jogador Com Maior Nome: " + JogadorMaiorNome);
            Console.WriteLine("Jogador Com Menor Nome: " + jogadorMenorNome);
            Console.WriteLine("Jogador Com Maior Altura: " + JogadorMaiorAltura);
            Console.WriteLine("Jogador Com Menor Altura: " + jogadorMenorAltura);
            Console.WriteLine("Jogador Com Maior Quantidade De Cartões Amarelos: " + JogadorMaiorCartaoAmerlo);
            Console.WriteLine("Jogador Com Menor Quantidade De Cartões Amarelos: " + JogadorMenorCartaoAmrelo);
            Console.WriteLine("Jogador Com Maior Quantidade De Cartões Vermelhos: " + jogadormaiorcartaovemelho);
            Console.WriteLine("Jogador Com Menor Quantidade De Cartões Vermelhos: " + jogadormenorcartaovemelho);
            Console.WriteLine("Quantidade De Jogadores Masculinos: " + QuantidadeJogadorm);
            Console.WriteLine("Quantidade De Jogadores Femininos: " + QuantidadeJogadorf);
        }
    }
}
