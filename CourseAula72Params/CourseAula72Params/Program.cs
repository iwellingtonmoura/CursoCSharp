using System;

namespace CourseAula72Params
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 5, 7, 9, 10);
            int s2 = Calculator.Sum(3, 4, 7);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
