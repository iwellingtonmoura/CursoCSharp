using System;
using System.Globalization;

namespace ExercicioDeFixacaoParte2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu ultimo nome, idade e sua altura:");
            string[] texto = Console.ReadLine().Split(' ');

            string ultimoNome = texto[0];
            int idade = int.Parse(texto[1]);
            double altura = double.Parse(texto[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Nome Completo: " + nomeCompleto);
            Console.WriteLine("Quantidade de Quartos: " + qtdQuartos);
            Console.WriteLine("Preço do produto: " + preco.ToString("F2"), CultureInfo.InvariantCulture);


            Console.WriteLine("Ultimo Nome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
