using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{   // classe derivada : classe base
    public class Fisico : Cliente  // CliFisico está herdando atributos/metodos presentes na classe Cliente
    {
        public int Rg { get; set; }
        public Fisico() : base() // chama o construtor da classe base
        {
        }
        public Fisico(int codigo, string? nome, int rg) : base(codigo, nome)
        {
            Rg = rg;
        }
        public void Mostrar(){
            base.Mostrar();         // chama o método da classe base
            Console.WriteLine($"RG: {Rg}");
        }
    }
}