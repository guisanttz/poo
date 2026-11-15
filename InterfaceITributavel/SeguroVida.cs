using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    public class SeguroVida : ITributavel
    {
        public int ValorDoSeguro { get; set; }
        public double CalcularTributos()
        {
            return 75;
        }
    }
}