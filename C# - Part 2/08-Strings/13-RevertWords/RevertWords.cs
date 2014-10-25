using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in given sentence.

class RevertWords
{
    static void Main()
    {
        string input = "Hello motherfucking fucker :D";
        string[] temp = input.Split(' ');
        Array.Reverse(temp);
        Console.WriteLine(String.Join(" ", temp));

        
    }
}
