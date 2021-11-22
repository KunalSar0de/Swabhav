using System;
using System.Threading;

namespace SingletonDesignPatternApp
{
    class Program
    {
        static void Main()
        {

            Case2();
            Console.ReadKey();
        }
        public static void Case1()
        {
            var service1 = DataService.GetInstance();
            var service2 = DataService.GetInstance();
            var service3 = DataService.GetInstance();

            Console.WriteLine("\n" + service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());
            Console.WriteLine(service3.GetHashCode());
            Console.WriteLine("");

            service1.DoSomthing();
            service2.DoSomthing();
            service3.DoSomthing();
        }

        public static void Case2()
        {
            Thread t1 = new Thread(() =>
            {
                DataService.GetInstance().DoSomthing();
            });

            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoSomthing();
            });

            t1.Start();
            t2.Start();
        }
        
    }
}
