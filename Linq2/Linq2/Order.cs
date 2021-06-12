using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0}, Date: {1}, Total: {2}",
                Id, Date, Total);
        }
    }
}
