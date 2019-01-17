using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareItemsInArrayExample();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }

        static void CompareItemsInArrayExample()
        {
            Item[] items = new Item[2];
            items[0] = new Item("Aapinen");
            items[1] = new Item("aapinen");

            Console.WriteLine("Checking if objects are equal");
            if (items[0].Equals(items[1]))
            {
                Console.WriteLine(items[0].name +" == "+ items[1].name);
            }
            else
            {
                Console.WriteLine(items[0].name + " != " + items[1].name);
            }
        }
    }
}
