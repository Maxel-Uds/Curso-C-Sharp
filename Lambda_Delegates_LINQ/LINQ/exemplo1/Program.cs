using System;
using System.Linq;
using System.Collections.Generic;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify data source
            int[] numbers = new int[] {2, 3 ,4 ,5};

            //Define the query expression
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execute query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
