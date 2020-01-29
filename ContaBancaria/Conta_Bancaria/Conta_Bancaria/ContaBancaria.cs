using System.Globalization;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; } //O Private para o Numero não ser alterado
        public string Titular { get; set; } //O Nome do Titular da Conta pode ser alterado em alguns casos
        public double Saldo { get; private set; } /*Private referente que
        o saldo da Conta pode ser alterado por saque ou deposito. */
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double DepositoInicial) : this(numero, titular)
        {
            Deposito(DepositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + ", Saldo: d$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
