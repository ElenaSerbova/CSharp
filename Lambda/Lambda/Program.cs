using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] productList =
            {
                new Product{Name="lemon", Price=25.6m, Rate=10},
                new Product{Name="plum", Price=30m, Rate=8},
                new Product{Name="orange", Price=55m, Rate=9},
                new Product{Name="grapes", Price=50m, Rate=9},
                new Product{Name="pineapple", Price=100m, Rate=5},
                new Product{Name="peach", Price=65.5m, Rate=10},
                new Product{Name="watermelon", Price=10m, Rate=8},
                new Product{Name="melon", Price=12, Rate=7}
            };

            Product[] result1 = Array.FindAll(productList, 
                p => p.Price >= 20m && p.Price <= 50m);

            Product[] result2 = Array.FindAll(productList,
                p => p.Price == 100m);

            Product[] result3 = Array.FindAll(productList, 
                p => p.Name.StartsWith("p", true, CultureInfo.CurrentCulture));


        }
    }
}
