
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)

        //Constructors

        {
            Book book1 = new Book("Millennial Money", "Patrick O'Shaugnessy", 250);            
            Book book2 = new Book("Flash Boys", "Michael Lewis", 290);
            Book book3 = new Book("The Great Gatsby", "F.Scott Fitzgerald", 237);
            Book book4 = new Book();

            book4.author = "Aldous Huxley";
            book4.title = "The Island";
            book4.pages = 330;

            Console.WriteLine($"{book1.title} by {book1.author}, {book1.pages} pages.\n");
            Console.WriteLine($"{book2.title} by {book2.author}, {book2.pages} pages.\n");
            Console.WriteLine($"{book3.title} by {book3.author}, {book3.pages} pages.\n");
            Console.ReadLine();
        }

    }
}


