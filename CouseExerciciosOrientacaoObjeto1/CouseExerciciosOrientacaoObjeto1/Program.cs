using System;

namespace CouseExerciciosOrientacaoObjeto1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Pessoa pessoaA = new Pessoa();
            Pessoa pessoaB = new Pessoa();


            Console.WriteLine("Informe o nome completo da primeira Pessoa: ");
            pessoaA.Nome = Console.ReadLine();
            Console.WriteLine("Informe e idade: ");
            pessoaA.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o nome completo da segunda Pessoa: ");
            pessoaB.Nome = Console.ReadLine();
            Console.WriteLine("Informe e idade: ");
            pessoaB.Idade = int.Parse(Console.ReadLine());


            if (pessoaA.Idade > pessoaB.Idade)
            {

                Console.WriteLine("Pessoa mais velha é: " + pessoaA.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoaB.Nome);
            }



        }


    }
}
