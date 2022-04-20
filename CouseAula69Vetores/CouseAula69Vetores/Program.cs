using System;
using System.Globalization;

namespace CouseAula69Vetores
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do seu vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o valor do valor na posição: " + i + " ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
