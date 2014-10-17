using System;

//Write a program that reads from the console a sequence of N integer 
//numbers and returns the minimal and maximal of them.

class Numbers
{
    static void Main()
    {
        //input length of the sequence
        Console.Write("How many numbers will you enter? ");
        int n = int.Parse(Console.ReadLine());

        //put numbers in an array
        int[] bunchOfNumbers = new int[n];
        int length = bunchOfNumbers.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter number: ");
            bunchOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        //sorting the array and getting the minimal and the maximal value
        Array.Sort(bunchOfNumbers);
        Console.WriteLine("The minimal number is: " + bunchOfNumbers[0]);
        Console.WriteLine("The maximal number is: " + bunchOfNumbers[length-1]);
    }
}

