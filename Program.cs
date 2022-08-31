
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)

        //Inheritance

        {
            Chef souschef1 = new Chef();                      
                souschef1.MakeSpecialDish();
                   
            MexicanChef souschef2 = new MexicanChef();
                souschef2.MakeSpecialDish();

            Console.ReadLine(); 
        }
       
    }
}


