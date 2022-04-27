using System;
using System.IO;

namespace CouseAula197BlocoUsing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ver como acesar diretorio no Mac
            string path = @"c:\temp\file1.txt";

            try
            {
                //Instanciando a classe FileStream

                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}

                //Trabalhando de forma mais enxuta usando a classe File.

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }


            }
            catch (IOException ex)
            {
                Console.WriteLine("erro: " + ex.Message);
            }


        }
    }
}
