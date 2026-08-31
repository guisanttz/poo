using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero}\tTitular: {Titular}\tSaldo: {Saldo:c}");
        }
        public Conta() // CONSTRUTOR PADRÃO
        {
            Contador = Contador + 1;
        }
        public Conta(int numero) // CONSTRUTOR COM UM PARÂMETRO
        {
            this.Numero = numero;
            Contador = Contador + 1;
        }
        public Conta(int numero, string titular, double saldo) // CONSTRUTOR COM MAIS PARÂMETRO
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            Contador = Contador + 1;
        }
    }
}