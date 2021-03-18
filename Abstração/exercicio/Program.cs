using System;
using exercicio.Entities;
using System.Collections.Generic;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de pagadores: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> payer = new List<TaxPayer>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informações do pagador #{i}:");
                Console.Write("Pessoa física ou jurídica (f/j): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Ganho anual: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if(resp == 'f')
                {
                    Console.Write("Gastos médicos: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    payer.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Funcionários empregados: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payer.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXAS PAGAS:");
            double total = 0;
            foreach(TaxPayer obj in payer)
            {
                Console.WriteLine(obj.Name + ": $" + obj.Tax().ToString("F2"));
                total += obj.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL DE TAXAS: " + total.ToString("F2"));
        }
    }
}
