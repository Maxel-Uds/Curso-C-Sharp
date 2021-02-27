using System;
using System.Globalization;

namespace baskara
{
    public class Baskara
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double Delta { get; private set; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }

        public Baskara(double a, double b, double c) {
            A = a;
            B = b;
            C = c;
        }

        public void CalcDeltaRaiz() {
            if (A != 0) {
            Delta = Math.Pow(B,2) - (4 * A * C);
            }
            if (Delta >= 0 && A != 0) {
                X1 = (-B + Math.Sqrt(Delta))/(2 * A);
                X2 = (-B - Math.Sqrt(Delta))/(2 * A);
            }
        }

        public override string ToString()
        {
            if (A == 0) {
                return "A equação digitada não é do segundo grau";
            }
            else if (Delta == 0) {
                return "A equação tem delta igual a " + Delta + " e duas raízes iguais a " + X1.ToString("F2", CultureInfo.InvariantCulture);
            }
            else if (Delta > 0) {
                return "A equação tem delta igual a " + Delta + " e duas raízes distintas com X1 igual a " + X1.ToString("F2", CultureInfo.InvariantCulture) + " e X2 igual a " + X2.ToString("F2", CultureInfo.InvariantCulture);
            }
            else {
                return "A equação possui delta negativo igual a " + Delta + " e não possui raízes no conjunto dos reais.";
            }
        }
    }
}