using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas e colunas da matriz: ");
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]), n = int.Parse(vet[1]);

            int[,] mat = new int[m,n];

            Console.WriteLine();
            for (int i = 0; i < m; i++) {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(v[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite um termo da matriz: ");
            int termo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] == termo) {
                        Console.WriteLine("Posição: " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Elemento a esquerda: " + mat[i, (j-1)]);
                        }
                        if (j < (n - 1)) {
                            Console.WriteLine("Elemento a direita: " + mat[i, (j+1)]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Elemento a cima: " + mat[(i - 1), j]);
                        }
                        if (i < (m - 1)) {
                            Console.WriteLine("Elemento a baixo: " + mat[(i + 1), j]);
                        }
                        Console.WriteLine();
                    } 
                }
            }

        }
    }
}
