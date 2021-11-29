using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionApp
{
    class Program
    {
        static void Main()
        {
            //Action==Consumer
            Console.WriteLine("\nAction==Consumer");
            Action<string> PrintHowdy = (n) => Console.WriteLine("Howdy Says "+n);
            PrintHowdy("Hii");

            Action<string, string> PrintFullName = (fn, ln) => Console.WriteLine("first name : {0}\nlast name : {1}",fn,ln);
            PrintFullName("kunal","sarode");

            Console.WriteLine("\nFunc==Producer");
            Func<int, int, long> CalArea = (w, h) => w * h;
            Console.WriteLine("Result of area calculation : {0}",CalArea(5,6));

            Console.WriteLine("\nPredicate==true or false.");
            Predicate<string> isLongName = (name) => name.Length > 6;
            Console.WriteLine(isLongName("bdajsdhkahdkjahd"));

            string userName = "SwabhavTechLabs";
            Console.WriteLine("Is {0} isa long name ? {1}",userName,isLongName(userName));

            Console.ReadKey();
        }
    }
}
