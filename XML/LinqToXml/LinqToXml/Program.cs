using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("notebook.xml");
            //Console.WriteLine(document.FirstNode);

            XElement notebook = document.FirstNode as XElement;

            //foreach (var node in notebook.Elements())
            //{
            //    Console.WriteLine(node);
            //}

            var descendants = notebook.Descendants("name");

            foreach (var item in descendants)
            {
                Console.WriteLine(item);
            }

            var res = document.Descendants("person")
                .Where(p => p.Element("surname").Value.StartsWith("P"))
                .Select(p => new
                {
                    LastName = p.Element("surname").Value,
                    Phone = p.Element("phone").Value
                });

            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.Phone}");
            }


            var contact = notebook.Elements("person")
                 .Where(p => p.Element("phone").Value.Equals("33-33-33"))
                 .Select(p => new
                 {
                     FirstName = p.Element("name").Value,
                     LastName = p.Element("surname").Value
                 })
                 .FirstOrDefault();

            Console.WriteLine($"{contact?.FirstName} {contact?.LastName}");


            notebook.Descendants("name").Remove();
            Console.WriteLine(notebook);
        }
    }
}
