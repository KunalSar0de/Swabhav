using System;
using EmployeeDataAnalyzerApp.Model;
using System.Configuration;
namespace EmployeeDataAnalyzerApp
{
    class Program
    {
        static void Main()
        {
            string SourcePath = ConfigurationManager.AppSettings["filePath"];
            EmployeeManager empManager = new EmployeeManager();
            EmployeeFileDataReader reader = new EmployeeFileDataReader();            
            reader.FileReader(empManager, SourcePath);
            Console.WriteLine("Employee Having Maximum Salary:");
            var employeePrinter = new EmployeePrinter();
            employeePrinter.PrintEmployee(empManager.MaxSalaryEmployee());
            //frequency map          
            FrequencyMap(empManager,"'ANALYST'",20);
            Console.ReadKey();
        }
        public static void FrequencyMap(EmployeeManager employee,string designation,int deparmentId) 
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Frequency Map:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Department Name : {0}",designation);
            Console.WriteLine("Department Id : {0}", deparmentId);
            Console.WriteLine("Number of employees : {0}",employee.EmpBasedOnDepAndDesignation(deparmentId,designation));
        }
    }
}
