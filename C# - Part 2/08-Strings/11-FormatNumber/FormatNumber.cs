using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

class FormatNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15:F2}", input);
        Console.WriteLine("{0,15:X}", input);
        Console.WriteLine("{0,15:P}", input);
        Console.WriteLine("{0,15:E}", input);
    }
}
