using System;
using CompositeDesignPatternApp.Model;

namespace CompositeDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder movies = new Folder("Movies");
            movies.AddChild(new File("Titanic","750MB"));
            movies.AddChild(new File("Squid Game", "1.5GB"));

            Folder comedy = new Folder("Comedy");          
            comedy.AddChild(new File("Bhul Bulaiya", "850MB"));
            comedy.AddChild(new File("Secreto", "1.9GB"));
            movies.AddChild(comedy);

            Folder horror = new Folder("Horror");            
            horror.AddChild(new File("Kanchana Return", "850MB"));
            horror.AddChild(new File("Conjuring", "1.9GB"));
            movies.AddChild(horror);

            Folder romentic = new Folder("Romentic");
            romentic.AddChild(new File("Rab ne bana di jodi", "459MB"));            
            horror.AddChild(romentic);

            movies.Display(0);
            Console.ReadKey();
        }
    }
}
