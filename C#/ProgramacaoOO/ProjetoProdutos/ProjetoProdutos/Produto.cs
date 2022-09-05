using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProdutos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidade(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2",CultureInfo.InvariantCulture)
                +", "
                +Quantidade
                +" unidades, Total : $ "
                +ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
