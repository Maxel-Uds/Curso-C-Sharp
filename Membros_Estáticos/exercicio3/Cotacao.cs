namespace exercicio3
{
    public class Cotacao
    {
        public static double Preco;
        public static double Qte;
        public static double Total;

        public static void TotalAPagar() {
            Total = (Preco * 1.06) * Qte;
        }
    }
}