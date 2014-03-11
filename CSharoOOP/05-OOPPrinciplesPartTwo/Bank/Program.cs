namespace Bank
{
    using System;
    class Program
    {
        static void Main()
        {
            //do some test when you check my homework, but i assure you that it works!!!
            MortgageAccount account = new MortgageAccount
            (new IndividualCustomer("Kris", "23"), 4000, 0.02);

            Console.WriteLine(account.InterestAmount(15));
        }
    }
}
