using System;
using System.Linq;
using System.Xml;

namespace DeleteAlbumsWithDOMParser
{
    public class DeleteAlbumsWithDOMParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlNode catalog = doc.DocumentElement;

            foreach (XmlNode album in catalog.ChildNodes)
            {
                string price = album["price"].InnerText.TrimEnd('$');
                if (decimal.Parse(price) >= 20m)
                {
                    catalog.RemoveChild(album);
                }
            }

            doc.Save("../../catalog-new.xml");
        }
    }
}
