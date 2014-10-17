using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class Substring
{
    //static int Occurance(string text, string pattern)
    //{

    //}

    static void Main()
    {
        //string input = Console.ReadLine().ToLower();
        string input = @"We are living in an yellow submarine. We don't have anything else."+
        @"Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();


        Console.WriteLine(Regex.Matches(input, "in").Count);
    }
}

