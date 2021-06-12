using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TakeSkip();
            //SelectMany1();
            //SelectMany2();
            //SelectMany3();
            //SelectMany4();
            //GroupBy1();
            GroupBy2();
            //Join1();
        }

        static void TakeSkip()
        {
            var result = DbCustomers.GetCustomers().Skip(2).Take(2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=================");

            var result2 = DbCustomers.GetCustomers()
                .TakeWhile(c => c.Country.Equals("Ukraine"));

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

        }

        static void SelectMany1()
        {
            int[] num1 = {1, 2, 3, 4, 5};

            var res = from n1 in num1
                        from n2 in num1
                        select new {Num1 = n1, Num2 = n2, Res = n1*n2};

            foreach (var r in res)
            {
                Console.WriteLine(r);
            }

        }

        static void SelectMany2()
        {
            int[] num1 = { 1, 2, 3, 4, 5 };

            var res = num1.SelectMany(
                n1 => num1.Select(n2 => new {Num1 = n1, Num2 = n2, Res = n1 * n2})
                );
                      

            foreach (var r in res)
            {
                Console.WriteLine(r);
            }

        }

        static void SelectMany3()
        {
            var customers = DbCustomers.GetCustomers();

            //var orders = from c in customers
            //             from o in c.Orders
            //             where o.Total > 1000
            //             select new { CustomerId = c.Id, OrderId = o.Id, Total = o.Total };

            var orders = customers
                .SelectMany(c => c.Orders
                                .Where(o => o.Total > 1000)
                                .Select(o => new {
                                    CustomerId = c.Id,
                                    OrderId = o.Id,
                                    Total = o.Total })
                            );

            foreach (var order in orders)
            {                
                Console.WriteLine(order);
            }
        }

        static void SelectMany4()
        {
            var customers = DbCustomers.GetCustomers();

            //var orders = from c in customers
            //             where c.Name.StartsWith("V")
            //             from o in c.Orders
            //             where o.Total > 1000
            //             select new { CustomerId = c.Id, OrderId = o.Id, Total = o.Total };

            var orders = customers
                .Where(c => c.Name.StartsWith("V"))
                .SelectMany(c => c.Orders
                                  .Where(o => o.Total > 1000)
                                  .Select(o => new { CustomerId = c.Id, OrderId = o.Id, Total = o.Total })
                            );

            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        static void GroupBy1()
        {
            var customers = DbCustomers.GetCustomers();

            //var res = from c in customers                          
            //          group c by c.Country into g
            //          select new { Country = g.Key, Customers = g };

            var res = customers
                .GroupBy(c => c.Country)
                .Select(g => new { Country = g.Key, Customers = g });


            //IEnumerable< IGrouping < key, T >   >    
                
             //foreach (var r in res)
            //{
            //    Console.WriteLine($"Key: {r.Key}");
            //    foreach (var c in r)
            //    {
            //        Console.WriteLine($"\tCustomer: {c.Name}");
            //    }
            //}

            foreach (var group in res)
            {
                Console.WriteLine("Country: {0}", group.Country);
                foreach (var customer in group.Customers)
                {
                    Console.WriteLine(customer.Name);
                }
            }
        }

        static void GroupBy2()
        {
            string[] products = {"Apple", "Plum", "Peach", "Orange", "Avocado"};

            var productGroup = from p in products
                where p.Length > 4
                group p by p[0] into g
                select new {FirstLetter = g.Key, Products = g};

            foreach (var prG in productGroup)
            {
                Console.WriteLine(prG.FirstLetter);
                foreach (var product in prG.Products)
                {
                    Console.WriteLine(product);
                }
            }
        }

        static void Join1()
        {
            var cities = new[] 
            {
                new { Id = 1, Name = "Odessa"}, 
                new { Id = 2, Name = "Varshava"}, 
                new { Id = 3, Name = "Kiev"}
            };
            var customers = DbCustomers.GetCustomers();

            //var res = from city in cities
            //          join customer in customers
            //          on city.Id equals customer.IdCity
            //          select new { City = city.Name, CustName = customer.Name };

            var res = cities.Join(customers,
                                  city => city.Id,
                                  customer => customer.IdCity,
                                  (city, customer) => new { City = city.Name, CustName = customer.Name });

            foreach (var obj in res)
            {
                Console.WriteLine( obj);
            }
        }
    }

    
}
