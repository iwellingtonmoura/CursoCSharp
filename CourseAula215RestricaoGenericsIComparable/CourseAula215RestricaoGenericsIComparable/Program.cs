using System;
using System.Globalization;
using System.Collections.Generic;
using CourseAula215RestricaoGenericsIComparable.Entities;
namespace CourseAula215RestricaoGenericsIComparable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Informe a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');

                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);
            Console.Write("Max: ");
            Console.WriteLine(max);
        }
    }
}
