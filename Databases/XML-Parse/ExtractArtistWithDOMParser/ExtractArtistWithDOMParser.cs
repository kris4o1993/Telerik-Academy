using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ExtractArtistWithDOMParser
{
    public class ExtractArtistWithDOMParser
    {
        public static void Main()
        {
            Dictionary<string, int> artists = new Dictionary<string, int>();

            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlNode catalog = doc.DocumentElement;

            foreach (XmlNode album in catalog.ChildNodes)
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
