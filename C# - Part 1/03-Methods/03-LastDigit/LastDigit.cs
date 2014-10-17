using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".


class LastDigit
{
    static int GetLastDigit(int number)
    {
        int lastDigit = number % 10;
        return lastDigit;
    }

    static string DigitAsWord(int digit)
    {
        string result = "";
        switch (digit)
        {
            case 1: result = "One"; break;
            case 2: result = "Two"; break;
            case 3: result = "Three"; break;
            case 4: result = "Four"; break;
            case 5: result = "Five"; break;
            case 6: result = "Six"; break;
            case 7: result = "Seven"; break;
            case 8: result = "Eight"; break;
            case 9: result = "Nine"; break;
            case 0: result = "Zero"; break;              
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(DigitAsWord(GetLastDigit(inputNumber)));
    }
}

