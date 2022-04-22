using System;
using System.Globalization;
using System.Collections.Generic;
using CouseAula141ExercicioResolvido.Entities;

namespace CouseAula141ExercicioResolvido
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsorced  (y/n): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                if(ch == 'y')
                {
                    Console.Write("Enter with addicional Charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, addicionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " -  $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
