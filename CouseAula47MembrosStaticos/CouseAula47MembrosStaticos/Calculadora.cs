using System;
namespace CouseAula47MembrosStaticos
{
    public class Calculadora
    {

        public static double Pi = 3.14;

        public static double Circurferencia(double r)
        {
            return 2 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4 / 3 * Pi * r * r * r;
        }
    }
}
