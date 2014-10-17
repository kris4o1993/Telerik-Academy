using System;
using System.Text;
using System.Xml;

namespace CreateXMLAlbum
{
    public class CreateXMLAlbum
    {
        public static void Main()
        {
            XmlTextWriter writer = new XmlTextWriter("../../albums.xml", Encoding.UTF8);
            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("albums");

                string name = string.Empty;
                using (XmlReader reader = XmlReader.Create("../../catalog.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            name = reader.ReadElementString();
                        }
                        else if (reader.NodeType == XmlNodeType.Element &&reader.Name == "artist")
                        {
                            string artist = reader.ReadElementString();
                            WriteAlbum(writer, name, artist);
                        }
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            } 
        }

        private static void WriteAlbum(XmlTextWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");

            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);

            writer.WriteEndElement();
        }
    }
}
