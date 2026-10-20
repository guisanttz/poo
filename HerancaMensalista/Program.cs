using HerancaMensalista;

System.Console.WriteLine("FUNCIONÁRIO");
Funcionario funcionario = new Funcionario(1, "Guilherme", 1000, 140);
funcionario.Mostrar();
Console.WriteLine($"Salário Calculado: {funcionario.CalcularSalario():c}");

System.Console.WriteLine("\n---------------------------\n");

System.Console.WriteLine("MENSALISTA");
Mensalista mensalista = new Mensalista(2, "João", 1000, 120);
mensalista.Mostrar();
System.Console.WriteLine($"Salário Calculado: {mensalista.CalcularSalario():c}");

System.Console.WriteLine("\n---------------------------\n");

System.Console.WriteLine("HORISTA");
Horista horista = new Horista(3, "Pedro", 1000, 40);
horista.Mostrar();
System.Console.WriteLine($"Salário Calculado: {horista.CalcularSalario():c}");