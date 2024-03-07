// Exercicio 1 - Aula POO 21/02/2024

using Exercicio1;

Banco b = new Banco();

//b.SetSaldo(-100);
Console.Write("Saldo: ");
b.SetSaldo(Convert.ToDouble(Console.ReadLine()));
Console.WriteLine($"Seu saldo é: {b.GetSaldo()}");

//Console.Write("Informe o seu ID: ");
//int id = int.Parse(Console.ReadLine());
//banco.id = id;

//Console.Write("Informe o seu Nome: ");
//string nome = Console.ReadLine();
//banco.nomeProprietario = nome;

//Console.Write("Informe o Número da Agência: ");
//int agencia = int.Parse(Console.ReadLine());
//banco.agencia = agencia;

//Console.Write("Informe o Número da Conta: ");
//int conta = int.Parse(Console.ReadLine());
//banco.conta = conta;

//Console.Write("Informe o Saldo atual da sua conta: ");
//double saldo = double.Parse(Console.ReadLine());
//banco.saldo = saldo;

//Console.Write("");

//Console.Write("Faça um depósito em sua conta: ");
//double deposito = double.Parse(Console.ReadLine());
//banco.Deposito(deposito);
//Console.WriteLine();
//Console.WriteLine($"Novo saldo: " + banco.saldo);

//Console.Write("");

//Console.Write("Faça um saque em sua conta: ");
//double saque = double.Parse(Console.ReadLine());
//banco.Saque(saque);
//Console.WriteLine();
//Console.WriteLine($"Novo saldo: " + banco.saldo);



//Console.ReadKey();