namespace exercicio.Service
{
    public interface IServicePayment
    {
        public double Total(double amount, int months);
        public double Interest(double amount, int months);
        public double PaymentFee(double amount);
    }
}