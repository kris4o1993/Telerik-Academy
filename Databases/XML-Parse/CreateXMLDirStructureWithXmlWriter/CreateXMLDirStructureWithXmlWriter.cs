using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace CreateXMLDirStructureWithXmlWriter
{
    public class CreateXMLDirStructureWithXmlWriter
    {
        public static void Main()
        {
            string rootDirPath = "..\\..\\";
            XElement dirStructure = GetDirStructure(rootDirPath);
            XDocument xml = new XDocument(dirStructure);
            xml.Save("..\\..\\dir-structure.xml");
        }

        private static XElement GetDirStructure(string dirPath)
        {
            XElement dirStructure = new XElement("dir-structure");

            foreach (var file in Directory.GetFiles(dirPath))
            {
                dirStructure.Add(new XElement("file", new XAttribute("path", file)));
            }

            foreach (var dir in Directory.GetDirectories(dirPath))
            {
                dirStructure.Add(GetDirStructure(dir));
            }

            return dirStructure;
        }
    }
}
