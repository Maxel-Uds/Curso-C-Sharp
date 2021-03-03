using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
            Pensionato[] v = new Pensionato[10];
            Console.WriteLine();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int qt = int.Parse(Console.ReadLine());
                v[qt] = new Pensionato(nome, email);
                Console.WriteLine();
            }

            for (int i = 0; i <= v.Length; i++) {
                if (v[i] != null) {
                    Console.WriteLine("Quarto - " + i + ": " + v[i].Nome + ", " + v[i].Email);
                }
            }
        }
    }
}
