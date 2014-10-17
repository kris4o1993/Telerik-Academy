using System;

//Write a boolean expression that checks for given integer if it can be 
//divided (without remainder) by 7 and 5 in the same time.

class Division
{
    static void Main()
    {
        Console.Write("Please enter your integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivisible = false;
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            isDivisible = true;
        }
        Console.WriteLine("The number {0} is divisible by 5 and 7 at the same time: {1}", number, isDivisible);
    }
}

