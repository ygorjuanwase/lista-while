using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Digite um Nome, Caso Quera Parar, digite Fim: ");
            string nome = Console.ReadLine();
            while (nome != "fim")
            {
                Console.Write("Nome: ");
                 nome = Console.ReadLine();
                
            }


        }
    }
}
