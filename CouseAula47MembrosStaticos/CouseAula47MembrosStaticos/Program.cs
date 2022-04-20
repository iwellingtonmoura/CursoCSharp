using System;
using System.Globalization;

namespace CouseAula47MembrosStaticos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //chamada de membros staticos da classe não é necessário instacia a classe para ter acesso

            double circ = Calculadora.Circurferencia(raio);
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circurferencia " + circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume "+ volume.ToString("F2"),CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de Pi " + Calculadora.Pi.ToString("F2"),CultureInfo.InvariantCulture);

        }
    }
}
