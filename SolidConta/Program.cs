using SolidConta;

Conta conta = new Conta("Gui Santos");
conta.Deposito(500);
conta.Sacar(100);

ValidadorUsuarios validador = new ValidadorUsuarios();
bool eValido = validador.ValidarUsuario(conta, "Gui Santos");
Console.WriteLine($"Usuário válido? {eValido}");

GeradorRelatorios gerador = new GeradorRelatorios();
string relatorio = gerador.GerarRelatorio(conta);

Console.WriteLine("Relatório da Conta");
Console.WriteLine(relatorio);