using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product{ Name = "Apple", Price = 24.5m},
                new Product{ Name = "Pineapple", Price = 150m},
                new Product{ Name = "Grapes", Price = 55.6m},
                new Product{ Name = "Cherry", Price = 35.2m},
                new Product{ Name = "Plum", Price = 38.3m},
                new Product{ Name = "Peach", Price = 45.5m},
                new Product{ Name = "Melon", Price = 12.5m},
                new Product{ Name = "Watermelon", Price = 6.5m},
            };

            // WithoutLinq(products);
            // WithLinq(products);
            // Linq(products);
            // WithLinq2(products);

            var res = GetProductsP(products);

            foreach (var p in res)
            {
                Console.WriteLine(p);
            }
        }

        static void WithoutLinq(List<Product> products)
        {
            var result = new List<Product>();

            foreach (var product in products)
            {
                if (product.Name.StartsWith("P"))
                {
                    result.Add(product);
                }
            }

            result.Sort();

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

        static void WithLinq(List<Product> products)
        {
            var result = 
                from product in products
                where product.Name.StartsWith("P")
                orderby product.Name
                select product;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine( result.GetType());
        }

        static void Linq(List<Product> products)
        {
            //var resultWhere = products.Where(product => product.Name.StartsWith("P"));
            //var resultOrder = resultWhere.OrderBy(product => product.Name);
            //var result = resultOrder.Select(product => product);

            var result = products
                .Where(product => product.Name.StartsWith("P"))
                .OrderBy(product => product.Name)
                .Select(product => product);

            products.Add(new Product { Name = "Pomelo", Price = 56.7m });

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(result.GetType());
        }

        static void WithLinq2(List<Product> products)
        {
            var result =
                (from product in products
                where product.Name.StartsWith("P")
                orderby product.Name
                select product).ToList();

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            products.Add(
                new Product
                {
                    Name = "Pepper",
                    Price = 23.4m
                }
            );

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

        static IEnumerable<Product> GetProductsP(List<Product> products)
        {
            var result =
               from product in products
               where product.Name.StartsWith("P")
               orderby product.Name
               select product;

            return result;
        }

        static IEnumerable<Product> GetProductsP2(List<Product> products)
        {
            var result =
               from product in products
               where product.Name.StartsWith("P")
               orderby product.Name
               select product;

            return result.ToList();
        }
    }
}
