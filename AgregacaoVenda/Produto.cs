using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private static int padraoCodigo = 501;
        private int codigo;
        private string? nome;
        private double preco;
        public Produto(string nome, double preco)
        {
            codigo = padraoCodigo++;
            Nome = nome;
            Preco = preco;
        }
        public int Codigo
        {
            get { return codigo; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\nNome: {Nome}\nPreço: {Preco:c}");
        }
    }
}