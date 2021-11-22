using System;


namespace EmployeePolymorphismApp.Model
{
    abstract class Employee
    {
        protected int _empNo;
        protected string _name;
        protected double _basicSalary;
        protected double _finalSalary;
        protected double _hra;
        protected double _ta;
        protected double _da;
        protected double _pa;
        protected double _ot;
        protected double _perks;


        public Employee(int empno,string name,double basicsalary) {
            _empNo = empno;
            _name = name;
            _basicSalary = basicsalary;
            PerkCalculator(basicsalary);
           
        }

        public int EmpId
        {
            get
            {
                return _empNo;
            }
        }
        public string EmpName
        {
            get
            {
                return _name;
            }
        }
  
        public abstract void PerkCalculator(double basicsalary);

        public abstract string ExtraPerksDetailsPrint();

       

        public double EmpBasicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
        public double EmpFinalSalary
        {
            get
            {
                return _finalSalary;
            }
        }
        public double HRA
        {
            get
            {
                return _hra;
            }
        }
        public double DA
        {
            get
            {
                return _da;
            }
        }
        public double TA
        {
            get
            {
                return _ta;
            }
        }
        public double OT
        {
            get
            {
                return _ot;
            }
        }
        public double PA
        {
            get
            {
                return _pa;
            }
        }
        public double PERKS
        {
            get
            {
                return _perks;
            }
        }

    }
}
