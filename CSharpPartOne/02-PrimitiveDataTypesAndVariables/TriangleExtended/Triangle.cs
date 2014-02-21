using System;
using System.Linq;

//Write a program that prints an isosceles triangle of copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

class Triangle
{
    static void Main()
    {
        Console.Write("Enter number of rows and columns: ");
        int rows = int.Parse(Console.ReadLine());
        for (int cols = 1; cols <= rows; cols++)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat("©", cols)));
        }
    }
}