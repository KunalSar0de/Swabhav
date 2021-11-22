namespace EmployeeDataAnalyzerApp.Model
{
    public class Employee
    {
        private int _empId;
        private string _empName;
        private string _empDesignation;
        private int _empManagerId;
        private string _empDateOfJoining;
        private double _empSalary;
        private double _empCommission;
        private int _empDeptNumber;
        public Employee(int empId,string empName,string empDesignation,int empManager,string empDateofJoin,double salary,double empCommision, int empDept)
        {
            _empId = empId;
            _empName = empName;
            _empDesignation = empDesignation;
            _empManagerId = empManager;
            _empDateOfJoining = empDateofJoin;
            _empSalary = salary;
            _empCommission = empCommision;
            _empDeptNumber = empDept;
        }
        public int ID 
        { 
            get { return _empId; }
        }
        public string Name 
        { 
            get { return _empName; } 
        }
        public string Designation 
        { 
            get { return _empDesignation; } 
        }
        public int ManagerID 
        { 
            get { return _empManagerId; } 
        }
        public string DateOfJoining 
        { 
            get { return _empDateOfJoining; } 
        }
        public double Salary 
        { 
            get { return _empSalary; } 
        }
        public double Commission 
        { 
            get { return _empCommission; } 
        }
        public int DepartmentNumber 
        { 
            get { return _empDeptNumber; } 
        }
        public override int GetHashCode()
        {
            return _empId;
        }
        public override bool Equals(object obj)
        {
            Employee emp = (Employee)obj;
            if (this.ID == emp.ID) 
                return true;
            return false;
        }
    }
}
