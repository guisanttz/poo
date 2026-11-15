using InterfaceITributavel;

TotalizadorDeTributos totalizadortributos = new TotalizadorDeTributos();

ContaCorrente contacorrente = new ContaCorrente();
contacorrente.Saldo = 500;
Console.WriteLine($"Saldo Conta Corrente: {contacorrente.Saldo:c}");

SeguroVida segurovida = new SeguroVida();
segurovida.ValorDoSeguro = 100;
Console.WriteLine($"Valor do Seguro de Vida: {segurovida.ValorDoSeguro:c}\n");

ITributavel itributavel = contacorrente;
Console.WriteLine($"Tributos Conta Corrente: {contacorrente.CalcularTributos():c}");
totalizadortributos.Adicionar(itributavel);

itributavel = segurovida;
Console.WriteLine($"Tributos Seguro de Vida: {segurovida.CalcularTributos():c}\n");
totalizadortributos.Adicionar(itributavel);

Console.WriteLine($"Total: {totalizadortributos.Total:c}");
