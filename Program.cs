using System;
using System.Xml;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HillEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument newhill = new XmlDocument();
            newhill.Load("Testhill-HS140-POL.xml");

            var test = newhill.DocumentElement.SelectSingleNode("/hill/inrun");
            var a = test.FirstChild;

            BasicHillEditor(newhill);
            newhill.PreserveWhitespace = true;
            List<string> lista = new List<string> {
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100"),
                new string ("100")
            };
            SprawdzSekcje(a);

            SaveDocPleaseWchuj(newhill,"AleSeSkacze2","ITam","ATHXD");
        }
        static void BasicHillEditor(XmlDocument hill)
        {
            XmlElement root = hill.DocumentElement;
            root.SetAttribute("version", "DSJ4-1.8.0");

        }

        static void SetdokumentxD(XmlNode node, List<string> zmiany)
        {
            for (int i = 0; i < zmiany.Count; i++)
            {
                node.Attributes[i].Value = zmiany.ElementAt(i);
                //Console.WriteLine(node.Attributes[i].InnerText); 
            }
        }
        static void SaveDocPleaseWchuj(XmlDocument doc,string nazwaSkoczni,string Costam,string Narodowosc)
        {
            string path = String.Format(@"{0}-{1}-{2}.xml",nazwaSkoczni,Costam,Narodowosc);
            XmlSerializer writer = new XmlSerializer(typeof(XmlDocument));
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, doc);
            }
        }

        static void SprawdzSekcje(XmlNode mainNode)
        {
            XmlNodeList aa = mainNode.ChildNodes;
            foreach(XmlNode item in aa)
            {
                foreach(XmlNode bb in item.ChildNodes)
                {
                    bb.Value = "Aa";
                }
            }
        }
    }
}
