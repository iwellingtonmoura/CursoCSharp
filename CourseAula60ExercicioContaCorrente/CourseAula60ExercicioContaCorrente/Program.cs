using System;
using System.Globalization;

namespace CourseAula60ExercicioContaCorrente
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Conta conta;

            Console.Write("Entre com o número da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Haverá depósito inicial? s/n: ");
            char resp = char.Parse(Console.ReadLine());
          
            if(resp == 'S' || resp == 's')
            {
                Console.Write("Entre com o valor de depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                conta = new Conta(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);


            Console.Write("Entre com um valor para Depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados...");
            Console.WriteLine(conta.ToString());


            Console.Write("Entre com um valor para Saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados...");
            Console.WriteLine(conta.ToString());


        }
    }
}
