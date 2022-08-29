
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Next level calculator

        {
            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);

            }else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else
            {
                Console.WriteLine("you messed up somewhere");
            }

            Console.ReadLine();
        }

    }
}


