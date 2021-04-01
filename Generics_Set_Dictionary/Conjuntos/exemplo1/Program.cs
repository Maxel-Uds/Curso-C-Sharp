using System;
using System.Collections.Generic;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<string> set = new HashSet<string>();
            
            set.Add("Tv");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));
            foreach(string obj in set)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
