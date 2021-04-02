using System;
using exercicio2.Entities;
using System.Collections.Generic;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Studant> studant = new HashSet<Studant>();;

            Console.Write("Quantos estudantes matrículados no curso A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                studant.Add(new Studant(number));
            }

            Console.Write("Quantos estudantes matrículados no curso B? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                studant.Add(new Studant(number));
            }

            Console.Write("Quantos estudantes matrículados no curso C? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                studant.Add(new Studant(number));
            }


            Console.WriteLine("Total de estudantes: " + studant.Count);
        }
    }
}
