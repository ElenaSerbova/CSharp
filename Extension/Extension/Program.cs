using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            arr.Print(); //ArrayExtension.Print(arr)

            Console.WriteLine( ArrayExtension.Sum(arr) );
            Console.WriteLine( arr.Sum() );
            Console.WriteLine( arr.Min() );
            Console.WriteLine( arr.Max() );
            Console.WriteLine( arr.FindValue(5));

            string[] strs = {"qqq", "www", "eeee" };
            strs.Print();

            List<string> list = new List<string>{ "aaa", "sss", "ddd" };
            list.Print();
        }
    }
}
