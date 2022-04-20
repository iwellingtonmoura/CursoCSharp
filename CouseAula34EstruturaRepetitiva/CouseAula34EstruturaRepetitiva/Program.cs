using System;

namespace CouseAula34EstruturaRepetitiva
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor informa quantos números serão digitados:");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
               
            }

            Console.WriteLine("A soma dos valores informado é: " + soma);
        }
    }
}
