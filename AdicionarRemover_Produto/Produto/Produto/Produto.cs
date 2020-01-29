using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produto
{
    class Produto
    {
        public String Nome;
        public double Preco;
        public int Quantidade;

        public double ValortotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + "unidades,Total: $ "
                + ValortotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
