using HerancaFuncionario;
using PolimorfismoBonificacao;

Funcionario fun = new Funcionario(1, "Jão", 1000);
Secretario sec = new Secretario(2, "Vitu", 1000);
Gerente ger = new Gerente(3, "Lucas", 1000);
Diretor dir = new Diretor(4, "Gui", 1000);

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

fun.Mostrar();
Console.WriteLine($"Bonificação Funcionário {fun.CalcularBonificacao()}");

sec.Mostrar();
Console.WriteLine($"Bonificação Secretário {sec.CalcularBonificacao()}");

ger.Mostrar();
Console.WriteLine($"Bonificação Gerente {ger.CalcularBonificacao()}");

dir.Mostrar();
Console.WriteLine($"Bonificação Diretor {dir.CalcularBonificacao()}");

gerenciador.TotalizadorBonificacao(fun);
gerenciador.TotalizadorBonificacao(sec);
gerenciador.TotalizadorBonificacao(ger);
gerenciador.TotalizadorBonificacao(dir);

Console.WriteLine($"Total de Bonificações: {gerenciador.TotalBonificacao:c}");