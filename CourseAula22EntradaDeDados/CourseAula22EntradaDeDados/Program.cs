using System;

namespace CourseAula22EntradaDeDados
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase.");

            string[] palavras = Console.ReadLine().Split(' ');

            string primeiraPalavra = palavras[0];
            string segundaPalavra = palavras[1];
            string terceiraPalavra = palavras[2];



            Console.WriteLine( "Primeira Palavra: " + primeiraPalavra);
            Console.WriteLine("Segunda Palavra: " + segundaPalavra);
            Console.WriteLine("Terceira Palavra: " + terceiraPalavra);
        }
    }
}
