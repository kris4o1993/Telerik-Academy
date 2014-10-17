using System;
using System.Linq;
using System.Xml.Linq;

namespace CreateXMLCatalog
{
    public class CreateXMLCatalog
    {
        public static void Main()
        {
            string[] albumsNames = { "Sound of fire na ice", "Wild", "Tunel" };
            string[] artists = { "Beyonce", "Jesse J", "Justin Timberlake" };
            int[] years = { 2009, 2013, 2013 };
            string[] producers = { "Americano", "MusicPower", "Soundcloud" };
            decimal[] prices = { 20.00m, 12.00m, 14.00m };
            string[][] songsTitles =
            {
                new string[2] { "Game of thrones", "North" },
                new string[1] { "Wild" },
                new string[3] { "Ola ola", "Mirror", "Sexy magic .." }
            };
            int[][] songsDurations =
            {
                new int[2] { 240, 310 },
                new int[1] { 320 },
                new int[3] { 290, 321, 312 }
            };
            
            XElement catalog = new XElement("catalog");
            for (int i = 0; i < albumsNames.Length; i++)
            {
                XElement album = new XElement("album", 
                    new XElement("name", albumsNames[i]),
                    new XElement("artist", artists[i]),
                    new XElement("year", years[i]),
                    new XElement("producer", producers[i]),
                    new XElement("price", prices[i] + "$"));

                XElement songs = new XElement("songs");
                for (int j = 0; j < songsTitles[i].Length; j++)
                {
                    songs.Add(new XElement("song",
                        new XElement("title", songsTitles[i][j]),
                        new XElement("duration", songsDurations[i][j] + "s")));
                }

                album.Add(songs);
                catalog.Add(album);
            }

            catalog.Save("../../catalog.xml");
        }
    }
}
