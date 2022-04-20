using System;

namespace CouseAula27EstruturaCondicionalIfElse
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Digite um numero inteiro:");

            //int x = int.Parse(Console.ReadLine());

            //if((x % 2) == 0)
            //{
            //    Console.WriteLine("O número informado é par.");
            //}else
            //{
            //    Console.WriteLine("O número informado é impar.");

            //}


            Console.WriteLine("Digite uma hora valor inteiro");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            
        }
    }
}
