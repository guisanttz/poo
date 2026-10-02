using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            get { return verba; }
            set 
            { 
                if (value >= 0)
                    verba = value;
                else
                    verba = 0; 
            }
        }
        public Comprador(double verba)
        {
            Verba = verba;
        }
        public void DiminuirVerba(double valor)
        {
            if (valor <= Verba)
                Verba -= valor;
            else
                Console.WriteLine("Verba insuficiente");
        }
        public void MostrarAtributo()
        {
            Console.WriteLine($"Verba: R${Verba:c}");
        }
    }
}