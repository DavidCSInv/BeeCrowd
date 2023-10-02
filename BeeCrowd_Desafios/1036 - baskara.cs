using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace baskara
{
    class program
    {
        static void Main(string[] args)
        {

            double A, B, C, delta, x, x1;

            String[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2) - 4 * A * C;

            if ((A * C) == 0.0 || delta < 0.0)
            {

                Console.WriteLine("Impossivel Calcular");

            }

            else

            {
                x = (-B + Math.Sqrt(delta)) / (2.0 * A);
                x1 = (-B - Math.Sqrt(delta)) / (2.0 * A);

                Console.WriteLine("X1 = " + x.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}