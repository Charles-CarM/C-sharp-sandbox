
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Exponent method

        {
            Console.WriteLine(GetPow(4, 3));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int j = 0; j < powNum; j++)
            {
                result = result * baseNum;
            }

            return result;
        }

    }
}


