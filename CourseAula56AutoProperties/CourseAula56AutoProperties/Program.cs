using System;

namespace CourseAula56AutoProperties
{
    class MainClass
    {
        public static void Main(string[] args)
        {



            Produto produto = new Produto("TV 4K", 500.00, 10);

            produto.Nome = "T";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Quantidade);
            Console.WriteLine(produto.Preco);


        }
    }
}
