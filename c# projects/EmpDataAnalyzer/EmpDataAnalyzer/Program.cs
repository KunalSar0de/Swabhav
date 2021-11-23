using System;
using System.Configuration;
using EmpDataAnalyzer.Model;

namespace EmpDataAnalyzer
{
    class Program
    {
        static void Main()
        {
            string SourcePath = ConfigurationManager.AppSettings["filePath"];
            EmpManager empManager = new EmpManager();
            EmpFileDataReader reader = new EmpFileDataReader();
            Console.WriteLine("-->Using file\n");
            reader.FileReader(empManager, SourcePath);
            Console.WriteLine("Employee Having Maximum Salary:");
            var employeePrinter = new EmpConsoleDataPrinter();
            employeePrinter.PrintEmployee(empManager.MaxSalaryEmployee());      
            FrequencyMap(empManager);

            /*EmpManager empMan = new EmpManager();
            Console.WriteLine("\n-->Using web\n");
            EmpWebDataReader dataReader = new EmpWebDataReader();
            dataReader.WebReader(empMan);
            Console.WriteLine("Employee Having Maximum Salary:");            
            employeePrinter.PrintEmployee(empMan.MaxSalaryEmployee());
            //frequency map          
            FrequencyMap(empMan);*/

            Console.ReadKey();
        }
        public static void FrequencyMap(EmpManager employee)
        {
            var employeePrinter = new EmpConsoleDataPrinter();
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Frequency Map Using Designation:");
            Console.WriteLine("-----------------------------------------------");
            employeePrinter.PrintDesignationWiseEmployeeFrequency(employee.DesignationWiseFrequency());

            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Frequency Map Using Department Id:");
            Console.WriteLine("-----------------------------------------------");
            employeePrinter.PrintDeptIdWiseEmployeeFrequency(employee.DepartmentIdWiseFrequency());
        }
    }
}
