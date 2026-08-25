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
                if (this.titular != "")
                    this.titular = value;
                else
                    Console.WriteLine("Nome inválido!");
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
                if (value >= 0)
                    saldo = value;
                else
                    Console.WriteLine("Saldo negativo não aceito!");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero}\tTitular: {Titular}\tSaldo: {Saldo:c}");
        }
        
    }
}