using System;
using StudentProfessorApp.Model;

namespace StudentProfessorApp
{
    class Program
    {
        static void Main()
        {
            Professor p = new Professor(101,"dhule","22/04/1962",20000);
            Professor p1 = new Professor(102, "Thane", "7/08/1947", 60000);
            Student s = new Student(103, "Bhusawal", "15/06/1999", "Computer");
            Student s1 = new Student(104, "Nerul", "11/02/1998", "EXTC");
            PrintDetails(p);
            PrintDetails(p1);
            PrintDetails(s);
            PrintDetails(s1);
            Console.ReadLine();
        }
        public static void PrintDetails(Person p)
        {
            Console.WriteLine(p.GetType().Name+"\n");
            Console.WriteLine($"Id= {p.Id}\nAddress = {p.Address}\nDob= {p.DOB}");
            Console.WriteLine(p.ExtraThings());
            Console.WriteLine("-------------------------------------");
        }

    }
}
