using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        // public int Matricula { get; set; }
        private int matricula;
        private string nome;
        private double salario;

        public int Matricula
        {
            get { return this.matricula; }
            set { matricula = value; }
        }

        public string? Nome
        {
            get { return this.nome; }
            set
            {
                if (value != "")
                    nome = value;
                else
                    Console.WriteLine("Nome inválido!");
            }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void CalcularAumento(int aumento)
        {
            Salario += Salario * aumento / 100.0;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matrícula: {Matricula}\tNome: {Nome}\tSalário: {Salario:c}");
        }

    }
}