using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            int a = 0;
            Console.Write("Digite quantos dados quer inserir: ");
            int n = int.Parse(Console.ReadLine());
            Double[] vet =  new double[n]; //Vetor
            for(int i = 1; i <= n;  i++) {
                Console.Write("Digite a altura #" + i + ": ");
                vet[a] = double.Parse(Console.ReadLine());
                S = S + vet[a];
                a = i;
            }
            Console.WriteLine((S/n).ToString("F2"));
        }
    }
}
