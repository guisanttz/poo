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
        // Segunda etapa -> criar os métodos de encapsulamento set e get
        public int Numero // c maiúsculo é função/implícita
        {
            set{
                this.numero = value;
            }

            get{
                return this.numero;
            }
        }

        public string? Titular
        {
            set{
                this.titular = value;
            }

            get{
                return this.titular;
            }
        }

        public double Saldo
        {
            set{
                this.saldo = value;
            }

            get{
                return this.saldo;
            }
        }
    }
}