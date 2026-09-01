using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public static long Ra { get; set; }
        public static int Contador { get; set; }
        public string? Nome { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"RA: {Ra}\tNome: {Nome}");
        }
        public Aluno(long ra, string nome)
        {
            Aluno.Ra += 1;
            Contador += 1;
            this.Nome = nome;
        }
    }
}