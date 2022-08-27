
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //working with strings

        {

            string phrase = "Breakfast Club";

            Console.WriteLine(phrase.Substring(0, 4));

            Console.ReadLine();

        }
    }
}

//phrase.ToUpper()        BREAKFAST CLUB  
//phrase.ToLower()        breakfast club
//phrase[0]               B  
//phrase.IndexOf("Club")  10
//phrase.Length           14
//phrase.Substring(10)    Club
//phrase.Substring(0, 4)  Brea