using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++) {
                string[] v = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(v[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal principal:");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();
            int negativos = 0;
            foreach(int obj in mat) {
                if(obj < 0) {
                    negativos++;
                }
            }
            Console.WriteLine("O número de valores negativos é: "+ negativos);
        }
    }
}
