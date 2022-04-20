using System;
using System.Globalization;

namespace CouseAula39TrianguloOrientadoObjetoDelegate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();


            Console.WriteLine("Informa os valores do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Informa os valores do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Area do Triangulo X é: " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area do Triangulo Y é: " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {

                Console.WriteLine("Maior area é de X");
            }
            else
            {

                Console.WriteLine("Maior area é de Y");
            }
        }
    }
}
