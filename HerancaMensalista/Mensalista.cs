using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Mensalista : Funcionario
    {
        public Mensalista(int codigo, string? nome, double salario, int qntdHorasTrabalhadas) : base(codigo, nome, salario, qntdHorasTrabalhadas)
        {
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}   Nome: {Nome}   Qntd Horas Trabalhadas: {QntdHorasTrabalhadas}h");
        }
    }
}