
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace banana
{
    class program
    {
        static void Main(string[] args)
        {

            double recebe;

            recebe = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (recebe >= 0.00 && recebe <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (recebe > 25.00 && recebe <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (recebe > 50.00 && recebe <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }

            else if (recebe > 75.00 && recebe <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }

    }
}