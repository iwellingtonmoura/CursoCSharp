using System;

namespace CouseAula75Foreach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] vect = new string[] { "Wellington", "Jose", "Moura" };

            foreach(string conteudo in vect)
            {
                Console.WriteLine(conteudo);
            }

            
        }
    }
}
