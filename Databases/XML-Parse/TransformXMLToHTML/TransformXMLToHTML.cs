using System;
using System.Xml.Xsl;

namespace CreateXSLT
{
    public class CreateXSLT
    {
        public static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xsl");
            xslt.Transform("../../catalog.xml", "../../catalog.html");
        }
    }
}
