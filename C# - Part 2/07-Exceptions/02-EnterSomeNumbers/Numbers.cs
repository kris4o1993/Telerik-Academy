﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method ReadNumber(int start, int end) that enters an integer number in 
//given range [start…end]. If an invalid number or non-number text is entered, the 
//method should throw an exception. Using this method write a program that enters 10 numbers

class Numbers
{
    static int ReadNumber(int start, int end, int number)
    {
        int n = 1;
        Console.Write("Please enter number {0}: ", number);
        n = int.Parse(Console.ReadLine());
        if (n < start || n > end)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return n;
    }
    static void Main()
    {

        Console.WriteLine("This program reads 10 number in the interval (1..100)\n" +
            "each entered number should be greater than the previous.");
        int n = 1;
        try
        {
            for (int i = 1; i <= 10; i++)
            {
                n = ReadNumber(n, 100, i);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Not an integer number.");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Not in the scope of integer.");
        }
        catch (System.ArgumentNullException)
        {
            Console.WriteLine("Null is not an integer number.");
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("The entered number is not in range.");
        }
    }
}

