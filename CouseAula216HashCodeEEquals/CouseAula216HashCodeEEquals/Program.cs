using System;

namespace CouseAula216HashCodeEEquals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string a = "Wellington";
            string b = "Pedro";

            Console.WriteLine("Hash Wellington " + a.GetHashCode());
            Console.WriteLine("Hash Pedro " + b.GetHashCode());
        }
    }
}
