using AtividadeAvaliativa_Multas.RegrasDeNegocio;

string cpf;

Console.WriteLine("===VALIDAR CPF===");
Console.Write("CPF: ");
cpf = Console.ReadLine();
Validacoes.ValidarCpf(cpf);