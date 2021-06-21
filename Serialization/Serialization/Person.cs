using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        
        private int _id;
        private string _name;
        private int _age;

        [XmlAttribute]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement(ElementName ="FullName")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override string ToString()
        {
            return $"{_id}. {_name, -10} age: {_age}";
        }
    }
}
