using System;
using System.Xml;

namespace XmlDocumentTest
{
    class Program
    {
        static void Main(string[] args)
        {
           // RecipeTest();
            RicipeTest2();
            AddNewStep();
        }

        static void RecipeTest()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("recipe.xml"); //DOM 

            XmlElement rootElement = xmlDocument.DocumentElement;

            Console.WriteLine(rootElement.Name);

            Console.WriteLine("Attributes:");
            foreach (XmlAttribute attribute in rootElement.Attributes)
            {
                Console.WriteLine($"\t{attribute.Name}: {attribute.Value}");
            }

            Console.WriteLine("Children: ");
            foreach (XmlNode child in rootElement.ChildNodes)
            {
                Console.WriteLine($"\t{child.Name}: {child.InnerText}");
            }
        }
        static void RicipeTest2()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("recipe.xml"); //DOM 

            XmlElement recipeElement = xmlDocument.DocumentElement;

            XmlNode titleElement = recipeElement.FirstChild;
            XmlNode compositionElement = titleElement.NextSibling;
            XmlNode instructionsElement = recipeElement.LastChild;

            Console.WriteLine($"Recipe: {titleElement.InnerText.Trim()}");

            Console.WriteLine("Ingredients: ");
            foreach (XmlNode ingridientElement in compositionElement.ChildNodes)
            {
                string ingidientName = ingridientElement.InnerText.Trim();
                string ingridientUnit = ingridientElement.Attributes["unit"].Value;
                string ingridiendAmount = ingridientElement.Attributes["amount"].Value;

                Console.WriteLine($"\t {ingidientName} {ingridiendAmount} {ingridientUnit}");
            }

            Console.WriteLine("Instructions: ");
            foreach (XmlNode stepElement in instructionsElement.ChildNodes)
            {
                if(stepElement is XmlElement)
                {
                    Console.WriteLine($"\t - {stepElement.InnerText.Trim()}");
                }
                
            }
        }

        static void AddNewStep()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("recipe.xml"); //DOM 

            XmlElement recipeElement = xmlDocument.DocumentElement;
            XmlNode instructionsElement = recipeElement.LastChild;

            XmlElement stepElement = xmlDocument.CreateElement("step");
            stepElement.InnerText = "new step";

            instructionsElement.AppendChild(stepElement);

            xmlDocument.Save("recipe.xml");
        }
    }
}
