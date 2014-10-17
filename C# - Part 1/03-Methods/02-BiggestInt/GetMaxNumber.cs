using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that 
//reads 3 integers from the console and prints the biggest of them using the method GetMax().

class GetMaxNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int biggest = firstNumber;
        if (secondNumber > firstNumber)
        {
            biggest = secondNumber;
        }
        return biggest;
    }

    static void Main()
    {
        Console.WriteLine("Enter the three integers: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int big;

        big = GetMax(n1, n2);
        big = GetMax(big, n3);
        Console.WriteLine("The bigest of dem all is " + big);
        

    }
}

