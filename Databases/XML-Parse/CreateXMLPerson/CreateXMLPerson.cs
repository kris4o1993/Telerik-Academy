using System;
using System.IO;
using System.Xml.Linq;

namespace CreateXMLPerson
{
    public class CreateXMLPerson
    {
        public static void Main()
        {
            string[] info = File.ReadAllLines("../../person.txt");
            string name = info[0];
            string address = info[1];
            string phone = info[2];

            XElement person = new XElement("person",
                new XElement("name", name),
                new XElement("address", address),
                new XElement("phone", phone));

            person.Save("../../person.xml");
        }
    }
}
