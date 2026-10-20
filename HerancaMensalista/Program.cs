using HerancaMensalista;

Console.WriteLine("---------------------------");

Console.WriteLine("FUNCIONÁRIO");
Funcionario funcionario = new Funcionario();
funcionario.Codigo = 1;
funcionario.Nome = "Guilherme";
funcionario.Salario = 1000;
funcionario.QntdHorasTrabalhadas = 140;
funcionario.Mostrar();
System.Console.WriteLine($"Qntd Horas Trabalhadas: {funcionario.QntdHorasTrabalhadas}h   Salário Calculado: {funcionario.CalcularSalario():c}");


Console.WriteLine("---------------------------");

Console.WriteLine("MENSALISTA");
Mensalista mensalista = new Mensalista();
mensalista.Codigo = 2;
mensalista.Nome = "João";
mensalista.Salario = 1000;
mensalista.QntdHorasTrabalhadas = 120;
mensalista.Mostrar();

Console.WriteLine("---------------------------");

Console.WriteLine("HORISTA");
Horista horista = new Horista();
horista.Codigo = 3;
horista.Nome = "Pedro";
horista.Salario = 1000;
horista.QntdHorasSemana = 40;
horista.Mostrar();

Console.WriteLine("---------------------------");