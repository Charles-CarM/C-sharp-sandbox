
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)

        //Getters and Setters

        {
            Movie sandlot = new Movie("The Sandlot", "Smalls", "PG-13");
            Movie rascals = new Movie("The Little Rascals", "Alfalpha", "PG");

            //G, PG, PG-13, R, NR

            sandlot.Rating = "G";

            Console.WriteLine(sandlot.Rating);
            Console.WriteLine(rascals.Rating);

            Console.ReadLine();
        }
       
    }
}


