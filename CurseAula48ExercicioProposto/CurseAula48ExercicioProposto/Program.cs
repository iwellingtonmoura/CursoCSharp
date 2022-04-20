using System;
using System.Globalization;

namespace CurseAula48ExercicioProposto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual a cotação do Dolar Hoje? ");
            double dolarHoje = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Quantos Dolares vai comprar Hoje? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Valor  ser pago em reais " + ConversorDeMoeda.CalculoDolar(dolarHoje, qtdDolar).ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
