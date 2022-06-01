using System;
using System.Linq;
using System.Collections.Generic;
using CouseAula233Action.Entities;

namespace CouseAula233Action
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Utilizando delegate com referencia ao método NameUpper
           // Func<Product, string> func = NameUpper;

            //Utilizando expressão lambda
            Func<Product, string> func = p => p.Name.ToUpper();

            //Aumentando o preço 10%
            list.ForEach(p => p.Price += p.Price * 0.1);

            //foreach do list espera argumento do tipo action



            //Implementação do Linq

           // List<string> result = list.Select(NameUpper).ToList();

            //usando um delegate func referenciando o método NameUpper
            List<string> result = list.Select(func).ToList();


            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }


            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
