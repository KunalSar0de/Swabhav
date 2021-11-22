using System;
using System.Collections.Generic;
using SetGEnericApp.Model;


namespace SetGEnericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
            Console.ReadLine();
        }
        public static void Case1()
        {
              HashSet<int> set = new HashSet<int>();
            set.Add(10);
            set.Add(200);
            set.Add(5);
            set.Add(5);
            set.Add(300);

            Console.WriteLine("Count= {0}",set.Count);
            Console.WriteLine("\nItems in set");
            foreach(int item in set)
            {
                Console.WriteLine(item);
            }
        }
        public static void Case2()
        {
            HashSet<Students> set = new HashSet<Students>();
            Students s1 = new Students(101,"kunal","Mumbai");
            Students s2 = new Students(101, "kunal", "Mumbai");
            Console.WriteLine("hashcode for s1 : " + s1.GetHashCode());
            Console.WriteLine("hashcode for s2 : "+s2.GetHashCode());

            set.Add(s1);
            set.Add(s2);
            
            Console.WriteLine("Count : "+set.Count);
        }
        public static void Case2()
    }

}
