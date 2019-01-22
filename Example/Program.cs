using System;

namespace Example
{
    class Program
    {
        /*
         * The Main method is the entry point of a C# application.
         * When the application is started, the Main method is called at first.
         */
        static void Main(string[] args)
        {
            CreateObjectsExample();
            CreatePersonsExample();
            CompareItemsInArrayExample();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        /*
         * An example how to create objects (instances) of the class
         */
        static void CreateObjectsExample()
        {
            Console.WriteLine("\nCreating objects (instances) of Item class");
            Item firstItem = new Item();
            Console.WriteLine("1. item: "+ firstItem.name);
            Item secondItem = new Item("Kirja");
            Console.WriteLine("2. item: " + secondItem.name);
        }

        /*
         * Using properties
         */
        static void CreatePersonsExample()
        {
            Console.WriteLine("\nCreating object (instance) of Person class, " +
                              "where properties are used to read and write private fields.");
            Person firstPerson = new Person();
            firstPerson.LastName = "Virtanen";
            firstPerson.Age = 23;
            Console.WriteLine("name: " + firstPerson.LastName);
            Console.WriteLine("age: " + firstPerson.Age);
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
    }
}
