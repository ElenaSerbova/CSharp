using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Name, Price);
        }
    }
}
