using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    static class ArrayExtension
    {
        public static int Sum(this int[] arr)
        {
            int res = 0;
            foreach (int item in arr)
            {
                res += item;
            }
            return res;
        }
        public static int Min(this int[] arr)
        {
            int min = arr[0];
            foreach (int item in arr)
            {
                if(item < min)
                {
                    min = item;
                }
            }

            return min;
        }
        public static int Max(this int[] arr)
        {
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static int FindValue(this Array arr, object value)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
			{
			    if(arr.GetValue(i).Equals(value))
                {
                    index = i;
                }
			}

            return index;
        }

        public static void Print(this IEnumerable col)
        {
            foreach (var item in col)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }

     
    }
}
