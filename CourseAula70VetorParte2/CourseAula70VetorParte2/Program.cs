using System;
using System.Globalization;

namespace CourseAula70VetorParte2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Media de Preço é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
