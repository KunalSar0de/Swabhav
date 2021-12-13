using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLinqApp.Model;

namespace StudentLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student() { RollNo = 1, Name = "kunal", Location = "mumbai", CGPA = 7.24 });
            student.Add(new Student() { RollNo = 2, Name = "sagar", Location = "delhi", CGPA = 6.54 });
            student.Add(new Student() { RollNo = 3, Name = "vinay govekar", Location = "chennai", CGPA = 8.64 });
            student.Add(new Student() {RollNo = 4, Name = "chinmay", Location = "pune", CGPA = 6.44});
            student.Add(new Student() { RollNo = 5, Name = "akshay sutar", Location = "mumbai", CGPA = 8.66 });

            Console.WriteLine("\n->All students");
            student.ForEach(x => Console.WriteLine("Name : {0}\tCGPA : {1}",x.Name,x.CGPA));

            Console.WriteLine("\n->Student with location mumbai");
            student.Where(x => x.Location.Contains("mumbai"))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Name));

            Console.WriteLine("\n->Student with name length more than 7");
            student.Where(x => x.Name.Length > 7)
                .ToList()
                .ForEach(x=>Console.WriteLine(x.Name));

            Console.WriteLine("\n->Student from mumbai and pune");
            student.Where(l =>l.Location.Contains("mumbai")||l.Location.Contains("pune"))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Name));

            Console.WriteLine("\n->Average CGPA of All student");
            //studentAvgCGPA.ForEach(x => x.CGPA);

            Console.WriteLine("\n->Unordered List");
            string html = "<ul>\n";
            student.ForEach(x => html += "<li>" + x.Name + "</li>\n");
            html += "</ul>";
            Console.WriteLine(html);

            Console.ReadKey();
        }
    }
}
