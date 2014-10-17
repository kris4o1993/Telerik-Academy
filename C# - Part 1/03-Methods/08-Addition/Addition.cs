using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

class Addition
{
    static string AddBigNumbers(char[] firstNumber, char[] secondNumber)
    {
        //creating 2 lists of our numbers
        List<char> bigArray = new List<char>();
        List<char> smallArray = new List<char>();

        //checking which one is bigger
        if (firstNumber.Length >= secondNumber.Length)
        {
            bigArray.AddRange(firstNumber);
            smallArray.AddRange(secondNumber);
        }

        else if (firstNumber.Length < secondNumber.Length)
        {
            bigArray.AddRange(secondNumber);
            smallArray.AddRange(firstNumber);
        }

        //reversing them in order to get a correct result
        bigArray.Reverse();
        smallArray.Reverse();

        //finding the length difference between the two numbers
        int difference = bigArray.Count - smallArray.Count;
        List<char> additionResult = new List<char>();
        byte carry = 0;
        int currentValue = 0;

        //adding untill we reach the length of the smaller number
        for (int i = 0; i < smallArray.Count; i++)
        {
            currentValue = (int)Char.GetNumericValue(bigArray[i]) + (int)Char.GetNumericValue(smallArray[i]) + carry;

            if (currentValue > 9)
            {
                currentValue = currentValue - 10;
                carry = 1;
                additionResult.Add((char)(currentValue + '0'));
            }

            else if (currentValue <= 9)
            {
                carry = 0;
                additionResult.Add((char)(currentValue + '0'));
            }
        }

        //checking if the numbers are equal and we have a carry left
        if (difference == 0 && carry == 1)
        {
            additionResult.Add('1');
            carry = 0;
        }

        //if one has greater length of the other we do this
        else if (difference > 0)
        {
            for (int i = smallArray.Count; i < bigArray.Count; i++)
            {
                currentValue = (int)Char.GetNumericValue(bigArray[i]) + carry;
                if (currentValue > 9)
                {
                    currentValue = currentValue - 10;
                    carry = 1;
                    additionResult.Add((char)(currentValue + '0'));
                }

                else if (currentValue <= 9)
                {
                    carry = 0;
                    additionResult.Add((char)(currentValue + '0'));
                }
            }

            //also adding the carry one more time in case of for example 9999 + 1 (without this it would show 0000)
            if (carry == 1)
            {
                additionResult.Add('1');
            }
        }

        //reversing in order to get the correct answer
        additionResult.Reverse();

        //returning answer
        return string.Join("", additionResult);
    }



    static void Main()
    {
        //input
        Console.Write("Enter first number: ");
        string firstNumber = Console.ReadLine();
        char[] firstNumArray = firstNumber.ToCharArray();

        Console.Write("Enter second number: ");
        string secondNumber = Console.ReadLine();
        char[] secondNumArray = secondNumber.ToCharArray();

        //print answer
        Console.WriteLine("Result = " + AddBigNumbers(firstNumArray, secondNumArray)); 
    }
}

