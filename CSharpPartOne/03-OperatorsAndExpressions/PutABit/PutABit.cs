using System;

//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at 
//the position p from the binary representation of n.

class PutABit
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Which bit (starting from 0) you want to change? ");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.Write("What bit would you like to put in that position (0 or 1)?  ");
        int mask = int.Parse(Console.ReadLine());

        if (mask == 1)
        {
            mask = mask << bitPosition;
            number = number | mask;
            Console.WriteLine("Your new number is: " + number);
        }
        else
        {
            mask = 1;
            mask = mask << bitPosition;
            number = number ^ mask;
            Console.WriteLine("Your new number is: " + number);
        }   
    }
}
