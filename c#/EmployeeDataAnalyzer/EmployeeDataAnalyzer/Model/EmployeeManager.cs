using System.Collections.Generic;

namespace EmployeeDataAnalyzerApp.Model
{
    public class EmployeeManager
    {
        private readonly List<Employee> _employees = new List<Employee>();
        
        public void AddEmployee(Employee employee)
        {
            if (!CheckIfEmployeeAlreadyPresent(employee)) 
                Employees.Add(employee);
        }

        private bool CheckIfEmployeeAlreadyPresent(Employee employee)
        {
            if (Employees.Contains(employee)) 
                return true;
            return false;
        }
        public Employee MaxSalaryEmployee()
        {
            Employee maximumSalary = Employees[0];
            foreach (var employee in Employees)
            {
                if (employee.Salary > maximumSalary.Salary)
                    maximumSalary = employee;
            }
            return maximumSalary;
        }
        public int EmpBasedOnDesignation(string designation)
        {
            List<Employee> empDesignation = new List<Employee>();
            foreach(var employee in Employees)
            {
                if (employee.Designation.ToLower() == designation.ToLower()) 
                    empDesignation.Add(employee);
            }
            return empDesignation.Count;
        }
        public int EmpBasedOnDepartment(int depNumber)
        {
            List<Employee> employees = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.DepartmentNumber==depNumber) 
                    employees.Add(employee);
            }
            return employees.Count;
        }
        
        public int EmpBasedOnDepAndDesignation(int deptNumber,string designation)
        {
            List<Employee> employees = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.DepartmentNumber == deptNumber&& 
                    employee.Designation.ToLower() == designation.ToLower()) 
                    employees.Add(employee);
            }
            return employees.Count;
        }
        public List<Employee> Employees { get { return _employees; } }
    }
}
