using System;

namespace funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            int resultado = Maior(a, b, c); 
            Console.WriteLine("O maior número é igual a "+ resultado);
        }

        static int Maior(int n1, int n2, int n3) {
            int m;
            if (n1 > n2 && n1 > n3) {
                m = n1;
            }
            else if (n2 > n3) {
                m = n2;
            }
            else {
                m = n3;
            }
            return m;
        }
    }
}
