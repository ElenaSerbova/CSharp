using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = { "Item 1", "Item 2", "Item 3", "Item 4" };
            int currentItem = 0;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == currentItem)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine(menuItems[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentItem--;
                        break;

                    case ConsoleKey.DownArrow:
                        currentItem++;
                        break;
                }
            }
            
        }
    }
}
