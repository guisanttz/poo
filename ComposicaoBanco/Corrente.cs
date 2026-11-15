using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Corrente
    {
        private double saldo;
        private double chequeEspecial;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public double ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }
        public Corrente(double saldo, double chequeEspecial)
        {
            Saldo = saldo;
            ChequeEspecial = chequeEspecial;
        }
        ~Corrente()
        {
            Console.WriteLine($"Conta corrente destruída");
            Console.WriteLine($"Saldo final: {saldo:c}");
        }
        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Conta Corrente - {valor:c} Depósito realizado");
        }
        public void Sacar(double valor)
        {
            saldo -= valor;
            Console.WriteLine($"Conta corrente - {valor:c} Saque realizado");
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"[Conta Corrente]\n Saldo: {Saldo:c}\nCheque Especial: {ChequeEspecial:c}");
        }
    }
}