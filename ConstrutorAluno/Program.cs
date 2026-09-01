using System.Diagnostics.Contracts;
using ConstrutorAluno;

Aluno aluno1 = new Aluno(Aluno.Ra, "Guilherme");
aluno1.MostrarAtributos();

Aluno aluno2 = new Aluno(Aluno.Ra, "Adryan");
aluno2.MostrarAtributos();

Aluno aluno3 = new Aluno(Aluno.Ra, "Cauã");
aluno3.MostrarAtributos();
System.Console.WriteLine($"Quantidade de Instâncias: {Aluno.Contador}");