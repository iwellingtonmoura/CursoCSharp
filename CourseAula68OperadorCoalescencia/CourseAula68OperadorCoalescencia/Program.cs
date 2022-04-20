using System;

namespace CourseAula68OperadorCoalescencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double? x  = null;
            double y = 10;


            double a = x ?? 5;
            //double b = y ?? 5.0;

            Console.WriteLine(a);
            Console.WriteLine(y);
        }
    }
}
