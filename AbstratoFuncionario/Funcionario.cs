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
        public abstract double CalcularSalario(int diasUteis);
        public void AdicionarDependente(Dependente novoDep)
        {
            VetD.Add(novoDep);
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
        public void RemoverDependentesMaioridade(int codigo)
        {
            for (int i = 0; i < VetD.Count; i++)
            {
                Dependente d = VetD.ElementAt<Dependente>(i);
                if (d.Codigo == codigo)
                {
                    VetD.Remove(d);
                }
            }
        }
        public void ListarDependentes()
        {
            foreach (var d in VetD)
            {
                d.Mostrar();
            }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:c}");
        }
    }
}