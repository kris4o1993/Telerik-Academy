using System;
using System.Linq;
using System.Xml.Linq;

namespace ExtractSongTitlesWithXmlLinq
{
    public class ExtractSongTitlesWithXmlLinq
    {
        public static void Main()
        {
            XDocument doc = XDocument.Load("../../catalog.xml");

            var songsTitles =
                from s in doc.Descendants("song")
                select s.Element("title").Value;

            foreach (string title in songsTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
