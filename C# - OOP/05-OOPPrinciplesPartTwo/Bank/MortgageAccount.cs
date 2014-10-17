namespace Bank
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double InterestAmount(double months)
        {
            if (this.AccountUser is IndividualCustomer)
            {
                if (months > 6)
                {
                    months -= 6;
                    return base.InterestAmount(months);
                }

                else
                {
                    return 0;
                }
            }

            else
            {
                if (months > 12)
                {
                    months -= 12;
                    double interestForFirstYear = (this.InterestRate / 2) * 12;
                    return interestForFirstYear + (months * this.InterestRate);
                }

                else
                {
                    this.InterestRate = this.InterestRate / 2;
                    return base.InterestAmount(months);
                }
            }
        }
    }
}
