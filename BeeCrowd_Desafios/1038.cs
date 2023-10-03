using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Treino.BeeCrowd_Desafios
{
    class Class1
    {
        static void Main(string[] args)
        {

            double quantidade;
            int codigo;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet  [0]);
            quantidade = double.Parse(vet[1]);

            switch (codigo){

                case 1:
                    quantidade *= 4.00;
                        break;

                case 2:
                    quantidade *= 4.50;
                    break;

                case 3:
                    quantidade *= 5.00;
                    break;

                case 4:
                    quantidade *= 2.00;
                    break;

                case 5:
                    quantidade *= 1.50;
                    break;

            }

            Console.WriteLine("Total: R$ " + quantidade.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
