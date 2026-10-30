using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poups;
        public List<Poupanca> Poups
        {
            get { return poups; }
            set { poups = value; }
        }
        private List<Corrente> contas;
        public List<Corrente> Contas
        {
            get { return contas; }
            set { contas = value; }
        }
        public void IniciarBanco()
        {
            poups = new List<Poupanca>();
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
