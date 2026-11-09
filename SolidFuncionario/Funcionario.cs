using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
        public double CalcularSalario(string tipoFuncionario)
        {
            if (tipoFuncionario == "Permanente")
                return Salario * 1.3;
            else if (tipoFuncionario == "Contrato")
                return Salario;
            else
                Console.WriteLine("Tipo inválido");
        }
    }
}