using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03_WordOccurencesInText
{
    /// <summary>
    /// Write a program that counts how many times each word from given text file words.txt appears in it. 
    /// The character casing differences should be ignored. The result words should be ordered by their number 
    /// of occurrences in the text. Example: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
    /// is -> 2
    /// the -> 2
    /// this -> 3
    /// text -> 6
    /// </summary>
    class Program
    {
        static void Main()
        {
            var occurences = new Dictionary<string, int>();
            var reader = new StreamReader("text.txt", Encoding.UTF8);

            using (reader)
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    string regexPattern = @"[^\p{L}]*\p{Z}[^\p{L}]*";
                    var currentLineWords = Regex.Split(line, regexPattern);
                    
                    foreach (var word in currentLineWords)
                    {
                        if (!occurences.ContainsKey(word.ToLower()))
                        {
                            occurences.Add(word.ToLower(), 1);
                        }
                        else
                        {
                            occurences[word.ToLower()]++;
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            var sortedValues = occurences.OrderBy(kvp => kvp.Value);

            foreach (var item in sortedValues)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
