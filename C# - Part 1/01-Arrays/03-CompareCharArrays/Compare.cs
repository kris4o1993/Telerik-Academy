using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two char arrays lexicographically (letter by letter).


namespace _03_CompareCharArrays
{
    class Compare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first array: ");
            int firstArrayLength = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second array: ");
            int secondArrayLength = int.Parse(Console.ReadLine());

            if (firstArrayLength != secondArrayLength)
            {
                Console.WriteLine("The two arrays are different, because they have different amount of elements");
            }

            else if (firstArrayLength == secondArrayLength)
            {
                Console.WriteLine("Enter the first array members.");
                char[] firstArray = new char[firstArrayLength];
                for (int i = 0; i < firstArrayLength; i++)
                {
                    firstArray[i] = char.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter the second array members.");
                char[] secondArray = new char[secondArrayLength];
                for (int i = 0; i < secondArrayLength; i++)
                {
                    secondArray[i] = char.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArrayLength; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine("Elements on position {0} are equal to {1} in the both arrays.", i, firstArray[i]);
                    }

                    else if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("Elements on position {0} are different in the arrays. In the first it is equal to {1} and in the second it is equal to {2}.", i, firstArray[i], secondArray[i]);
                    }
                }
            }
        }
    }
}
