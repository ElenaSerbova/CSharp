using System;
using System.Text;
using System.Xml;

namespace XmlReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterTest();
            XmlReaderTest();
        }

        static void XmlWriterTest()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            //settings.NewLineOnAttributes = true;

            using (XmlWriter xmlWriter = XmlTextWriter.Create("recipe.xml", settings))
            {
                xmlWriter.WriteStartElement("recipe");
                xmlWriter.WriteAttributeString("name", "хлеб");
                xmlWriter.WriteAttributeString("preptime", "5min");
                xmlWriter.WriteAttributeString("cooktime", "180min");

                xmlWriter.WriteElementString("title", " Простой хлеб");

                xmlWriter.WriteStartElement("compositions");

                xmlWriter.WriteStartElement("ingridient");
                xmlWriter.WriteAttributeString("amount", "3");
                xmlWriter.WriteAttributeString("unit", "стакан");
                xmlWriter.WriteString("Мука");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

            }
        }

        static void XmlReaderTest()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader xmlReader = XmlReader.Create("recipe.xml", settings))
            {
                
                xmlReader.Read();
                
                Console.WriteLine(xmlReader.Name);
                Console.WriteLine(xmlReader.NodeType);

                if(xmlReader.HasAttributes)
                {
                    Console.WriteLine("Attrributes: ");
                    while(xmlReader.MoveToNextAttribute())
                    {
                        Console.WriteLine($"\t {xmlReader.Name} {xmlReader.Value}");
                    }
                }

                xmlReader.ReadStartElement();
                string title = xmlReader.ReadElementContentAsString();
                Console.WriteLine(title);    

                xmlReader.ReadStartElement();
                Console.WriteLine(xmlReader.Name);
               
                if (xmlReader.HasAttributes)
                {
                    Console.WriteLine("Attrributes: ");
                    while (xmlReader.MoveToNextAttribute())
                    {
                        Console.WriteLine($"\t {xmlReader.Name} {xmlReader.Value}");
                    }
                }

                xmlReader.MoveToContent();

                string name = xmlReader.ReadElementContentAsString();
                Console.WriteLine(name);
                

            }
        }
    }
}
