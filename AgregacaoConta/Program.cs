using AgregacaoConta;


Cliente cli = new Cliente("Gui", 123);
Conta c1 = new Conta(1, 150);
// EFETIVAÇÃO DA AGREGAÇÃO
c1.Titular = cli;
c1.Mostrar();

Conta c2 = new Conta(2, 200);
c2.Titular = new Cliente("Jão", 422);
c2.Mostrar();