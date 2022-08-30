
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)

        //Classes & Objects

        {
            Book book1 = new Book();
                book1.title = "Millennial Money";
                book1.author = "Patrick O'Shaugnessy";
                book1.pages = 250;

            Book book2 = new Book();
                book2.title = "Flash Boys";
                book2.author = "Michael Lewis";
                book2.pages = 290;

            Book book3 = new Book();
                book3.title = "The Great Gatsby";
                book3.author = "F.Scott Fitzgerald";
                book3.pages = 237;

            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }

    }
}


