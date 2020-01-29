using System;
using System.Globalization;
namespace Numero_Raiz
   
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um Numero: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x  >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro Numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero Negativo");
        }
    }
}
