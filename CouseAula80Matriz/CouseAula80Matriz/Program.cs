using System;

namespace CouseAula80Matriz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o tamanho da Matriz: ");
            int qtd = int.Parse(Console.ReadLine());


            int[,] matriz = new int[qtd, qtd];

            for (int i = 0; i < qtd; i++)
            {
                string[] leitura = Console.ReadLine().Split(' ');

                for (int j = 0; j < qtd; j++)
                {
                    matriz[i, j] = int.Parse(leitura[j]);
                }

            }

            Console.WriteLine("Matriz Diagonal: ");
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }


            
            int soma = 0;

            for (int i = 0; i < qtd; i++)
            {
                for (int j = 0; j < qtd; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        soma++;
                    }
                }
            }
            Console.WriteLine("Quantidade de numeros negativos: " + soma);
        }
    }
}
