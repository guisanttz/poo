using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Mensalista : Funcionario
    {
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Qntd Horas Trabalhadas: {QntdHorasTrabalhadas}h\tSalário Calculado: {CalcularSalario():c}");
        }
    }
}