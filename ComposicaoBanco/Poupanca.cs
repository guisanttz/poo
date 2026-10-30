using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Poupanca(double saldo)
        {
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            
        }
        public void Sacar(double valor)
        {
            
        }
        public void GerarRendimento(double taxa)
        {
            
        }
    }
}