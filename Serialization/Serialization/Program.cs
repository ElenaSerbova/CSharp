using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // BinarySerialization();
            // BinarySerializationList();
            // SoapSerialization();
            // XmlSerialization();
        }

        static void BinarySerialization()
        {
            Person person = new Person
            {
                Id = 1,
                Name = "Ivan",
                Age = 25
            };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenWrite("person.bin"))
            {                
                formatter.Serialize(stream, person);
                Console.WriteLine("Serialized");
            }

            using(FileStream stream = File.OpenRead("person.bin"))
            {
                Person p = (Person)formatter.Deserialize(stream);
                Console.WriteLine("Deserialized");
                Console.WriteLine(p);
            }

        }
        static void BinarySerializationList()
        {
            List<Person> list = new List<Person>
            {
                new Person{Id=1, Name="Olga", Age=23},
                new Person{Id=2, Name="Ivan", Age=25},
                new Person{Id=3, Name="Vasiliy", Age=32},
                new Person{Id=4, Name="Vladimir", Age=50}
            };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenWrite("personList.bin"))
            {
                formatter.Serialize(stream, list);
                Console.WriteLine("Serialized");
            }

            using (FileStream stream = File.OpenRead("personList.bin"))
            {
                List<Person> list2 = (List<Person>)formatter.Deserialize(stream);
                Console.WriteLine("Deserialized");

                foreach (var p in list2)
                {
                    Console.WriteLine(p);
                }               
            }

        }
        static void SoapSerialization()
        {
            ArrayList list = new ArrayList
            {
                new Person{Id=1, Name="Olga", Age=23},
                new Person{Id=2, Name="Ivan", Age=25},
                new Person{Id=3, Name="Vasiliy", Age=32},
                new Person{Id=4, Name="Vladimir", Age=50}
            };

            SoapFormatter formatter = new SoapFormatter();

            using (FileStream stream = File.OpenWrite("personList.soap"))
            {
                formatter.Serialize(stream, list);
                Console.WriteLine("Serialized");
            }

            using (FileStream stream = File.OpenRead("personList.soap"))
            {
                ArrayList list2 = (ArrayList)formatter.Deserialize(stream);
                Console.WriteLine("Deserialized");

                foreach (var p in list2)
                {
                    Console.WriteLine(p);
                }
            }

        }

        static void XmlSerialization()
        {
            List<Person> list = new List<Person>
            {
                new Person{Id=1, Name="Olga", Age=23},
                new Person{Id=2, Name="Ivan", Age=25},
                new Person{Id=3, Name="Vasiliy", Age=32},
                new Person{Id=4, Name="Vladimir", Age=50}
            };

            XmlSerializer serializer = new XmlSerializer(list.GetType(), new XmlRootAttribute("Catalog"));

            using (FileStream stream = new FileStream("persons.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, list);
            }

            using (FileStream stream = File.OpenRead("persons.xml"))
            {
                List<Person> list2 = (List<Person>)serializer.Deserialize(stream);

                foreach (var p in list2)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
