
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //If Else statements

        {
            bool isHungry = true;
            bool isDead = true;
            bool isCloudy = false;


            Console.WriteLine("I wake up");
            Console.ReadLine();
            if (isHungry)
            {
                Console.WriteLine("eat breakfast");
            }
            else
            {
                Console.WriteLine("I'll skip breakfast today");
            }
            Console.ReadLine();

            Console.WriteLine("I look at my phone");
            Console.ReadLine();
            if (isDead)
            {
                Console.WriteLine("I charge my phone");
            }
            else
            {
                Console.WriteLine("phone has full juice");
            }
            Console.ReadLine();

            Console.WriteLine("I leave my house");
            Console.ReadLine();
            if (isCloudy)
            {
                Console.WriteLine("I bring an umbrella");
            }
            else
            {
                Console.WriteLine("I bring sunglasses");
            }
            Console.ReadLine();
               

            //bool isMale = false;
            //bool isTall = false;


            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}else if(isMale && !isTall)
            //{
            //    Console.WriteLine("you are a short male");

            //}else if( !isMale  && isTall)
            //{
            //    Console.WriteLine("you are not a male, but you are tall");

            //}
            //else
            //{
            //    Console.WriteLine("you are not male and not tall");
            //}

            //Console.ReadLine();

        }

    }
}


