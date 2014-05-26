namespace Bank
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double InterestAmount(double months)
        {
            if (this.AccountUser is IndividualCustomer)
            {
                if (months > 3)
                {
                    months -= 3;
                    return base.InterestAmount(months);
                }

                //swag
                return 0;

            }
            else
            {
                if (months > 2)
                {
                    months -= 2;
                    return base.InterestAmount(months);
                }

                //swag
                return 0;
            }

        }
    }
}
