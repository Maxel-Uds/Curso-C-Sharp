namespace exemplo1.Entities
{
    public sealed class SavingsAccount : Account //Classe com herança e selada
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; 
        }

        public sealed override void WithDraw(double amount) //Método selado
        {
            base.WithDraw(amount); //Método chamado da superclasse para não precisar ser repetido.
            Balance -= 2.0;
        }
    }
}