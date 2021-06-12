using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class DbCustomers
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1001,
                    Name = "Vitya",
                    Country = "Ukraine",
                    IdCity = 1,
                    Orders = new List<Order>
                    {
                        new Order{ Id = 1, Date = new DateTime(2017, 1, 12), Total = 1050m},
                        new Order{ Id = 2, Date = new DateTime(2017, 2, 22), Total = 600m},
                        new Order{ Id = 3, Date = new DateTime(2017, 3, 1), Total = 2500m}
                    }
                },
                new Customer
                {
                    Id = 1002,
                    Name = "Vasiliy",
                    Country = "Poland",
                    IdCity = 2,
                    Orders = new List<Order>
                    {
                        new Order{ Id = 1, Date = new DateTime(2017, 1, 5), Total = 550m},
                        new Order{ Id = 2, Date = new DateTime(2017, 2, 15), Total = 1250m},
                        new Order{ Id = 3, Date = new DateTime(2017, 3, 2), Total = 930m}
                    }
                },
                new Customer
                {
                    Id = 1003,
                    Name = "Olga",
                    Country = "Ukraine",
                    IdCity = 3,
                    Orders = new List<Order>
                    {
                        new Order{ Id = 1, Date = new DateTime(2017, 1, 2), Total = 3000m},
                        new Order{ Id = 2, Date = new DateTime(2017, 1, 25), Total = 750m},
                        new Order{ Id = 3, Date = new DateTime(2017, 3, 1), Total = 2550m}
                    }
                }
            };

            return customers;
        }
    }
}
