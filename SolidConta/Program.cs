using SolidConta;

Conta conta1 = new Conta("João");
conta1.Deposito(150);
conta1.GerarRelatorio();

ValidadorUsuario validadorUsuario = new ValidadorUsuario(conta1, "João");
validadorUsuario.ValidarUsuario()