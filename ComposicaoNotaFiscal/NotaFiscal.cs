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
        public NotaFiscal(int numeroNf, string data, List<ItemNotaFiscal> vetItem)
        {
            NumeroNf = numeroNf;
            Data = data;
            VetItemNf = vetItem;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Número da nota fiscal: {NumeroNf}");
            foreach (var item in VetItemNf)
            {
                item.Mostrar();
            }
        }
        ~NotaFiscal()
        {
            {
                Console.WriteLine("Destrutor da nota fiscal");
            }
        }
    }
}