using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "João", 1000);
Assalariado a2 = new Assalariado(2, "Maria", 1000);
Comissionado c1 = new Comissionado(3, "José", 1000, 0.20);
Comissionado c2 = new Comissionado(4, "Alice", 1000, 0.30);

Departamento d1 = new Departamento(11, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
System.Console.WriteLine($"Total {d1.CalcularFolha(30)}");

Departamento d2 = new Departamento(12, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
/* d2.Demitir(2); // a2 tem código 2
d2.Listar(); */
System.Console.WriteLine($"Total {d2.CalcularFolha(30)}");