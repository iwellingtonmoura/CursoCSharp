using System;
using CouseAula129Parte2.Entities;
using CouseAula129Parte2.Entities.Enums;
using System.Globalization;


namespace CouseAula129Parte2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write(" Enter Departament's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine(" Enter Worker Data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instancio a Classe Departamento informando nome informado na leitura
            Departament dept = new Departament(deptName);

            //Instancio a Classe Trabalhador informando os dados dele informado
            Worker worker = new Worker(name, level, baseSalary, dept);

            //Quantos Contratos o trabalhador tem???
            Console.Write("How many contracts to this worker?: ");
            int nContracts = int.Parse(Console.ReadLine());


            for (int i = 0; i < nContracts; i++)
            {
                //Lê os dados de cada contrato

                Console.WriteLine($"Enter with information #{i} Contract data:  ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valorPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hour): ");
                int durationHour = int.Parse(Console.ReadLine());

                //Instancio a classe contratos com os dados do contrato informado
                HourContract contract = new HourContract(data, valorPerHour, durationHour);

                //Adiciono o Contrato ao trabalhador
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.WriteLine("Enter with moth and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse( monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine();
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine();
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InstalledUICulture));

            
        }
    } 
}
