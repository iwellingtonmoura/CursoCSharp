using System;
using System.IO;

namespace CouseAula198StreamWriter
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                //Vetor de String para receber todas as linhas do arquivo
                string[] lines = File.ReadAllLines(sourcePath);

                //Utilizando o StreamWriter e a classe File para instanciar diretamente o destino do arquivo
                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach( string line in lines)
                    {
                        //Utilizando do método WriteLine pra imprimir as linhas do arquivo
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
