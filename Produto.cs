using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08._12._2025
{
    public class Produto
    {
        public string Nome { get; set; }
        public int QuantidadeInicial { get; set;}
        public int QuantidadeAtual { get; set;}
        public double Preco { get; set; }
        public int QuantidadeVendida { get; set;}

        public void Cadastrar()
        {
            Console.WriteLine("\nDigite o nome do produto");
            Nome = Console.ReadLine()!;

            Console.WriteLine("\nDigite o preço do produto");
            Preco = double.Parse(Console.ReadLine()!);

            Console.WriteLine("\nDigite a quantidade deste produto em estoque");
            QuantidadeAtual = int.Parse(Console.ReadLine()!);
            QuantidadeInicial = QuantidadeAtual;
        }

        public void Adicionar(string nome, int quantidade)
        {
            if (nome == Nome)
            {
                QuantidadeAtual += quantidade;
                Console.WriteLine("\nAdicionado com sucesso");
            }
        }

        public void Retirar(string nome, int quantidade)
        {
            if (nome == Nome)
            {
                QuantidadeVendida += quantidade;
                Console.WriteLine("\nRetirado com sucesso");
            }
        }

        public void ApresentarProduto()
        {
            QuantidadeAtual -= QuantidadeVendida;
            Console.WriteLine($"{Nome}\t\tR${Preco}\t\t{QuantidadeAtual}") ;
        }

        public double ValorTotal()
        {
            return (QuantidadeAtual - QuantidadeVendida) * Preco;
        }

        public void ResumoDia()
        {
            double quantidadeTotal = QuantidadeAtual - QuantidadeVendida;
            Console.WriteLine($"{Nome}\t|\tR${Preco}\t   |\t\t   {QuantidadeInicial}\t\t     |\t   {QuantidadeVendida}\t\t    |\t {quantidadeTotal}\t\t      |  \tR${QuantidadeVendida * Preco}");
        }
    }
}