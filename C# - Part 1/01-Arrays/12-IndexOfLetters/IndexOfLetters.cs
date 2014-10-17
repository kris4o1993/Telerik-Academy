using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

class Program
{
    static void Main()
    {
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        Console.Write("Enter word: ");
        string input = Console.ReadLine();
        input = input.ToUpper();
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (input[i] == letters[j])
                {
                    Console.WriteLine("The letter {0} has index {1}.", input[i], j);
                }
            }
        }
    }
}

