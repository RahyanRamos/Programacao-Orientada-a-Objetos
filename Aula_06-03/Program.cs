using Aula_06_03;

DateTime data = DateTime.Now;
int numero = 5;

Voo v1 = new Voo(numero, data);

Console.WriteLine(v1.numero);
Console.WriteLine(v1.data);