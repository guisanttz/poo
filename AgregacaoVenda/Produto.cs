using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo;
        private string? nome;
        private double preco;
        public int Codigo
        {
            get { return codigo; }
            set 
            { 
                if (value > 501)
                    codigo = value;
                else
                    codigo = 501;
            }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set 
            { 
                if (value >= 0)
                    preco = value;
                else
                    preco = 0; 
            }
        }

        public Produto(string nome, double preco)
        {
            Codigo = 501;
            Nome = nome;
            Preco = preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\nNome: {Nome}\nPreço: {Preco:c}");
        }
    }
}