using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> locations = new string[]
            { "Mumbai","Chennai","Hyderabad","Delhi","Pune"};

            IEnumerable<string> locationWithA = locations.Where(l => l.Contains("a"));
            IEnumerable<string> topIn3Ascending = locationWithA.OrderBy(l=>l).Take(3);
            //topIn3Ascending.ToList().ForEach(Console.WriteLine); 
            foreach(var l in topIn3Ascending)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();

        }
    }
}
