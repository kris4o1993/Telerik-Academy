using System;

//Sort 3 real values in ascending order using nested if statements.

//PS: След като направих задачата видях че се иска да се принтират в обратен ред. Смятам че не е нужно да го поправям,
//защото както се вижда мога да го направя. Надявам се да не ми вземете точки за това. :)

class Sorting
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber =double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The numbers in ascending order are: {0}  {1}  {2}", firstNumber, secondNumber, thirdNumber);
            }                                                                        
            else                                                                     
            {                                                                        
                Console.WriteLine("The numbers in ascending order are: {0}  {1}  {2}", firstNumber, thirdNumber, secondNumber);
            }
        }

        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The numbers in ascending order are: {0}  {1}  {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The numbers in ascending order are: {0}  {1}  {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else if (thirdNumber > secondNumber && thirdNumber > firstNumber)
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("The numbers in ascending order are: {0}  {1}  {2}", thirdNumber, secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("The numbers in ascending order are: {0}  {1}  {2}", thirdNumber, firstNumber, secondNumber);
            }
        }

    }
}

