using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateObjectsExample();
            CompareItemsInArrayExample();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void CreateObjectsExample()
        {
            Console.WriteLine("\nCreating instances of Item class");
            Item firstItem = new Item();
            Console.WriteLine("1. item: "+ firstItem.name);
            Item secondItem = new Item("Kirja");
            Console.WriteLine("2. item: " + secondItem.name);
        }

        static void CompareItemsInArrayExample()
        {
            Item[] items = new Item[2];
            items[0] = new Item("Aapinen");
            items[1] = new Item("aapinen");

            Console.WriteLine("\nChecking if objects are equal");
            if (items[0].Equals(items[1]))
            {
                Console.WriteLine(items[0].name + " == " + items[1].name);
            }
            else
            {
                Console.WriteLine(items[0].name + " != " + items[1].name);
            }
        }
    }
}
