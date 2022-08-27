
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Mad lib

        {

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\nRoses are " + color);
            Console.WriteLine(pluralNoun + " are Blue");
            Console.WriteLine("I love " + celebrity);

        }
    }
}


