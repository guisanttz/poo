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
        private int aumento;

        public int Matricula
        {
            get
            {
                return this.matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
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

        public double CalcularAumento(int aumento, Funcionario Salario)
        {
            return salario + (salario * (aumento / 100) );
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matrícula: {Matricula}\tNome: {Nome}\tSalário: {Salario:c}");
        }

    }
}