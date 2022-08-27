
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Methods && functions

        {

            SayHi("Charles", 55);
            SayHi("Carroll", 32);
            SayHi("Sam", 17);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}


