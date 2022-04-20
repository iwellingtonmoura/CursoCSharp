using System;
using System.Globalization;

namespace CouseAula42Exercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           Produto produto = new Produto();

            Console.WriteLine("Entre com os dados dos produtos");
            Console.Write("Informe o nome produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Informe o Preço do Produto: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque do Produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Por favor informe a quantidade de produtos a ser adicionado no estoque: ");
            produto.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Por favor informe a quantidade de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);


        }
    }
}
