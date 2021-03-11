using System;

namespace quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            while (resp == "s") {
            Console.WriteLine();
            Console.Write("Digite as coordenadas de (x,y) para descobrir o quandrante: ");
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]), y = double.Parse(vet[1]);
            Quadrante q = new Quadrante(x, y);
            Console.WriteLine(q);
            Console.Write("Quer consultar outra coordenada? (s/n) ");
            resp = Console.ReadLine();
            }
        }
    }
}
