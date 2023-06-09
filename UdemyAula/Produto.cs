using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAula
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return total;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }


        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F3", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
