using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public static int Contador { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco:c}");
        }
        public Produto(int codigo)
        {
             this.Codigo = codigo;
             Contador++;
        }
        public Produto(string nome)
        {
            this.Nome = nome;
            Contador++;
        }
        public Produto(double preco)
        {
            this.Preco = preco;
            Contador++;
        }
        public Produto(int codigo, string nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
            Contador++;
        }
    }
}