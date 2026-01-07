using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ItemsExample
{
    class Program
    {
        /*
         * The Main method is the entry point of a C# application.
         * When the application is started, the Main method is called at first.
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Project: ItemsExample");

            CreateItemsExample();
            CompareItemsInArrayExample();
            CheckItemsInListExample();
            CheckItemsInHashtableExample();
            CheckItemsInDictionaryExample();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        /*
         * An example how to create objects (instances) of the Item class
         */
        static void CreateItemsExample()
        {
            Console.WriteLine("\nCreating objects (instances) of Item class");
            Item firstItem = new Item();
            Console.WriteLine("1. item: "+ firstItem.name);
            Item secondItem = new Item("Kirja");
            Console.WriteLine("2. item: " + secondItem.name);
        }

        /*
         * An example how to use overridden Equals() -method to compare two objects of Item class.
         */
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

        static void CheckItemsInListExample()
        {
            Console.WriteLine("\nAdding objects to the List");
            List<Item> items = new List<Item>();
            Item hammer = new Item("vasara");
            Item nail = new Item("naula");
            items.Add(hammer);
            items.Add(nail);

            foreach (Item tool in items)
            {
                Console.WriteLine($"{tool.id}: {tool.name} in the List");
            }
            
            if (items.Contains(nail))
            {
                Console.WriteLine($"{nail.name} found in the List");
            }

            items.Remove(nail);

            if (items.Contains(nail))
            {
                Console.WriteLine($"{nail.name} found in the List");
            }
            else
            {
                Console.WriteLine($"{nail.name} removed from the List");
            }
        }

        static void CheckItemsInHashtableExample()
        {
            Console.WriteLine("\nAdding objects to the Hashtable");
            Hashtable items = new Hashtable();
            Item hammer = new Item("vasara");
            Item nail = new Item("naula");

            items.Add(hammer.name, hammer);
            items.Add(nail.name, nail);

            // Enumerate the hashtable
            foreach (DictionaryEntry entry in items)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }
        }

        static void CheckItemsInDictionaryExample()
        {
            Console.WriteLine("\nAdding objects to the Dictionary");
            Dictionary<string, Item> dictionary = new Dictionary<string, Item>();
            Item hammer = new Item("vasara");
            Item nail = new Item("naula");

            dictionary.Add(hammer.name, hammer);
            dictionary.Add(nail.name, nail);

            // Enumerate the dictionary
            foreach (KeyValuePair<string, Item> kvp in dictionary)
            {
                Console.WriteLine("{0} = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
