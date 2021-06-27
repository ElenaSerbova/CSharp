using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlSerializerTest
{    
    public class Ingridient
    {
        [XmlText]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "amount")]
        public double Amount { get; set; }

        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
    }

    [XmlRoot(ElementName = "recipe")]
    public class Recipe
    {
        [XmlElement(ElementName ="title")]
        public string Title { get; set; }

        [XmlAttribute(AttributeName = "time")]   
        public int Time { get; set; }

        [XmlArray(ElementName = "ingridients")]
        [XmlArrayItem(ElementName = "ingridient")]
        public List<Ingridient> Ingridients { get; set; }

        [XmlArray(ElementName = "instructions")]
        [XmlArrayItem(ElementName = "step")]
        public List<string> Instructions { get; set; }
    }
}
