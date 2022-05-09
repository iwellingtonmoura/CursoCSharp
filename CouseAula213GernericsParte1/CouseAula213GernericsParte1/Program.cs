using System;

namespace CouseAula213GernericsParte1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? :");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.Write("Add numbers ");
                int x = int.Parse(Console.ReadLine());

                printService.addValue(x);

            }

            printService.Print();

            Console.Write("Fist: " + printService.First());
            
        }
    }
}
 