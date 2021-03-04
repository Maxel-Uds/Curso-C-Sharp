using System;
using System.Collections.Generic;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marcos");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Tamanho da lista: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último nome com A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do primeiro nome com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do último nome com A: " + pos2);


        }
    }
}
