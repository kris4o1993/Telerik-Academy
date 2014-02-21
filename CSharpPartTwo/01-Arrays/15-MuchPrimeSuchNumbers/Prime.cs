using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class Prime
{
    static void Main(string[] args)
    {
        Console.Write("Show all prime numbers from 1 to ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        numbers.Add(2); //adding 2 in the list
        for (int i = 0; i < n - 2; i += 2) //so it can show numbers from 3 to N and excluding all even numbers
        {
            numbers.Add(i + 3);
        }

        int range = (int)(Math.Sqrt(n)); //check for divisors up to the square root of N

        //first removing numbers divisible by 3, 5, 7, 11
        numbers.RemoveAll(item => item % 3 == 0 && item != 3);
        numbers.RemoveAll(item => item % 5 == 0 && item != 5);
        numbers.RemoveAll(item => item % 7 == 0 && item != 7);
        numbers.RemoveAll(item => item % 11 == 0 && item != 11);

        //then checking the rest divisiors with the help of the range
        for (int i = 13; i < range; i += 2)
        {
            numbers.RemoveAll(item => item % i == 0);
        }

        //printing numbers
        Console.WriteLine("The prime numbers from 1 to N are: ");
        Console.WriteLine(String.Join(", ", numbers));
    }
}

