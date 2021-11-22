using System;
using InheritanceConstructorV2App.Model;

namespace InheritanceConstructorV2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c=new Child();
            Console.WriteLine(c.GetFoo);
            Child c1 = new Child(200);
            Console.WriteLine(c1.GetFoo);
            Console.Read();
        }
    }
}
