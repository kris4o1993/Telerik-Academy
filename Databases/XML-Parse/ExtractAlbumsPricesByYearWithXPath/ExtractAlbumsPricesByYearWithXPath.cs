using System;
using System.Xml;

namespace ExtractAlbumsPricesByYearWithXPath
{
    public class ExtractAlbumsPricesByYearWithXPath
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            string fiveYearAgo = (DateTime.Now.Year - 5).ToString();
            string xPathQuery = "/catalog/album[year<=" + fiveYearAgo + "]";
            XmlNodeList albums = doc.SelectNodes(xPathQuery);

            foreach (XmlNode album in albums)
            {
                string albumName = album.SelectSingleNode("name").InnerText;
                string price = album.SelectSingleNode("price").InnerText;
                Console.WriteLine("Album: {0}; Price {1}", albumName, price);
            }
        }
    }
}
