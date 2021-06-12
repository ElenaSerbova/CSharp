using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int IdCity { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Orders: ");
            foreach (Order order in Orders)
            {
                builder.AppendLine(order.ToString());
            }

            return String.Format("Id: {0}\nName: {1}\n{2}", 
                Id, Name, builder.ToString());

        }
    }
}
