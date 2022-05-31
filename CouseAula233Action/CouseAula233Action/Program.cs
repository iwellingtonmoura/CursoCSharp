﻿using System;
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

            //Aumentando o preço 10%
            list.ForEach(p => p.Price += p.Price * 0.1);

            //foreach do list espera argumento do tipo action

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
