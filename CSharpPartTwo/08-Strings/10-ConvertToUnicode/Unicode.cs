using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

class Unicode
{
    static void Main()
    {
        char[] input = "Hello, my name is Arthas!".ToCharArray();
        foreach (char symbol in input)
            Console.WriteLine("\\u{0:X4}", (int)symbol);      
    }
}

