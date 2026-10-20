using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Horista : Funcionario
    {
        private int qntdHorasSemana;
        public int QntdHorasSemana
        {
            get { return qntdHorasSemana; }
            set { qntdHorasSemana = value; }
        }
        public override double CalcularSalario()
        {
            return (Salario * QntdHorasSemana) / 4.5;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Qntd Horas Semana: {QntdHorasSemana}h\tSalário Calculado: {CalcularSalario():c}");
        }
    }
}