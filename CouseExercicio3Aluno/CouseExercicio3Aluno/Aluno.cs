using System;
namespace CouseExercicio3Aluno
{
    public class Aluno
    {

        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiraTrimestre;


        public double ResultadoAnual()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiraTrimestre;
        }


    }
}
