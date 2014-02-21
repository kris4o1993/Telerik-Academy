using System;

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

class DigitCheck
{
    static void Main()
    {
        Console.Write("Enter your integer: ");
        int number = int.Parse(Console.ReadLine());
        number = Math.Abs(number);
        Console.Write("What digit (from right to left) would you like to check? ");
        int digitPosition = int.Parse(Console.ReadLine());
        int digit = 0;
        while (digitPosition>0)
        {
            digit = number % 10;
            number /= 10;
            digitPosition--;
        }
        Console.WriteLine("The digit on the selected position is: {0}", digit);
    }
}

