namespace Task02_ShowOddElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a program that extracts from a given sequence of strings all elements that present in 
    /// it odd number of times. Example:
    /// {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    /// </summary>
    class Program
    {
        static void Main()
        {
            var input = "C# SQL PHP PHP SQL SQL";
            string[] elements = input.Split(' ');

            var occurences = new Dictionary<string, int>();

            foreach (var element in elements)
            {
                if(!occurences.ContainsKey(element))
                {
                    occurences.Add(element, 1);
                }
                else
                {
                    occurences[element]++;
                }
            }

            foreach (var item in occurences)
            {
                if (item.Value % 2 == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
