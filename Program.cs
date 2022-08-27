
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Getting user input

        {
            Console.WriteLine("enter username,");
            string userName = Console.ReadLine();
            Console.WriteLine("enter your age,");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you are " + userName + " and " + userAge + " years old");

        }
    }
}


