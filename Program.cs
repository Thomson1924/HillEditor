using System;
using System.Xml;

namespace HillEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument newhill = new XmlDocument();
            newhill.Load("Testhill-HS140-POL.xml");
            var a = newhill.SelectNodes("inrun");

            BasicHillEditor(newhill);
            newhill.PreserveWhitespace = true;
            newhill.Save("Testhill-HS140-POL.xml");
            string finalDoc = newhill.OuterXml;
        
        }
        static void BasicHillEditor(XmlDocument hill)
        {
            XmlElement root = hill.DocumentElement;
            root.SetAttribute("version","DSJ4-1.8.0");
        }
    }
}
