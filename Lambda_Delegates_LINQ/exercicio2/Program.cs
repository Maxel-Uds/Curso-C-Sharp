using System;
using System.IO;
using System.Linq;
using exercicio2.Entites;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho até o arquivo: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Entre com um valor de salário: ");
            double slry = double.Parse(Console.ReadLine());

            var emails = list.Where(p => p.Salary > slry).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine($"Email das pessoas com salário maio que {slry}:");
            foreach(string item in emails)
            {
                Console.WriteLine(item);
            }

            var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine("Soma do salário das pessoas que começam com M: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
