using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        // Primeira etapa do encapsulamento -> definir privates para os atributos
        private int numero;
        private string? titular;
        private double saldo;
        // Segunda etapa -> criar os métodos de encapsulamento get e set
        public int Numero // c maiúsculo é função/implícita
        {
            get{
                return this.numero;
            }

            set{
                this.numero = value;
            }
        }

        public string? Titular
        {
            get{
                return this.titular;
            }

            set{
                this.titular = value;
            }
        }

        public double Saldo
        {
            get 
            { 
                return saldo; 
            }
            set 
            { 
                saldo = value; 
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero}\tTitular: {Titular}\tSaldo: {Saldo:c}");
        }
        
    }
}