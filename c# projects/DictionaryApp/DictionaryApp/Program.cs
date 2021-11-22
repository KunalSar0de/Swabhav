using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryApp
{
    class Program
    {
        static void Main()
        {
            Case2();
            Console.ReadLine();
        }
        public static void Case1()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "Kunal");
            map.Add(1, "Sohan");
            map.Add(2, "Vinay");
            Console.WriteLine("Count : {0}",map.Count());

            foreach (var item in map)
            {
                Console.WriteLine("Key = {0},Value = {1}", item.Key, item.Value);
            }
        }
        public static void Case2()
        {
            var map = new Dictionary<Student, Student>();
            var s1 = new Student(101,10,"Kunal","Mumbai");
            var s2 = new Student(10, 12, "Chinmay", "Mumbai");
            var s3 = new Student(12, 10, "Kunal", "Mumbai");

            map.Add(s1,s1);
            map.Add(s2, s2);
            if (!map.ContainsKey(s3))
            {
                map.Add(s3, s3);
            }

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine("Count : {0}",map.Count());
        }


    }
}
