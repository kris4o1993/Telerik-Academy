using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print 
//"Good bye". Use try-catch-finally.

class IMeanSquareRoot
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        double result;
        try
        {
            uint number = uint.Parse(Console.ReadLine());
            result = Math.Sqrt(number);
            Console.WriteLine("SQRT({0}) = {1}", number, result);
        }

        catch (SystemException)
        {
            Console.WriteLine("Invalid number.");
        }

        finally
        {
            Console.WriteLine("Good bye!");
        }


    }
}
