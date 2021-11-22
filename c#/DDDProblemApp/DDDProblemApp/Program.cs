using System;


namespace DDDProblemApp
{
    class Program
    {
        static void Main()
        {
            ChildA obj1 = new ChildA();
            Console.WriteLine("\n");
            ChildB obj2 = new ChildB();
            Console.WriteLine("\n");
            ChildC obj3 = new ChildC();
            Console.ReadLine();
        }
    }

    class ParentClass  //base class
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor invoked...");
        }
    }
    class ChildA : ParentClass
    {
        public ChildA()
        {
            Console.WriteLine("class Child A constructor invoked...");
        }
    }
    class ChildB : ChildA
    {
        public ChildB()
        {
            Console.WriteLine("class Child B constructor invoked...");
        }
    }
    class ChildC : ChildB
    {
        public ChildC()
        {
            Console.WriteLine("class Child C constructor invoked...");
        }
    }

    //so to solve problem of multiple class inhertiance we use multilevel inheritance...
    //multiple inheritance will be get by Interface...

}
