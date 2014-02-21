using System;

//Write a boolean expression that checks for given integer if it can be 
//divided (without remainder) by 7 and 5 in the same time.

//The task is expanded by giving the user an option to choose not only 
//the integer, but the number and the value of the dividers too.

class DivisionWithoutRemainder
{
    static void Main()
    {
        //input the number and the count of the dividers
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the count of the dividers: ");
        int dividersCount = int.Parse(Console.ReadLine());
        int[] arrayOfDividers = new int[dividersCount];
        int length = arrayOfDividers.Length;

        //enter all dividers one by one
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter divider value: ");
            arrayOfDividers[i] = int.Parse(Console.ReadLine());
        }

        //checking if the integer can be divided without remainder on all inputed numbers
        bool isDivisible = true;
        for (int i = 0; i < length; i++)
        {
            if (number % arrayOfDividers[i] > 0)
            {
                isDivisible = false;
                break;
            }
        }
        Console.WriteLine("{0} is divisible without remainder on the numbers {1} - {2}", number, string.Join(" ", arrayOfDividers), isDivisible );
        
    }
}

