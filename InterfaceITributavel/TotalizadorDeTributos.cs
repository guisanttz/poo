using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    public class TotalizadorDeTributos
    {
        public double Total { get; set; }
        public void Adicionar(ITributavel trib)
        {
            Total += trib.CalcularTributos();
        }
    }
}