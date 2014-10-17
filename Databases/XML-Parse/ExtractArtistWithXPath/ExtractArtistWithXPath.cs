using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ExtractArtistWithXPath
{
    public class ExtractArtistWithXPath
    {
        public static void Main()
        {
            Dictionary<string, int> artists = new Dictionary<string, int>();

            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            string xPathQuery = "catalog/album";
            XmlNodeList albums = doc.SelectNodes(xPathQuery);

            foreach (XmlNode album in albums)
            {
                string artist = album["artist"].InnerText;

                if (!artists.ContainsKey(artist))
                {
                    artists.Add(artist, 1);
                }
                else
                {
                    artists[artist]++;
                }
            }

            foreach (KeyValuePair<string, int> artist in artists)
            {
                Console.WriteLine("Artist: {0} --> {1} times", artist.Key, artist.Value);
            }
        }
    }
}
