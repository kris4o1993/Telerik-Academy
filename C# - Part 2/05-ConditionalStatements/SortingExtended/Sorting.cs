using System;

//Sort N real values in descending order using nested if statements.

class Sorting
{
    static void Main()
    {
        Console.Write("How many numbers you want to enter: ");
        int n = int.Parse(Console.ReadLine());
        double[] elements = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            elements[i] = double.Parse(Console.ReadLine());
        }
        Array.Sort(elements);
        Console.WriteLine("The numbers in ascending order are: " + String.Join("  ", elements));
    }
}

