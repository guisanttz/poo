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
        ~Poupanca()
        {
            Console.WriteLine($"Conta poupança destruída");
            Console.WriteLine($"Saldo final: {saldo:c}");
        }
        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Conta Poupança - {valor:c} Depósito realizado");
        }
        public void Sacar(double valor)
        {
            saldo -= valor;
            Console.WriteLine($"Conta Poupança - {valor:c} Saque realizado");
        }
        public void GerarRendimento(double taxa)
        {
            double rendimento = saldo * (taxa / 100.0);
            saldo += rendimento;
            Console.WriteLine($"Rendimento aplicado: {taxa}%\n Valor do rendimento: {rendimento:C}");
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"[Conta Poupança]\n Saldo: {Saldo:c}");
        }
    }
}