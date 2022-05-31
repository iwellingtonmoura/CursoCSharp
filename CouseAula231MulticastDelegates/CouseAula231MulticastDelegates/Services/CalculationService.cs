using System;
namespace CouseAula231MulticastDelegates.Services
{
    public class CalculationService
    {

        public static void ShowMax(double x, double y)
        {
            double max =  (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double max = x + y;
            Console.WriteLine(max);
        }



    }
}
