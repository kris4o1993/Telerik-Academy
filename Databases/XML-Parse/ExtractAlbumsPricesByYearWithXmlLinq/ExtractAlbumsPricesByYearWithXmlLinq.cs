using System;
using System.Linq;
using System.Xml.Linq;

namespace ExtractAlbumsPricesByYearWithXmlLinq
{
    public class ExtractAlbumsPricesByYearWithXmlLinq
    {
        public static void Main()
        {
            XDocument doc = XDocument.Load("../../catalog.xml");

            int fiveYearAgo = DateTime.Now.Year - 5;

            var albums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) <= fiveYearAgo
                select album;

            foreach (XElement album in albums)
            {
                string albumName = album.Element("name").Value;
                string price = album.Element("price").Value;
                Console.WriteLine("Album: {0}; Price {1}", albumName, price);
            }
        }
    }
}
