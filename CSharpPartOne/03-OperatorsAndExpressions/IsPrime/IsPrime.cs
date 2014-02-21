using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

class IsPrime
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        double sqrtNumber = Math.Sqrt((double)number);
        bool isPrime = true;
        for (int i = 2; i < sqrtNumber; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine("{0} is Prime - {1}", number, isPrime);
    }
}

