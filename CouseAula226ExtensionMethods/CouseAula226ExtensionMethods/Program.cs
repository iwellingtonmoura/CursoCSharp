using System;
using CouseAula226ExtensionMethods.Extensions;

namespace CouseAula226ExtensionMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime data = new DateTime(2018, 11, 10, 18, 45, 35);

            Console.WriteLine(data.ElapsedTime());
        }
    }
}
