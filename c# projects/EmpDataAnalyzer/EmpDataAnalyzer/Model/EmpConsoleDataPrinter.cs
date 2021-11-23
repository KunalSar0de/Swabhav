using System;
using System.Collections.Generic;

namespace EmpDataAnalyzer.Model
{
    class EmpConsoleDataPrinter
    {
        public void PrintEmployee(Employee employee)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\nEmployee Id\t\t\t: {0}", employee.ID);
            Console.WriteLine("Employee Name\t\t\t: {0}", employee.Name);
            Console.WriteLine("Employee Designation\t\t: {0}", employee.Designation);
            Console.WriteLine("Employee Manager Id\t\t: {0}", employee.ManagerID);
            Console.WriteLine("Employee Joining Date\t\t: {0}", employee.DateOfJoining);
            Console.WriteLine("Employee Salary\t\t\t: {0}", employee.Salary + " Rs");
            Console.WriteLine("Employee Commission\t\t: {0}", employee.Commission);
            Console.WriteLine("Employee Departmenet ID\t\t: {0}", employee.DepartmentNumber);
        }
        public void PrintDesignationWiseEmployeeFrequency(Dictionary<string,int> freqMap)
        {
            foreach (var keyvalue in freqMap)
            {
                Console.WriteLine($"Designation{keyvalue.Key} \t: {keyvalue.Value}");
            }
        }
        public void PrintDeptIdWiseEmployeeFrequency(Dictionary<int, int> freqMap)
        {
            foreach (var keyvalue in freqMap)
            {
                Console.WriteLine($"Department Id {keyvalue.Key} \t: {keyvalue.Value}");
            }
        }

    }
}
