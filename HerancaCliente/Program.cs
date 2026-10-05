using HerancaCliente;

Cliente cli1 = new Cliente();
cli1.Codigo = 1;
cli1.Nome = "Gui";
cli1.Mostrar();

Cliente cli2 = new Cliente(21, "Jão");
cli2.Mostrar();

Fisico f1 = new Fisico();
f1.Codigo = 2;
f1.Nome = "Caua";
f1.Rg = 123;
f1.Mostrar();

Fisico f2 = new Fisico(23, "Adryan", 321);
f2.Mostrar();