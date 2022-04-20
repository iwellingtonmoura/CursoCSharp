using System;
using System.Globalization;

namespace CouseExercicio3Aluno
{
    class MainClass
    {
       const double minimoAprovacao = 60.00;

        public static void Main(string[] args)
        {


            double notaFinal = 0.0;
            

            Aluno aluno = new Aluno();

            Console.Write("Por favor informe o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Por favor informe a nota do Primeiro Trimestre: ");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            Console.Write("Por favor informe a nota do Segundo Trimestre: ");
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            Console.Write("Por favor informe a nota do Terceiro Trimestre: ");
            aluno.NotaTerceiraTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            notaFinal = aluno.ResultadoAnual();


            if( notaFinal >= minimoAprovacao)
            {
                Console.WriteLine("NOTA FINAL: " + notaFinal.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + notaFinal.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (minimoAprovacao - notaFinal).ToString("F2"), CultureInfo.InvariantCulture + " PONTOS");
            }

        
        }
    }
}
