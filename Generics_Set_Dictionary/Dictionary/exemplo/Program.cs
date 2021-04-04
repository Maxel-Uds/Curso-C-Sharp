using System;
using System.Collections.Generic;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if(cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Email não encontrado!");
            }

            Console.WriteLine("Tamanho: " + cookies.Count);

            foreach(KeyValuePair<string, string> obj in cookies)
            {
                Console.WriteLine(obj.Key + ": " + obj.Value);
            }
        }
    }
}
