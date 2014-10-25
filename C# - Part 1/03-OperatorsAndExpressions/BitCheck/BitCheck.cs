using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class BitCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 2;
        mask = mask & number;
        mask = mask >> 2;
        Console.WriteLine("The third bit is " + mask);
    }
}

