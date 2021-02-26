namespace funcao
{
    public class Maior
    {
        public static int Teste(int n1, int n2, int n3) {
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