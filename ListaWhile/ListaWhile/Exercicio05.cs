using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Digite um Numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite Outro Numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            
          
            Console.WriteLine("_______________________________");
            Console.WriteLine("|  1          | SOMAR         |");
            Console.WriteLine("|  2          | SUBTRAIR      |");   
            Console.WriteLine("|  3          | MULTIPLICAR   |");
            Console.WriteLine("|  4          | DIVIDIR       |");
            Console.WriteLine("|__5__________|_SAIR__________|");

            Console.WriteLine("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != 5)
            {
                if (opcao == 1)
                {
                    int soma = numero1 + numero2;
                    Console.WriteLine("opção 1 : " + soma);
                }
                else if (opcao == 2)
                {
                    int subtrair = numero1 - numero2;
                    Console.WriteLine("Opção 2 : " + subtrair);
                }
                else if (opcao == 3)
                {
                    int multiplicacao = numero1 * numero2;
                    Console.WriteLine("Opção 3: " + multiplicacao);
                }else if(opcao == 4)
                {
                    int divisao = numero1 / numero2;
                    Console.WriteLine("Divisão: " + divisao);
                }
                Console.WriteLine("_______________________________");
                Console.WriteLine("|  1          | SOMAR         |");
                Console.WriteLine("|  2          | SUBTRAIR      |");
                Console.WriteLine("|  3          | MULTIPLICAR   |");
                Console.WriteLine("|  4          | DIVIDIR       |");
                Console.WriteLine("|__5__________|_SAIR__________|");
                Console.WriteLine("Escolha uma Opçaõ: ");
                opcao = Convert.ToInt32(Console.ReadLine());
               
            }



        }
    }
}
