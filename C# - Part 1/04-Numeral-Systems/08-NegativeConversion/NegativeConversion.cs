using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class NegativeConversion
{
    static void Main()
    {
        Console.Write("Enter short number: ");
        short input = short.Parse(Console.ReadLine());

        if (input < 0)
        {
            input = (short)(Math.Abs(input) - 1);
            string binary = "";
            while (input > 0)
            {
                binary += input % 2;
                input /= 2;
            }

            char[] binaryArray = binary.ToCharArray();
            Array.Reverse(binaryArray);
            string result = new string(binaryArray).PadLeft(16, '0');

            char[] binaryResult = result.ToCharArray();

            for (int i = 0; i < 16; i++)
            {
                if (binaryResult[i] == '0')
                {
                    binaryResult[i] = '1';
                }
                else
                {
                    binaryResult[i] = '0';
                }
            }

            Console.WriteLine(new string(binaryResult) + "(2)");
        }

        else
        {
            Console.Write(input + "(10) = ");
            string binary = "";
            while (input > 0)
            {
                binary += input % 2;
                input /= 2;
            }

            char[] binaryResult = binary.ToCharArray();
            Array.Reverse(binaryResult);
            string result = new string(binaryResult).PadLeft(16, '0') + "(2)";
            Console.WriteLine(result);
        }
    }
}

