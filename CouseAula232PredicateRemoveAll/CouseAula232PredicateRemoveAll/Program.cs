﻿using System;
using System.Collections.Generic;
using CouseAula232PredicateRemoveAll.Entities;

namespace CouseAula232PredicateRemoveAll
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

            list.RemoveAll(p => p.Price >= 100.00);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}
