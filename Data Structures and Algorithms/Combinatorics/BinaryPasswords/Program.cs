namespace BinaryPasswords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly List<char[]> passwords = new List<char[]>();

        public static void Main()
        {
            char[] pattern = Console.ReadLine().ToCharArray();

            // BGCoder variant:
            //int starsCount = pattern.Where(x => x == '*').Count();
            //Console.WriteLine((long)Math.Pow(2, starsCount));

            // Recursive variant
            GeneratePasswords(pattern, 0);
            Console.WriteLine(passwords.Count);

            foreach (char[] password in passwords)
            {
                Console.WriteLine(string.Join("", password));
            }
        }

        private static void GeneratePasswords(char[] pattern, int index)
        {
            if (index == pattern.Length)
            {
                passwords.Add(pattern.ToArray());
                return;
            }

            if (pattern[index] == '*')
            {
                for (int i = 0; i <= 1; i++)
                {
                    pattern[index] = Convert.ToChar(i.ToString());
                    GeneratePasswords(pattern, index + 1);
                    pattern[index] = '*';
                }
            }
            else
            {
                GeneratePasswords(pattern, index + 1);
            }
        }
    }
}
