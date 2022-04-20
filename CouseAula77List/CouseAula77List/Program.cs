using System;
using System.Collections.Generic;

namespace CouseAula77List
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<string> list = new List<string>();

            //Adicionando elementos a lista

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("Quantidade de item da lista " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome da lista que incia com a letra A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome da lista que incia com a letra A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao da lista onde encontra a primeiro nome com a letra A " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao da lista onde encontra a ultimo nome com a letra A " + pos2);

            Console.WriteLine("-------------------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }


            list.Remove("Alex");
            Console.WriteLine("-------------------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("-------------------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(1, 1);
            Console.WriteLine("-------------------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
