using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.Write(" Idade: ");
            int idade = 0;
            while (idade < 128)
            {
                Console.Write("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
