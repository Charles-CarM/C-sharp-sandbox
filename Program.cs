
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //two dimensional array

        {
            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 },
                {7, 8 },
                {9, 10 },
                {11, 12 }
            };

            Console.WriteLine(numberGrid[2, 1]);
            Console.ReadLine();
        }

    }
}


