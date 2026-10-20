using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public int QntdHorasTrabalhadas { get; set; }
        public Funcionario(int codigo, string? nome, double salario, int qntdHorasTrabalhadas)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            QntdHorasTrabalhadas = qntdHorasTrabalhadas;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}   Nome: {Nome}\nSalário: {Salario:c}   Qntd Horas Trabalhadas: {QntdHorasTrabalhadas}h");
        }
        public virtual double CalcularSalario()
        {
            return (Salario * QntdHorasTrabalhadas) / 30;
        }
    }
}