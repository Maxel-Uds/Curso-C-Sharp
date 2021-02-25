using System;

namespace exercicio1
{
    public class Retangulo
    {
        public static double Area(double L, double A) {
            return L * A;
        }

        public static double Perimetro(double L, double A) {
            return (L + A) * 2;
        }

        public static double Diagonal(double L, double A) {
            return Math.Sqrt(Math.Pow(L,2) + Math.Pow(A,2));
        }
    }
}