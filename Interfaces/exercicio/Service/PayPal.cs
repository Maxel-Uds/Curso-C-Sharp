namespace exercicio.Service
{
    public class PayPal : IServicePayment
    {

        public double Total(double amount, int months)
        {
            double upDateQuota = amount + Interest(amount, months);
            return upDateQuota + PaymentFee(upDateQuota);
        }
        public double Interest(double amount, int months)
        {
            return (amount * 0.01) * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}