using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…[/URL]. 

class Program
{
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        Console.WriteLine(Regex.Replace(html, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
    }
}

