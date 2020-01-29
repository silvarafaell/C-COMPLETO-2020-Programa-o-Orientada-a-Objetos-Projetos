using System;
using System.Globalization;

namespace Nota_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            double Nota1, nota2, soma;

            Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = Nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if (soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();
        }
    }
}
