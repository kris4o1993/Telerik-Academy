namespace Task04_LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a method that finds the longest subsequence of equal numbers in given 
    /// List<int> and returns the result as new List<int>. Write a program to test 
    /// whether the method works correctly.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var sequence = new List<int>()
            {
                2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 2, 2, 2, 2
            };

            int startIndex = 0;
            int maxRepetitions = 0;
            int currentRepetitions = 0;

            for (int i = 0, j = 0; i < sequence.Count; i += j)
            {
                currentRepetitions = 0;
                while (sequence[j] == sequence[i])
                {
                    j++;
                    currentRepetitions++;
                }

                if (currentRepetitions > maxRepetitions)
                {
                    maxRepetitions = currentRepetitions;
                    startIndex = i;
                }
            }

            var mostRepeatedElements = new List<int>();

            for (int i = 0; i < maxRepetitions; i++)
            {
                mostRepeatedElements.Add(sequence[startIndex]);
            }

            Console.WriteLine(string.Join(", ", mostRepeatedElements));
        }
    }
}
