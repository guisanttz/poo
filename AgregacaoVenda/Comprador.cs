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
        public void DiminuirVerba()
        {

        }
        public void MostrarAtributo()
        {

        }
    }
}