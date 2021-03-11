using System;

namespace quadrante
{
    public class Quadrante
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public Quadrante(double x, double y) {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            if (X > 0 && Y > 0) {
                return "A coordenada está no primeiro quadrante";
            }
            else if (X < 0 && Y > 0) {
                return "A coordenada está no segundo quadrante";
            }
            else if (X < 0 && Y < 0) {
                return "A coordenada está no terceiro quadrante";
            }
            else if (X > 0 && Y < 0) {
                return "A coordenada está no quarto quadrante";
            }
            else if (X == 0 && Y != 0) {
                return "A coordenada está sobre o eixo y";
            }
            else if (X != 0 && Y == 0) {
                return "A coordenada está sobre o eixo x";
            }
            else {
                return "A coordenada está na origem do plano cartesiano";
            }
        }
    }
}