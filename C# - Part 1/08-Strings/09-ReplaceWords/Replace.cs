using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. 

class Replace
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today." +
            "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string pattern = @"PHP|CLR|Microsoft";

        Console.WriteLine(Regex.Replace(input, pattern.Replace(", ", "|"), m => new String('*', m.Length)));

    }
}
