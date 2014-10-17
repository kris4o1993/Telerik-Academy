using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

class Sort
{
    static void Main()
    {
        // Initialize a List of strings.
        List<string> sampleList = new List<string>
	{
	    "stegosaurus",
	    "piranha",
	    "leopard",
	    "cat",
	    "bear",
	    "hyena"
	};
        // Send the List to the method.
        foreach (string s in SortByLength(sampleList))
        {
            Console.WriteLine(s);
        }
    }

    static IEnumerable<string> SortByLength(IEnumerable<string> e)
    {
        // Use LINQ to sort the array received and return a copy.
        var sorted = from s in e
                     orderby s.Length ascending
                     select s;
        return sorted;
    }
}
