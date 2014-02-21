using System;

//Write a boolean expression that returns if the bit at position p (counting from 0) 
//in a given integer number v has value of 1. Example: v=5; p=1  false.

class BitValue
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Which bit (starting from 0) you want to check? ");
        int bitPosition = int.Parse(Console.ReadLine());

        int mask = 1;
        mask = mask << bitPosition;
        mask = number & mask;
        mask = mask >> bitPosition;
        if (mask == 1)
        {
            Console.WriteLine("The bit at position {0} is {1}.", bitPosition, mask);
        }
        else
        {
            Console.WriteLine("The bit at position {0} is {1}.", bitPosition, mask);
        }
    }
}

