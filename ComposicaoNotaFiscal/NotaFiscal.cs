using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        public List<ItemNotaFiscal> VetItemNf { get; set; }
        public NotaFiscal(int numeroNf, string data)
        {
            NumeroNf = numeroNf;
            Data = data;
            VetItemNf = new List<ItemNotaFiscal>();
        }
        ~NotaFiscal()
        {
            {
            Console.WriteLine("Destrutor da nota fiscal");
        }
        }
    }
}