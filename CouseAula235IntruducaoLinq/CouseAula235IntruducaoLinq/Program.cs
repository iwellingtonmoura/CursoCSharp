using System;
using System.Linq;
using System.Collections.Generic;

namespace CouseAula235IntruducaoLinq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Specify the data source
            int[] numeros = new int[] { 2, 3, 4, 5 };

            //Define a expression query

            IEnumerable<int> result = numeros.Where(x => x % 2 == 0).Select(x => x * 10);


            //execute the query

            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
