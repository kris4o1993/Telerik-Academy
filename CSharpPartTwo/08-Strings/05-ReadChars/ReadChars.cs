using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should 
//be filled with '*'. Print the result string into the console.

class ReadChars
{
    static void Main()
    {
        List<char> input = Console.ReadLine().ToList<char>();
        if (input.Count < 20)
        {
            int count = 20 - input.Count;
            for (int i = 0; i < count; i++)
            {
                input.Add('*');
            }
            Console.WriteLine(String.Join("", input));
        }

        else if (input.Count > 20)
        {
            Main();
        }

        
    }
}
