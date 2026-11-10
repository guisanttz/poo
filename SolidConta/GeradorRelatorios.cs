using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidConta
{
    public class GeradorRelatorios
    {
        public string GerarRelatorio(Conta conta);
        {
            Console.WriteLine("Titular: {Titular}\tSaldo: {Saldo:C}");
        }
    }
}