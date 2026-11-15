using ComposicaoBanco;

Banco banco = new Banco();

banco.AbrirConta(5000.00, 1000.00);
banco.AbrirPoupanca(7500.00);

banco.Correntes[0].Depositar(500);
banco.Correntes[0].Sacar(100);
banco.Correntes[0].GerarExtrato();

banco.Poupancas[0].Depositar(1000.00);
banco.Poupancas[0].GerarRendimento(0.05);
banco.Poupancas[0].GerarExtrato();

banco.DescretarFalencia();
GC.Collect();