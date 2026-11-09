using SolidFuncionario;

Funcionario funcionario = new Funcionario("Carlos", 5000);
Console.WriteLine($"Salario ajustado: {funcionario.CalcularSalario("Permanente")}");