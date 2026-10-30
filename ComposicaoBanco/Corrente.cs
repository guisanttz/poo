using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Corrente
    {
        private double saldo;
        private bool chequeEspecial;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public bool ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }
        public Corrente(double saldo)
        {
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            
        }
        public void Sacar(double valor)
        {
            
        }
        public void GerarExtrato()
        {
            
        }
    }
}