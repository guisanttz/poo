using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public static int Codigo = 100;
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:c}");
        }
        public double ReajustarSalario(double aumento)
        {
            double novoSalario = Salario + (Salario * (aumento / 100));
            return novoSalario;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Funcionario.Codigo += 1;
            this.Nome = nome;
            this.Salario = salario;
            Contador += 1;
        }
    }
}