using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProd;
        public Venda(Comprador comprador, Vendedor vendedor)
        {
            comp = comprador;
            vend = vendedor;
            vetProd = new List<Produto>();
        }
        public void AdicionarProduto(Produto produto)
        {
            vetProd.Add(produto);
        }
        public void MostrarAtributos()
        {
            foreach (Produto produto in vetProd)
            {
                produto.MostrarAtributos();
            }
        }
    }
}