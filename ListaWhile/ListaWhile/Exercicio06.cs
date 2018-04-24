using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio06
    {
        public Exercicio06()
        {

            
            double valor = 0;
            int quantidadedoces = 0;
            int quantidadebolo = 0;
            int quantidadesanduiches = 0;
            int quantidadepizza = 0;
            double somapedidos = 0;
            int quantidadepedidos = 0;
            
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("|                              MENU                                          |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("| CODIGO  |  _TIPO______|_______________NOME__________________|__VALOR_______| ");
            Console.WriteLine("|   1     | BOLOS       | BOLO DE BRIGADEIRO                  |  R$ 29,50    |");
            Console.WriteLine("|   2     | BOLOS       | BOLO FLORESTA NEGRA                 |  R$  2,00    |");
            Console.WriteLine("|   3     | BOLOS       | BOLO LEITE COM NUTELA               |  R$ 29,23    |");
            Console.WriteLine("|   4     | BOLOS       | BOLO MOUSSE DE CHOCOLATE            |  R$  7,10    |");
            Console.WriteLine("|   5     | BOLOS       | BOLO NEGA MALUCA                    |  R$ 19,33    |");
            Console.WriteLine("|   6     | DOCES       | BOMBA DE CHOCOLATE                  |  R$ 17,71    |");
            Console.WriteLine("|   7     | DOCES       | BOMBA DE MORANGO                    |  R$  4,82    |");
            Console.WriteLine("|   8     | SANDUICHES  | FILÈ-MIGNON FRITAS COM CHEDDAR      |  R$ 21,16    |");
            Console.WriteLine("|   9     | SANDUICHES  | HAMBURGUE QUEIJO CHAMPIGNON E RUCULA|  R$ 12,70    |");
            Console.WriteLine("|   10    | SANDUICHES  | PROVOLONE COM SALAME                |  R$ 19,70    |");
            Console.WriteLine("|   11    | SANDUICHES  | VEGETARIANO COM BERINJELA           |  R$ 28,22    |");
            Console.WriteLine("|   12    | PIZZAS      | CALABRESA                           |  R$ 8,98     |");
            Console.WriteLine("|   13    | PIZZAS      | NAPOLITANAS                         |  R$ 0,42     |");
            Console.WriteLine("|   14    | PIZZAS      | PERUANA                             |  R$ 18,36    |");
            Console.WriteLine("|   15    | PIZZAS      | PORTUGUESA                          |  R$ 27,50    |");
            Console.WriteLine("|___16____|_____________|_SAIR_______________________________________________|");

            
            Console.WriteLine("Escolha suas Opções: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != 16)
            {
              

                if (opcao == 1)
                {
                    quantidadebolo = quantidadebolo + 1;
                    valor = 29.50;
                }

                else if (opcao == 2)
                {
                    quantidadebolo = quantidadebolo + 1;
                    valor = 2.00;
                }

                else if (opcao == 3)
                {
                    quantidadebolo = quantidadebolo + 1;
                    valor = 29.23;
                }

                else if (opcao == 4)
                {
                    quantidadebolo = quantidadebolo + 1;
                    valor = 7.10;
                }

                else if (opcao == 5)
                {
                    quantidadebolo = quantidadebolo + 1;
                    valor = 19.33;
                }

                else if (opcao == 6)
                {
                    quantidadedoces = quantidadedoces + 1;
                    valor = 17.71;
                }

                else if (opcao == 7)
                {
                    quantidadedoces = quantidadedoces + 1;
                    valor = 4.82;
                }

                else if (opcao == 8)
                {
                    quantidadesanduiches = quantidadesanduiches + 1;
                    valor = 12.16;
                }

                else if (opcao == 9)
                {
                    quantidadesanduiches = quantidadesanduiches + 1;
                    valor = 12.70;
                }

                else if (opcao == 10)
                {
                    quantidadesanduiches = quantidadesanduiches + 1;
                    valor = 19.70;
                }

                else if (opcao == 11)
                {
                    quantidadesanduiches = quantidadesanduiches + 1;
                    valor = 28.22;
                }

                else if (opcao == 12)
                {
                    quantidadepizza = quantidadepizza + 1;
                    valor = 8.98;
                }

                else if (opcao == 13)
                {
                    quantidadepizza = quantidadepizza + 1;
                    valor = 0.42;
                }

                else if (opcao == 14)
                {
                    quantidadepizza = quantidadepizza + 1;
                    valor = 18.36;
                }

                else if (opcao == 15)
                {
                    quantidadepizza = quantidadepizza + 1;
                    valor = 27.50;
                }
                else
                {
                    valor = 0;
                }

                somapedidos = somapedidos + valor;
                quantidadepedidos = quantidadebolo + quantidadedoces + quantidadesanduiches + quantidadepizza;

                Console.Clear();
                Console.WriteLine("____________________________________________________________________________");
                Console.WriteLine("|                          MENU                                              |");
                Console.WriteLine("|____________________________________________________________________________|");
                Console.WriteLine("|CODIGO   |  _TIPO______|_______________NOME__________________|__VALOR_______| ");
                Console.WriteLine("|   1     | BOLOS       | BOLO DE BRIGADEIRO                  |  R$ 29,50    |");
                Console.WriteLine("|   2     | BOLOS       | BOLO FLORESTA NEGRA                 |  R$  2,00    |");
                Console.WriteLine("|   3     | BOLOS       | BOLO LEITE COM NUTELA               |  R$ 29,23    |");
                Console.WriteLine("|   4     | BOLOS       | BOLO MOUSSE DE CHOCOLATE            |  R$  7,10    |");
                Console.WriteLine("|   5     | BOLOS       | BOLO NEGA MALUCA                    |  R$ 19,33    |");
                Console.WriteLine("|   6     | DOCES       | BOMBA DE CHOCOLATE                  |  R$ 17,71    |");
                Console.WriteLine("|   7     | DOCES       | BOMBA DE MORANGO                    |  R$  4,82    |");
                Console.WriteLine("|   8     | SANDUICHES  | FILÈ-MIGNON FRITAS COM CHEDDAR      |  R$ 21,16    |");
                Console.WriteLine("|   9     | SANDUICHES  | HAMBURGUE QUEIJO CHAMPIGNON E RUCULA|  R$ 12,70    |");
                Console.WriteLine("|   10    | SANDUICHES  | PROVOLONE COM SALAME                |  R$ 19,70    |");
                Console.WriteLine("|   11    | SANDUICHES  | VEGETARIANO COM BERINJELA           |  R$ 28,22    |");
                Console.WriteLine("|   12    | PIZZAS      | CALABRESA                           |  R$ 8,98     |");
                Console.WriteLine("|   13    | PIZZAS      | NAPOLITANAS                         |  R$ 0,42     |");
                Console.WriteLine("|   14    | PIZZAS      | PERUANA                             |  R$ 18,36    |");
                Console.WriteLine("|   15    | PIZZAS      | PORTUGUESA                          |  R$ 27,50    |");
                Console.WriteLine("|___16____|_____________|_SAIR_______________________________________________|");
                Console.WriteLine("Escolha sua Opcção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                }
                
                
            Console.WriteLine("Quantidade de Bolos Escolhidos: " + quantidadebolo);
            Console.WriteLine("Quantidade de Doces Escolhidos: " + quantidadedoces);
            Console.WriteLine("Quantidade de Sanduiches Escolhidos: " + quantidadesanduiches);
            Console.WriteLine("Quantidade de Pizzas Escolhidos: " + quantidadepizza);
            Console.WriteLine("Quantidade de Pedidos: " + quantidadepedidos);
            double media = somapedidos / quantidadepedidos;
            Console.WriteLine("Média dos Produtos: " + media);

                




        }
    }
}