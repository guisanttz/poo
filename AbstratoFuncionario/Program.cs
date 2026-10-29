using AbstratoFuncionario;

/* Instâncias dos Endereços */
Endereco end1 = new Endereco("Rua Esmeralda", 84, "Jardim das Flores", "Presidente Prudente");
Endereco end2 = new Endereco("Rua Safira", 253, "Jardim das Flores", "Presidente Prudente");
Endereco end3 = new Endereco("Rua Diamante", 72, "Jardim das Flores", "Presidente Prudente");
Endereco end4 = new Endereco("Rua Rubi", 421, "Jardim das Flores", "Presidente Prudente");

/* Instâncias dos Funcionários */
Assalariado a1 = new Assalariado(1, "João", end1, 1000);
Assalariado a2 = new Assalariado(2, "Maria", end2, 1000);
Comissionado c1 = new Comissionado(3, "José", end3, 1000, 0.20);
Comissionado c2 = new Comissionado(4, "Alice", end4, 1000, 0.30);

/* Instâncias dos Dependentes */
Dependente depen1 = new Dependente(3, "Vitor", 12);
Dependente depen2 = new Dependente(4, "Arthur", 7);
Dependente depen3 = new Dependente(5, "Pedro", 9);
Dependente depen4 = new Dependente(6, "Luan", 2);

/* Adicionando Dependentes para os Funcionários */
a1.VetD = new List<Dependente>();
a1.AdicionarDependente(depen1);
a2.VetD = new List<Dependente>();
a2.AdicionarDependente(depen2);
c1.VetD = new List<Dependente>();
c1.AdicionarDependente(depen3);
c2.VetD = new List<Dependente>();
c2.AdicionarDependente(depen4);

/* Instâncias dos Departamentos */
Departamento d1 = new Departamento(11, "TI");
Departamento d2 = new Departamento(12, "RH");

d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
System.Console.WriteLine($"Total {d1.CalcularFolha(30)}");

d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
// d2.Demitir(2); inserir código do funcionário
System.Console.WriteLine($"Total {d2.CalcularFolha(30)}");