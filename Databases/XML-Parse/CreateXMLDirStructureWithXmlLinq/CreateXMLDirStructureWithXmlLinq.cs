using System;
using System.IO;
using System.Text;
using System.Xml;

namespace CreateXMLDirStructureWithXmlLinq
{
    public class CreateXMLDirStructureWithXmlLinq
    {
        public static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("..\\..\\dir-structure.xml", Encoding.UTF8))
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("dir-structure");

                string rootDirPath = "..\\..\\";
                WriteDirStructure(writer, rootDirPath);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private static void WriteDirStructure(XmlTextWriter writer, string dirPath)
        {
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("path", dirPath);

            foreach (var dir in Directory.GetDirectories(dirPath))
            {
                WriteDirStructure(writer, dir);
            }

            foreach (var file in Directory.GetFiles(dirPath))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("path", file);
                writer.WriteEndElement();
            }

            

            writer.WriteEndElement();
        }
    }
}
