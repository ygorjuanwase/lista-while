using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Indique Seu Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            int quantidade = 0;
            while((peso > 0)&&(peso < 300))
            {
                Console.Write("peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                quantidade = quantidade + 1;

            }
            Console.Write("Quantidade de Pessoas Cadastradas: " + quantidade);



        }
    }
}
