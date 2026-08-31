using ConstrutorConta;

Conta c1 = new Conta(); // CONSTRUTOR PADRÃO
c1.MostrarAtributos();
Conta c2 = new Conta(123);
c2.MostrarAtributos();
Conta c3 = new Conta(970, "Guilherme", 7400);
c3.MostrarAtributos();