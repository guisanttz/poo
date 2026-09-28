using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qntd { get; set; }
        public ItemNotaFiscal(int qntd)
        {
            Qntd = qntd;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Qntd: {Qntd}");
        }
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destrutor do item de nota fiscal");
        }
    }
}