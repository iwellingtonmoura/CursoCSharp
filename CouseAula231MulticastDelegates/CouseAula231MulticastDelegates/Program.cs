using System;
using CouseAula231MulticastDelegates.Services;

namespace CouseAula231MulticastDelegates
{
    delegate void BinaryNunericOpertiont(double n1, double n2);

    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = 10;
            double b = 12;


            BinaryNunericOpertiont op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);


          
        }
    }
}
