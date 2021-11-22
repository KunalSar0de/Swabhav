using System;
using PropertyTestApp.Model;
namespace PropertyTestApp
{
    class StudentTest
    {
        static void Main()
        {
            CaseStudy2();
        }

        public static void CaseStudy1()
        {
            Student s1;
            s1 = new Student("101", "kunal", 22);
            PrintDetails(s1);
        }

        public static void CaseStudy2()
        {
            Student1 s1;
            s1 = new Student1();
            //s1._name = "kunu";
            PrintDetails1(s1);
        }
        static void PrintDetails(Student s)
        {          
            Console.WriteLine("Student code: {0}\nStudent name: {1}\nStudent age: {2}", s.Code, s.Name, s.Age);
            Console.ReadKey();
        }
        static void PrintDetails1(Student1 s)
        {
            Console.WriteLine("Student code: {0}\nStudent name: {1}\nStudent age: {2}", s._code, s._name, s._age);
            Console.ReadKey();
        }
    }
}
