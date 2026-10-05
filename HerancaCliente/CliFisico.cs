using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{   // classe derivada : classe base
    public class CliFisico : Cliente  // CliFisico está herdando atributos/metodos presentes na classe Cliente
    {
        public int Rg { get; set; }
        public CliFisico() : base()
        {
        }
        public CliFisico(int codigo, string? nome) : base(codigo, nome)
        {
            Rg = rg;
        }
        public void Mostrar(){
            Console.WriteLine($"Código: {codigo}\tNome: {nome}");
        }
    }
}