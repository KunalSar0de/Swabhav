using DeptEmpApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptEmpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var db = new AurionproContext();
            
            var dept10 = new Department {Id= 10,Name= "Sales",Location= "Mumbai" };
            var emp1 = new Employee { Id = 1, Name = "Kunal", Department = "dept10" };
            var emp2 = new Employee { Id = 2, Name = "Vinay", Department = "dept10" };
            var emp3 = new Employee { Id = 3, Name = "Sohel", Department = "dept10" };
            dept10.Employees.Add(emp1);
            dept10.Employees.Add(emp2);
            dept10.Employees.Add(emp3);
            db.Departments.Add(dept10);
            db.SaveChanges();
            PrintDept(db);
            Console.WriteLine("\n\n\n");
            PrintEmp(db);
            Console.ReadKey();  
        }

        public static void PrintDept(AurionproContext context)
        {
            var dept = context.Departments;
            Console.WriteLine("Dept Id\t\tDept Name\tDept Location");
            dept.ToList().ForEach(s => Console.WriteLine("{0}\t\t{1}\t\t{2}", s.Id, s.Name, s.Location));
        }
        public static void PrintEmp(AurionproContext context)
        {
            var dept = context.employee;
            Console.WriteLine("Emp Id\t\tEmp Name\tEmp Dept");
            dept.ToList().ForEach(s => Console.WriteLine("{0}\t\t{1}\t\t{2}", s.Id, s.Name, s.Department));
        }
    }
}
