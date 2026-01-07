namespace LearningEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: LearningEnums");
            EnumTest();
        }
        static void EnumTest()
        {
            EnumShowcase enumTest = new EnumShowcase();
            enumTest.PrintDetails();
        }
    }
}
