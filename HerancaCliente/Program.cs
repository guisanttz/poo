using HerancaCliente;

Cliente cli1 = new Cliente();
cli1.Codigo = 1;
cli1.Nome = "Gui";
/* cli1.Mostrar(); */

Cliente cli2 = new Cliente(21, "Jão");

CliFisico f1 = new CliFisico();
f1.Codigo = 2;
f1.Nome = "Caua";
f1.Rg = 123;
f1.Mostrar();