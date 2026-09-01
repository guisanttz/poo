using AgregacaoContaArray;
List <Cliente> vetCli = new List<Cliente>();
Cliente cli1 = new Cliente("Gui", 123);
Cliente cli2 = new Cliente("Ana", 432);
vetCli.Add(cli1);
vetCli.Add(cli2);

Conta c1 = new Conta(1, 5000);
c1.VetTitulares = vetCli;
c1.Mostrar();
foreach (var cli in c1.VetTitulares)
{   
    cli.Mostrar();
}