using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
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
                if (v[qt] == null) {
                v[qt] = new Pensionato(nome, email);
                }
                else {
                    Console.Write("Este quarto já está ocupado!");
                    i--;
                }
                Console.WriteLine();
            }

            foreach (Pensionato obj in v) {
                if (v[a] != null) {
                    Console.WriteLine("Quarto - " + a + ": " + v[a].Nome + ", " + v[a].Email);
                }
                a++;
            }
        }
    }
}
