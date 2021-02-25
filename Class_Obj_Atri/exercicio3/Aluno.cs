namespace exercicio3
{
    public class Aluno
    {
        public double n1;
        public double n2;
        public double n3;

        public double Media() {
            return (n1 + n2 + n3);
        }

        public double Falta(double n) {
            return 60 - n;
        }
    }
}