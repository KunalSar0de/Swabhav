using System;


namespace InheritClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Case1();
            Case2();
            Case3();*/
            //Case4();
            Case5();
            Console.ReadLine();
        }
        public static void Case1()
        {
            Man x;
            x = new Man();
            Console.WriteLine("Case 1:");
            x.Walk();
            x.Play();
            x.Read();
        }
        public static void Case2()
        {
            Boy b;
            b = new Boy();
            Console.WriteLine("\nCase 2");
            b.Walk();
            b.Play();
            b.Read();
            b.Jump();
        }
        public static void Case3()
        {
            Man x;
            x = new Boy();
            Console.WriteLine("\nCase 3:");
            x.Walk();
            x.Play();
            x.Read();
        }
        public static void Case4()
        {
            atPark(new Man());
            atPark(new Boy());
            atPark(new Kid());
            atPark(new Infant());

        }

        public static void Case5()
        {
            Object x;

            x = 10;
            Console.WriteLine(x.GetType());
            x = "Kunal";
            Console.WriteLine(x.GetType());
            x = 10.55f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
        public static void atPark(Man x)
        {
            Console.WriteLine("At park");
            x.Play();
        }
    }
}
