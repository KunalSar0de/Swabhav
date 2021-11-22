using System;
using PropertySyntexApp.Model;
namespace PropertySyntexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f1 = new Foo();
            Console.WriteLine("Baz set: {0}",f1.Baz);
            Console.WriteLine("Bar default value: {0}",f1.Bar);
            f1.Bar = 200;
            Console.WriteLine("Bar set= {0}",f1.Bar);
            Console.ReadLine();
        }
    }
}
