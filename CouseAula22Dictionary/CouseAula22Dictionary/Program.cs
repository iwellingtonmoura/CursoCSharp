using System;
using System.Collections.Generic;

namespace CouseAula22Dictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99999999";

            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            
        }
    }
}
