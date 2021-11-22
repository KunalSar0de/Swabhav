using System;


namespace Reflector
{
    class Account
    {
        public int _id;
        private string _name;
        private float _amount;
        private double _loanAmout;

        public Account()
        {

        }
        public Account(int id,string name,float amount,double loanamt)
        {

        }
        public void CalculateLoan()
        {

        }

        public string GetName
        {
            get{
                return _name;
            }
        }
        public int GetId
        {
            get
            {
                return _id;
            }
        }
        public float GetAmount
        {
            get
            {
                return _amount;
            }
        }
        public double GetSalary
        {
            get
            {
                return _loanAmout;
            }
        }     
    }
    

    class Employe
    {
        private int _empID;
        private string _empName;
        private double _empSalary;

        public Employe()
        {

        }
        public Employe(int empid,string name,double salary)
        {

        }
        public void CalExperiance()
        {

        }
        public int CalExperiance(int age)
        {            
            return 0;
        }
        public int GetEmpId
        {
            get
            {
                return _empID;
            }
        }
        public string GetName
        {
            get
            {
                return _empName;
            }
        }
        public double GetEmpSalary
        {
            get
            {
                return _empSalary;
            }
        }

    }
}
