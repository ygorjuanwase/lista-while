using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    class Exercicio04
    {
        public Exercicio04()
        {



            int carroscadstrados = 0;
            Console.WriteLine("Deseja Cadastrar Quantos Carros: ");
            int quantidadedecarros = Convert.ToInt32(Console.ReadLine());
            int anosdoscarros = 0;
            double valordoscarros = 0;
            int quantidadedelatrasg = 0;
            int quantidadedeletrasa = 0;

            while(carroscadstrados < quantidadedecarros)
            
            {
                Console.Clear();
                Console.Write("Modelo do Carro: ");
                string modelocarro = Console.ReadLine();
                Console.Write("Valor do Carro: ");
                double valorcarro = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ano do Carro: ");
                int anocarro = Convert.ToInt32(Console.ReadLine());
                carroscadstrados = carroscadstrados + 1;
                // quantidadedecarros = carroscadstrados + quantidadedecarros;
                anosdoscarros = anosdoscarros + anocarro;
                valordoscarros = valordoscarros + valorcarro;
                string letra = modelocarro.Substring(0, 1).ToUpper();
                if (letra == "G")
                {
                   quantidadedelatrasg = quantidadedelatrasg + 1;
                }

                if (letra == "A")
                {
                    quantidadedeletrasa = quantidadedeletrasa+ 1;
                }
            }
            double mediaanoscarros = anosdoscarros / carroscadstrados;
            Console.WriteLine("Média dos Anos Dos Carros; " + mediaanoscarros);
            double mediavalorcarrros = valordoscarros / carroscadstrados;
            Console.WriteLine("Média Do Valor Dos Carros: " + mediavalorcarrros);
            Console.WriteLine("Qauntidades de Carros Com a Letra G :" + quantidadedelatrasg);
            Console.WriteLine("Quantidade de Carros com a Letra A : " + quantidadedeletrasa);
        }
    }
}
