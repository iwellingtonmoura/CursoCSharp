using System;
namespace CurseAula48ExercicioProposto
{
    public class ConversorDeMoeda
    {

        public static double IOF = 6.0;

        public static double CalculoDolar(double cotacaoDolar, double QuantidadeEmReais)
        {

            double calculo = (QuantidadeEmReais * cotacaoDolar);

           return calculo + calculo * IOF / 100;

        }

    }
}
