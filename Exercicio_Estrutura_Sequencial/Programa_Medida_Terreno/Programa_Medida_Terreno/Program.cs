using System;
using System.Globalization;

namespace Programa_Medida_Terreno
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura, comprimento, PrecoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PrecoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * PrecoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("f2", CultureInfo.InvariantCulture) );
            Console.WriteLine("PRECO = " + preco.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
