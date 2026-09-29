using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public Vendedor(double comissao)
        {
            Comissao = comissao;
        }
        public void CalcularComissao()
        {
            
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("");
        }
    }
}