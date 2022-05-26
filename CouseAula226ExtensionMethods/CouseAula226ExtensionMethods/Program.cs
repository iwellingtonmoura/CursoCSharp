using System;

namespace CouseAula226ExtensionMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime data = new DateTime(2018, 11, 10, 18, 45, 35);

            Console.WriteLine(data.ElapsedTime());


            string s1 = "Sejam Muito bem vindos ao Curso de C";

            Console.WriteLine(s1.cut(10));

         }
    }
}
