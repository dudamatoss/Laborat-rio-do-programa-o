Empresa empresa = new Empresa();
Funcionario f1 = new Funcionario("Eduarda", 19);
Gerente gerente = new Gerente("Maria", 57, 5000.0);
Estagiario estagiario = new Estagiario("Laura", 16);

empresa.AdicionarFuncionario(f1);
empresa.AdicionarFuncionario(gerente);
empresa.AdicionarFuncionario(estagiario);

empresa.ListarFuncionarios();

