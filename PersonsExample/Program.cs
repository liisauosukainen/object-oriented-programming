using System.Text;

namespace PersonsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Project: PersonsExample");
            CreatePersonsExample();
        }

        /*
         * Creates a Person object and demonstrates the use of properties 
         * for encapsulated data access and modification (reading and writing)
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

            if (firstPerson.GetPersonInfo("Virtanen") != null)
            {
                Console.WriteLine("Information found: " + firstPerson.GetPersonInfo("Virtanen").ToString());
            }
            else
            {
                Console.WriteLine("Information about the person not found");
            }
        }
    }
}
