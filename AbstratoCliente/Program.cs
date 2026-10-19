using AbstratoCliente;

/* Cliente c = new Cliente(1, "Ana", 19); */

Fisico f = new Fisico(1, "Ana", 19, 123321);
f.Mostrar();

Teste t = new Teste();
t.AvaliarIdadeCliente(f);

Juridico j = new Juridico(3, "Empresa", 40, 4321);
j.Mostrar();
t.AvaliarIdadeCliente(j);