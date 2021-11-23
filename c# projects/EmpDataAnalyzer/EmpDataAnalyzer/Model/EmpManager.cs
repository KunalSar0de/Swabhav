using System.Collections.Generic;


namespace EmpDataAnalyzer.Model
{
    class EmpManager
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            if (!ListOfEmp.Contains(employee))
            {
                ListOfEmp.Add(employee);
            }          
        }
       
        public Employee MaxSalaryEmployee()
        {
            Employee maximumSalariedEmp = ListOfEmp[0];
            foreach (var employee in ListOfEmp)
            {
                if (employee.Salary > maximumSalariedEmp.Salary)
                {
                    maximumSalariedEmp = employee;
                }             
            }
            return maximumSalariedEmp;
        }

        //frequency calculation using designation
        public Dictionary<string,int> DesignationWiseFrequency()
        {
            Dictionary<string, int> Map = new Dictionary<string, int>();
            int counter = 0;
            foreach (var employee in ListOfEmp)
            {
                if (!Map.ContainsKey(employee.Designation))
                {
                    Map.Add(employee.Designation,counter);
                }
                if (Map.ContainsKey(employee.Designation))
                {
                    Map.TryGetValue(employee.Designation, out counter);
                    Map[employee.Designation] = counter + 1;
                }
            }
            return Map;
        }

        //frequency calculation using department id
        public Dictionary<int, int> DepartmentIdWiseFrequency()
        {
            Dictionary<int, int> Map = new Dictionary<int, int>();
            foreach (var employee in ListOfEmp)
            {
                if (!Map.ContainsKey(employee.DepartmentNumber))
                {
                    Map.Add(employee.DepartmentNumber, EmpCounterForEachJob(employee.DepartmentNumber));
                }
            }
            return Map;
        }

        private int EmpCounterForEachJob(int depId)
        {
            List<Employee> designationList = new List<Employee>();
            foreach (var employee in ListOfEmp)
            {
                if (employee.DepartmentNumber == depId)
                {
                    designationList.Add(employee);
                }
            }
            return designationList.Count;
        }

        public List<Employee> ListOfEmp 
        { 
            get 
            {
                return _employees; 
            }            
        }
    }
}
