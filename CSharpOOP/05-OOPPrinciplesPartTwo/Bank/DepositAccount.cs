namespace Bank
{
    using System;
    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Withdraw(decimal money)
        {
            if (this.Balance - money < 0)
            {
                throw new IndexOutOfRangeException("NOT ENOUGH GOLD!");
            }

            this.Balance -= money;
        }

        public override double InterestAmount(double months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.InterestAmount(months);
            }
        }
    }
}
