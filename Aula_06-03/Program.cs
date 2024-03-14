using Aula_06_03;

DateOnly data = DateOnly.FromDateTime(DateTime.Now);

Voo v1 = new Voo(1, data, 100);

//for (int i = 0; i < v1.MaxPassageiro; i++)
//{
//    Console.WriteLine(v1.vazio[i]);
//}

v1.vazio[0] = true;
//Console.WriteLine(v1.ProximoLivre());

Console.WriteLine(v1.VerificaStatus(10));

v1.Ocupar(10);

Console.WriteLine(v1.VerificaStatus(10));