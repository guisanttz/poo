using ConstrutorFuncionario;

int aumento;

Funcionario f1 = new Funcionario(Funcionario.Codigo, "Guilherme", 7400);
f1.MostrarAtributos();
Console.WriteLine("F1 - Digite um percentual de aumento: ");
aumento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Novo salário: {f1.ReajustarSalario(aumento):c}");

Funcionario f2 = new Funcionario(Funcionario.Codigo, "Rafael", 4280);
f2.MostrarAtributos();
Console.WriteLine("F2 - Digite um percentual de aumento: ");
aumento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Novo salário: {f2.ReajustarSalario(aumento):c}");

Funcionario f3 = new Funcionario(Funcionario.Codigo, "Maria", 3200);
f3.MostrarAtributos();
Console.WriteLine("F3 - Digite um percentual de aumento: ");
aumento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Novo salário: {f3.ReajustarSalario(aumento):c}");