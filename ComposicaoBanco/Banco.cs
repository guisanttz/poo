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
        public List<Poupanca> Poupancas
        {
            get { return poupancas; }
            set { poupancas = value; }
        }
        public List<Corrente> Contas
        {
            get { return contas; }
            set { contas = value; }
        }
        public void IniciarBanco()
        {
            poupancas = new List<Poupanca>();
            contas = new List<Corrente>();   
        }
        public void AbrirConta()
        {
            
        }
        public void AbrirPoupanca()
        {
            
        }
    }
}
