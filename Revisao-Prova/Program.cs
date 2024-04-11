using Revisao_Prova;

//Matematica mat = new Matematica();

//mat.num1 = 10;
//mat.num2 = 2;

//Console.WriteLine($"Soma: {mat.Somar(10, 2)}");
//Console.WriteLine($"Multiplicação: {mat.Multiplicar()}");

//Console.WriteLine("===CALCULAR ÁREA DO CIRCULO===");
//Console.Write("Digite o raio: ");
//double raio = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine();
//Circulo cir =  new Circulo();
//cir.raio = raio;
//Console.WriteLine($"A área do circulo é: {cir.Calculo()}");

Console.WriteLine("===CALCULAR ÁREA DO TRIÂNGULO===");
Triangulo tri = new Triangulo();
Console.Write("Aresta 1: ");
tri.aresta1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Aresta 2: ");
tri.aresta2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Aresta 3: ");
tri.aresta3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"A área do triângulo é: {tri.AreaTriangulo()}");