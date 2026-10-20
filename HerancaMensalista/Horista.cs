using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Horista : Funcionario
    {
        public int QntdHorasSemana { get; set; }
        public Horista(int codigo, string? nome, double salario, int qntdHorasSemana) 
        : base(codigo, nome, salario, qntdHorasSemana)
        {
            QntdHorasSemana = qntdHorasSemana;
        }
        public override double CalcularSalario()
        {
            return (Salario * QntdHorasSemana) / 4.5;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}   Nome: {Nome}   Qntd Horas Semana: {QntdHorasSemana}h");
        }
    }
}