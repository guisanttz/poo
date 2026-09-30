using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;
        public double Comissao
        {
            get { return comissao; }
            set
            {
                if (value >= 0)
                    comissao = value;
                else
                    comissao = 0;
            }
        }
        public void CalcularComissao(double precoProduto)
        {
            Comissao = precoProduto * 0.02;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão: R$ {Comissao:c}");
        }
    }
}