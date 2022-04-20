using System;
using System.Globalization;
namespace Course
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            int menorvalor = int.MinValue;
            int maiorvalor = int.MinValue;
            sbyte sn1 = sbyte.MinValue;
            sbyte sn2 = sbyte.MaxValue;
            double dnumber = 10.3578;
            string nome = "Wellington";
            int idade = 47;


            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(menorvalor);
            Console.WriteLine(maiorvalor);
            Console.WriteLine(sn1);
            Console.WriteLine(sn2);
            Console.WriteLine(dnumber.ToString("F2"));
            Console.WriteLine(dnumber.ToString("F4", CultureInfo.InvariantCulture));

            //PlaceHolders

            Console.WriteLine("{0} tem {1} anos de idade e tem o saldo de {2:F2}", nome, idade, dnumber);


            //Interpolação

            Console.WriteLine($"{nome} tem  {idade} de idade e tem o saldo de {dnumber:F2} ");
        }
    }
}
