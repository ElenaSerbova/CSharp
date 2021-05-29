using System;
using System.Collections;
using System.Collections.Generic;


namespace SystemCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingArrayList();
            //UsingHashtable();
            //UsingList();
            //UsingQueue();
            //UsingStack();
            //UsingLinkedList();
            //UsingDictionary();
            UsingSortedDictionary();
        }

        static void UsingArrayList()
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);


            list.Add("value1");
            list.Insert(0, "value2");
            list.AddRange(new string[] { "value3", "value4", "value5" });
            list.Add(12);
            list.Add(new Random());

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);

            list.Remove("value4");
            list.RemoveAt(0);

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);

            list.TrimToSize();

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count   : {0}", list.Count);

            foreach(object el in list)
            {
                Console.WriteLine(el);
            }

        }
        static void UsingHashtable()
        {
            Hashtable hashTable = new Hashtable();

            hashTable.Add("lemon", 25.5);
            
            hashTable["apple"] = 17.9;
            hashTable["plum"] = 50.0;

            foreach (DictionaryEntry pair in hashTable)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static void UsingList()
        {
            List<int> list = new List<int>();

            list.Add(100);
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            list.Insert(3, 300);

            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count:    {list.Count}");

            foreach (int item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int i = list.IndexOf(300);
            if (i != -1)
            {
                Console.WriteLine($"found value");
            } 
            
            List<int> result = list.FindAll(IsEven);

            list.Sort();

            for (int j = 0; j < list.Count; j++)
            {
                Console.Write($"{list[j]}\t");
            }
            Console.WriteLine();

        }
        static void UsingQueue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("value 1");
            queue.Enqueue("value 2");
            queue.Enqueue("value 3");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        static void UsingStack()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("value 1");
            stack.Push("value 2");
            stack.Push("value 3");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            string el = stack.Peek();
            el = stack.Pop();
        }
        static void UsingLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddFirst("value 1");
            list.AddLast("value 2");
            list.AddLast("value 3");
            list.AddLast("value 4");

            LinkedListNode<string> node = list.Find("value 3");
            if(node != null)
            {
                list.AddBefore(node, "value 5");
                list.AddAfter(node, "value 6");
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
    
            list.Remove(node);
            list.Remove("value 4");

            Console.WriteLine("===========================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UsingDictionary()
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            products.Add("lemon", 45.6m);

            products["plum"] = 34.5m;  //add
            products["pear"] = 90m;
            products["apple"] = 17.9m;
            products["orange"] = 45.5m;
            products["lemon"] = 23.4m; //replace value

            foreach (KeyValuePair<string, decimal> item in products)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            if(products.ContainsKey("lemon"))
            {
                products["lemon"] *= 1.1m;
            }

        }

        static void UsingSortedDictionary()
        {
            SortedDictionary<string, decimal> products = new SortedDictionary<string, decimal>();

            products.Add("lemon", 45.6m);

            products["plum"] = 34.5m;  //add
            products["pear"] = 90m;
            products["apple"] = 17.9m;
            products["orange"] = 45.5m;
            products["lemon"] = 23.4m; //replace value

            foreach (KeyValuePair<string, decimal> item in products)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            if (products.ContainsKey("lemon"))
            {
                products["lemon"] *= 1.1m;
            }

        }
    }
}
