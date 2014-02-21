using System;

//Write a program that reads two positive integer numbers and prints how many 
//numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
//Example: p(17,25) = 2.

class Remainder
{
    static void Main()
    {
        Console.Write("Enter the smaller number: ");
        int smaller = int.Parse(Console.ReadLine());
        Console.Write("Enter the larger number: ");
        int larger = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = smaller; i <= larger; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("There are {0} numbers between {1} and {2} \nthat are divisible without remainder by 5.", counter, smaller, larger);
    }
}
