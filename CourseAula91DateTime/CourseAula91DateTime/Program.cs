using System;
using System.Globalization;

namespace CourseAula91DateTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime data = DateTime.Now;

            DateTime d = new DateTime(2022, 04, 20, 16, 50, 45);

            DateTime diaAtual = new DateTime();

         
            


            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(diaAtual.DayOfYear);
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(diaAtual.ToLongDateString());
            Console.WriteLine(data.ToLongDateString());

        }
    }
}
