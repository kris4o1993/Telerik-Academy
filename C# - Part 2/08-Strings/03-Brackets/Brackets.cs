using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


class Brackets
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        int bracket = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                bracket++;
            }

            else if (input[i] == ')')
            {
                bracket--;
            }

            if (bracket < 0)
            {
                break;
            }
        }

        if (bracket <0 || bracket > 0)
        {
            Console.WriteLine("Incorrect expression.");
        }
        else
        {
            Console.WriteLine("Correct expression.");
        }
    }
}

