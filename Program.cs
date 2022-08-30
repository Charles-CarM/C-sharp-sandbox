
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)

        //Object Methods

        {
            Student student1 = new Student("Kim", "Communications", 3.1);            
            Student student2 = new Student("Hannah", "Petroleum Engineering", 3.7);
            Student student3 = new Student("Alex", "Finance", 2.9);
            //Student student4 = new Student();

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(student3.HasHonors()); 


            Console.ReadLine();
        }
       

    }
}


