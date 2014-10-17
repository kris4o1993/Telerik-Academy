using System;
using System.Linq;
using System.Xml;

namespace ExtractSongTitlesWithXmlReader
{
    public class ExtractSongTitlesWithXmlReader
    {
        public static void Main()
        {
            using (XmlReader xmlReader = XmlReader.Create("../../catalog.xml"))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "title")
                    {
                        Console.WriteLine(xmlReader.ReadElementString());
                    }
                }
            }
        }
    }
}
