using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

class Reverse
{
    static void InputDecimal(char[] input)
    {
        Array.Reverse(input);
        Console.WriteLine(input);
    }

    static void Main()
    {
        InputDecimal(Console.ReadLine().ToCharArray());
    }
}

