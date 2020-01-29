using System;
using System.Globalization;

namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre o Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n?) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') // == igual || ou
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, DepositoInicial); 

            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um Valor para Deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um Valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
