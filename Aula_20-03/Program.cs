using Aula_20_03;

int op = 0;

List<Produto> produto = new List<Produto>();

do
{
    Console.WriteLine("===MENU DE SELEÇÃO===");
    Console.WriteLine("1 - Cadastrar Produtos");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("3 - Excluir Produto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("=====================");
    op = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (op)
    {
	    case 1:
		    int cont = 1;
		    do
		    {
			    Produto prod = new Produto();
                Console.WriteLine("===CADASTRAR PRODUTOS===");
                Console.WriteLine();
                Console.Write("Código: ");
			    prod.id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome: ");
			    prod.descricao = Console.ReadLine();
			    Console.Write("Unidade: ");
			    prod.SetUnidade(Console.ReadLine());
                Console.Write("preco: ");
			    prod.SetPreco(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Quantidade no estoque: ");
			    prod.estoque = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=========================");
			    produto.Add(prod);
                Console.WriteLine();
                Console.WriteLine("Produto cadastrado com sucesso!");
			    Console.ReadKey();
			    Console.Clear();
			    Console.WriteLine("Deseja cadastrar outro produto?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("0 - Não");
                cont = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (cont != 0);
		    break;

	    case 2:
            Console.WriteLine("===LISTAR PRODUTOS===");
            Console.WriteLine();

            foreach (Produto prod in produto)
		    {
                Console.WriteLine($"Código: {prod.id}");
                Console.WriteLine($"Produto: {prod.descricao}");
                Console.WriteLine($"Unidade: {prod.GetUnidade()}");
                Console.WriteLine($"Preço: {prod.GetPreco()}");
                Console.WriteLine($"Estoque: {prod.estoque}");
                Console.WriteLine("=============================");
            }
            Console.ReadKey();
            Console.Clear();
            break;

        case 3:
            Console.WriteLine("===EXCLUIR PRODUTO===");
            Console.WriteLine();

            Console.Write("Código do produto: ");
            int cod = Convert.ToInt32(Console.ReadLine());

            Produto excluir = produto.FirstOrDefault(x => x.id == cod);
            produto.Remove(excluir);

            Console.WriteLine("Produto excluído com sucesso!");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (op != 0);