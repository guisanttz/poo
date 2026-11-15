using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poupancas;
        private List<Corrente> contas;
        public Banco()
        {
            IniciarBanco();
        }
        public void IniciarBanco()
        {
            poupancas = new List<Poupanca>();
            contas = new List<Corrente>();   
        }
        public void AbrirConta(double saldo, double chequeEspecial)
        {
            Corrente contaCorrente = new Corrente(saldo, chequeEspecial);
            contas.Add(contaCorrente);
            Console.WriteLine("Nova conta corrente criada.");
        }
        public void AbrirPoupanca(double saldo)
        {
            Poupanca contaPoupanca = new Poupanca(saldo);
            poupancas.Add(contaPoupanca);
            Console.WriteLine("Nova conta poupança criada.");
        }
    }
}
