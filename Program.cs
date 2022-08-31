
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)

        //static class attributes

        {
            Song watchTower = new Song("All along the watch tower", "Jimmy Hendrix", 265);
            Console.WriteLine(Song.songCount);

            Song stairWay = new Song("Stairway to Heaven", "Led Zeppelin", 250);
            //Console.WriteLine(stairWay.getSongCount());

            Song one = new Song("One", "Metallica", 279);
            //Console.WriteLine(one.getSongCount());

            Console.ReadLine();
        }
       
    }
}


