namespace Bank
{
    public abstract class Account
    {
        public Account(Customer accountUser, decimal balance, double interestRate)
        {
            this.AccountUser = accountUser;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer AccountUser { get; private set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public virtual void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public virtual double InterestAmount(double months)
        {
            return this.InterestRate * months;
        }
    }
}
