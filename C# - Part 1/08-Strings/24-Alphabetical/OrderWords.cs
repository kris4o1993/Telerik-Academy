using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class OrderWords
{
    static void Main()
    {
        string list = "Cow Horse Cat Pig Dog Mamal Fish Plant Zombie Doge";
        string[] words = list.Split(' ');
        Array.Sort(words);
        Console.WriteLine(String.Join(" ", words));
    }
}

