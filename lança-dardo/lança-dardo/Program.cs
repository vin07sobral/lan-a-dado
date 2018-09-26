using System;
using System.Globalization;
namespace revisao_logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);
            if (x > y && x > z)
            {
                Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (y > z)
            {
                Console.WriteLine(y.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}