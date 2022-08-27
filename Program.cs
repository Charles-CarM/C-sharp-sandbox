
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Return Statement

        {
            int cubedNumber = CubeMe(5);

            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }

        static int CubeMe(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}


