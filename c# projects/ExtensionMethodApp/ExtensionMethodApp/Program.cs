using System;
using ExtensionMethodApp.MyExtensionMethod;
using System.Linq;
using System.Collections.Generic;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "AurionPro";
            Console.WriteLine(name.Foo());
            IEnumerable<string> locations = new string[] { "Mumbai", "Banglore", "Chennai", "Delhi", "Kolkata" };
            //locations.Where(); 
            locations.Where(s => s.Contains("M"));
            Console.ReadLine();
        }
    }
}
