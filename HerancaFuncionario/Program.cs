using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Jão", 1000);
Secretario s = new Secretario(2, "Vitu", 1000);
Gerente g = new Gerente(3, "Lucas", 1000);
Diretor d = new Diretor(4, "Gui", 1000);
f.Mostrar();
Console.WriteLine($"Bonificação Funcionário {f.CalcularBonificacao()}");

s.Mostrar();
Console.WriteLine($"Bonificação Secretário {s.CalcularBonificacao()}");

g.Mostrar();
Console.WriteLine($"Bonificação Gerente {g.CalcularBonificacao()}");

d.Mostrar();
Console.WriteLine($"Bonificação Diretor {d.CalcularBonificacao()}");