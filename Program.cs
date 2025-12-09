// Exercício rápido


using Aula_08._12._2025;

Classes classes = new Classes();


// Console.WriteLine("Digite algo");
// string algo = Console.ReadLine()!;
// classes.Cumprimentar(algo);


/////////////////////////////////////////////////// Exercício Mais Elaborado ///////////////////////////////////////////////////


List<Produto> list = new List<Produto>();

bool ativo = true;
double valorTotalVendido = 0;
Console.WriteLine("\nBom dia, bem vindo ao sistem LOJINHA");

while (ativo)
{
    Console.WriteLine("\nDigite o número da opção que deseja");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Adicionar estoque");
    Console.WriteLine("3 - Venda de estoque");
    Console.WriteLine("4 - Mostrar produtos");
    Console.WriteLine("5 - Resumo do dia");
    Console.WriteLine("6 - Sair");

    string opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Produto produto = new Produto();

            produto.Cadastrar();
            list.Add(produto);
            break;

        case "2":

            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhum produto foi cadastrado");
            }
            else
            {
                Console.Write("\nDigite o nome do produto que deseja adicionar: ");
                string escolha = Console.ReadLine()!;
                Console.Write($"\nDigite quantos produtos foram adicionados: ");
                int adicionar = int.Parse(Console.ReadLine()!);
                list.ForEach(p => p.Adicionar(escolha, adicionar));
            }
            break;

        case "3":

            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhum produto foi cadastrado");
            }
            else
            {
                Console.Write("\nDigite o nome do produto que foi vendido: ");
                string escolha2 = Console.ReadLine()!;
                Console.Write($"\nDigite quantos daquele produto foram vendidos: ");
                int vendidos = int.Parse(Console.ReadLine()!);
                list.ForEach(p => p.Retirar(escolha2, vendidos));
            }
            break;

        case "4":

            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhum produto foi cadastrado");
            }
            else
            {
                Console.WriteLine("\n\t\t Tabela dos Produtos");
                Console.WriteLine("Nome\t\tPreço\t\tQuantidade em estoque");
                list.ForEach(p => p.ApresentarProduto());
            }
            break;

        case "5":

            if (list.Count == 0)
            {
                Console.WriteLine("\nNenhum produto foi cadastrado");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\t Tabela dos Produtos\n---------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Nome\t\tPreço\t\tQuantidade no Início do Dia\tQuantidade Vendida\tQuantidade em Estoque\tValor total das vendas\n---------------------------------------------------------------------------------------------------------------------------------------");
                list.ForEach(p => p.ResumoDia());
                valorTotalVendido = list.Sum(p => p.ValorTotal());
                Console.WriteLine($"---------------------------------------------------------------------------------------------------------------------------------------\n");
                if (valorTotalVendido == 0)
                {
                    Console.WriteLine($"\nNão houve vendas\n");
                }
                else
                {
                    Console.WriteLine($"\nO valor total vendido é = R${valorTotalVendido}\n");
                }
            }
            break;

        case "6":

            if (list.Count == 0)
            {
                Console.WriteLine("\nOK...\n");
            }
            else
            {
                Console.WriteLine("\nDeseja verificar o resumo do dia antes de fechar o programa? (sim/não)");
                string escolha3 = Console.ReadLine()!;
                if (escolha3 == "sim")
                {
                    Console.WriteLine("\n\t\t\t\t\t Tabela dos Produtos\n---------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Nome\t\tPreço\t\tQuantidade no Início do Dia\tQuantidade Vendida\tQuantidade em Estoque\tValor total das vendas\n---------------------------------------------------------------------------------------------------------------------------------------");
                    list.ForEach(p => p.ResumoDia());
                    valorTotalVendido = list.Sum(p => p.ValorTotal());
                    Console.WriteLine($"---------------------------------------------------------------------------------------------------------------------------------------\n");
                    if (valorTotalVendido == 0)
                    {
                        Console.WriteLine($"\nNão houve vendas\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nO valor total vendido é = R${valorTotalVendido}\n");
                    }
                }
                Console.WriteLine("\nAté mais, esperamos que tenha gostado do nosso protótipo de programa para lojas.\n");
            }

            ativo = false;
            break;

        default:
            Console.WriteLine("\nOpção não existente\n");
            break;
    }
}
