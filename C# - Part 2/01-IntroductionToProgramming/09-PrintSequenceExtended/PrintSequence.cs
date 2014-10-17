using System;

//Write a program that prints the first N members of a sequence. Example: 2, -3, 4, -5, 6, -7, ...
//This is an extended version of task 9.

class PrintSequence
{
    static void Main()
    {
        //data input
        Console.Write("What is your first number in the sequence: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("How many members does the sequence have: ");
        int members = int.Parse(Console.ReadLine());
        int counter = 0;

        //printing sequence
        for (int i = startNumber; i < startNumber + members; i++)
        {
            if (counter % 2 == 1)
            {
                Console.WriteLine(-i);
            }
            else
            {
                Console.WriteLine(i);
            }
            counter++;
        }
    }
}
