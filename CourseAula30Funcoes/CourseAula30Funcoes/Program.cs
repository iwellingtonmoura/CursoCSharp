using System;

namespace CourseAula30Funcoes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe três números inteiros:");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            double resultado = MaiorNumero(number1, number2, number3);


            Console.WriteLine("O maior número dentre os três é: " + resultado);
        }

        static int MaiorNumero(int n1, int n2, int n3)
        {

            int maior;

            if(n1 > n2 && n1 > n3)
            {
                maior = n1;

            }else if(n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}
