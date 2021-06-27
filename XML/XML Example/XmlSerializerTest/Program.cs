using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            recipe.Title = "Простой хлеб";
            recipe.Time = 180;
            recipe.Ingridients = new List<Ingridient>
            {
                new Ingridient{Name = "Мука", Amount = 3, Unit = "стакан"},
                new Ingridient{Name = "Дрожжи", Amount = 0.25, Unit = "грамм"},
            };

            recipe.Instructions = new List<string>
            {
                "Смешать все ингредиенты и тщательно замесить.",
                "Закрыть тканью и оставить на один час в тёплом помещении.",
                " Замесить ещё раз, положить на противень и поставить в духовку."
            }; 
            
            XmlSerializer serializer = new XmlSerializer(typeof(Recipe));

            using (FileStream fileStream = new FileStream("recipe.xml", FileMode.Create, FileAccess.Write))
            {               
                serializer.Serialize(fileStream, recipe);
            }

            using (FileStream fileStream = new FileStream("recipe.xml", FileMode.Open, FileAccess.Read))
            {
                Recipe recipeReading = (Recipe)serializer.Deserialize(fileStream);
            }

        }
    }
}
