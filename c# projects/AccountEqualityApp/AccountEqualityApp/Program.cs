using System;
using AccountEqualityApp.Model;

namespace AccountToStringEqualityApp
{
    class Program
    {
        static void Main()
        {
            //Case2();
            Case1();
            Console.Read();
        }

        public static void Case1()
        {
            Account a = new Account(101, "kunal", 10000);
            Account b = new Account(101, "vipul", 7000);
            //Console.WriteLine(a);

            Console.WriteLine(a.GetHashCode()==b.GetHashCode());            
            Console.WriteLine(a.Equals(b));

        }

        public static void Case2()
        {
            Account a = new Account(101, "kunal", 10000);
            Console.WriteLine(a);           
        }     
    }
}
