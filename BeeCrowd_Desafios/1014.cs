using System;
using System.Globalization;

namespace media_combustivel
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            int m;
            double d, media;

            m = int.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            media = m / d;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


        }
    }
}