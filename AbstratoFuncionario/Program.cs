using AbstratoFuncionario;

/* Instâncias dos Endereços */
Endereco end1 = new Endereco("Rua Esmeralda", 84, "Jardim das Flores", "Presidente Prudente");
Endereco end2 = new Endereco("Rua Safira", 253, "Jardim das Flores", "Presidente Prudente");
Endereco end3 = new Endereco("Rua Diamante", 72, "Jardim das Flores", "Presidente Prudente");
Endereco end4 = new Endereco("Rua Rubi", 421, "Jardim das Flores", "Presidente Prudente");

/* Instâncias dos Funcionários */
Assalariado ass1 = new Assalariado(1, "João", end1, 1000);
Assalariado ass2 = new Assalariado(2, "Maria", end2, 1000);
Comissionado com1 = new Comissionado(3, "José", end3, 1000, 0.20);
Comissionado com2 = new Comissionado(4, "Alice", end4, 1000, 0.30);

/* Instâncias dos Dependentes */
Dependente depen1 = new Dependente(3, "Vitor", 12);
Dependente depen2 = new Dependente(4, "Arthur", 7);
Dependente depen3 = new Dependente(5, "Pedro", 9);
Dependente depen4 = new Dependente(6, "Luan", 2);

/* Adicionando Dependentes para os Funcionários */
ass1.VetD = new List<Dependente>();
ass1.AdicionarDependente(depen1);
ass1.AdicionarDependente(depen2);
ass2.VetD = new List<Dependente>();
ass2.AdicionarDependente(depen2);
com1.VetD = new List<Dependente>();
com1.AdicionarDependente(depen3);
com2.VetD = new List<Dependente>();
com2.AdicionarDependente(depen4);

/* Instâncias dos Departamentos */
Departamento depTI = new Departamento(11, "TI");
Departamento depRH = new Departamento(12, "RH");

depTI.VetF = new List<Funcionario>();
depTI.AdmitirFuncionario(ass1);
depTI.AdmitirFuncionario(com1);
depTI.ListarNomeFuncionarioESalario();Console.WriteLine($"Total {depTI.CalcularFolhaPagamento(30)}");
depTI.MostrarQtdeDependentesFuncionario();


depRH.VetF = new List<Funcionario>();
depRH.AdmitirFuncionario(ass2);
depRH.AdmitirFuncionario(com2);
depRH.ListarNomeFuncionarioESalario();
Console.WriteLine($"Total {depRH.CalcularFolhaPagamento(30)}");
depRH.MostrarQtdeDependentesFuncionario();

// Caso queira demitir algum funcionário: 

// depRH.DemitirFuncionario(2); inserir código do funcionário