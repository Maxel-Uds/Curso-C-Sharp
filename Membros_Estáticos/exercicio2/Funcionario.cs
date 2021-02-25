namespace exercicio2
{
    public class Funcionario
    {
        public static string Nome;
        public static double SalarioBruto;
        public static double Imposto;
        public static double SalarioLiqui;
        public static void SalarioLiquido() {
            SalarioLiqui = SalarioBruto - Imposto;
        }

        public static void AumentarSalario(double p) {
            SalarioLiqui = SalarioLiqui * (1 + (p/100));
        }

    }
}