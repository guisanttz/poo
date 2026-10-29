using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public Endereco Endereco { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VetD { get; set; }
        public void AdicionarDependente(Dependente d)
        {
            VetD.Add(d);
        }
        public Funcionario(int codigo, string? nome, Endereco endereco, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Salario = salario;
        }
        public int CalcularTotalDependente()
        {
            return VetD.Count();
        }
        public void RemoverDpendentesMaioridade(int codigo)
        {
            foreach (var dep in VetD)
            {
                if (dep.Codigo == codigo)
                {
                    VetD.Remove(dep);
                    break;
                }
            }
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:c}");
        }
    }
}