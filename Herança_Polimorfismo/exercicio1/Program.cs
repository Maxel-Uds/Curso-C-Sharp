using System;
using System.Collections.Generic;
using exercicio1.Entities;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de empregados: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employee = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}:");
                Console.Write("Terceirizado (s/n)? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if(resp == 's')
                {
                    Console.Write("Adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge)); //polimorfismo/upcasting de lista
                }
                else
                {
                    employee.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS:");
            foreach(Employee obj in employee)
            {
                Console.WriteLine(obj.Name + " - $" + obj.Payment().ToString("F2"));
            }
        }
    }
}
