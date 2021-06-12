using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aninomous
{
    class Program
    {
        static int CmpDesc(int x, int y)
        {
            return y - x;
        }

        static void UseDelegate()
        {
            int[] arr = { 1, 23, 2, 4, 2, 3, 65, 11 };
            
            //Array.Sort(arr, new Comparison<int>(CmpDesc));
            Array.Sort(arr, CmpDesc);

            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
          
            Console.WriteLine();
        }

        /*
         * delegate(параметры){блок кода}
         */
        static void UseAnonimousMethod1()
        {
            int[] arr = { 1, 23, 2, 4, 2, 3, 65, 11 };

            Comparison<int> del = delegate (int x, int y)
            {
                return y - x;
            };

            Array.Sort(arr, del);

            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        static void UseAnonimousMethod2()
        {
            int[] arr = { 1, 23, 2, 4, 2, 3, 65, 11 };


            Array.Sort(
                arr,
                delegate (int x, int y) { return y - x; }
                );

            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        static void UseLyambda()
        {
            int[] arr = { 1, 23, 2, 4, 2, 3, 65, 11 };

            Array.Sort(
                arr,
                (int x, int y) => { return y - x; }
                );

            Array.Sort(arr, (x, y) => y - x);

            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            UseDelegate();
            //UseAnonimousMethod1();
            //UseAnonimousMethod2();
            //UseLyambda();
        }

       
    }
}
