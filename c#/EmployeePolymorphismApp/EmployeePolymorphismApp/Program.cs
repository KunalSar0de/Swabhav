using System;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(101,"vinay",20000);
            Developer d = new Developer(102,"sagar",15000);
            Accountant a = new Accountant(103, "sohan", 10000);         

            SalarySlip(m);
            SalarySlip(d);
            SalarySlip(a);
            Console.ReadLine();
        }
        public static void SalarySlip(Employee e)
        {
            Console.WriteLine("\n" + e.GetType().Name);
            Console.WriteLine("-----------");
            Console.WriteLine("Employee No: {0}", e.EmpId);
            Console.WriteLine("Employee Name: {0}", e.EmpName);
            Console.WriteLine("Basic Salary: {0}", e.EmpBasicSalary);
            Console.WriteLine("Final Annual Salary: {0}", e.EmpFinalSalary);
            Console.WriteLine("Perks Added:");
            Console.WriteLine(e.ExtraPerksDetailsPrint());
        }         
    }
}
