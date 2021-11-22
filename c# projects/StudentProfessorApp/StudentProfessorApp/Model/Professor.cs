using System;


namespace StudentProfessorApp.Model
{
    class Professor : SalariedEmp
    {
        private double _bonus;
        private double _totalSalery;
        private double _basicSalary;
        public Professor(int id, string add, string dob,double basicsalary) : base(id,add,dob,basicsalary)
        {
            _bonus = 50;
            _basicSalary = basicsalary;
        }
        
        public double TotalSalary
        {
            get { return _totalSalery; }
        }

        public override double CalcSalary()
        {
            double initialSalry =( _bonus /100) *_basicSalary;
            _totalSalery = initialSalry + _basicSalary;
            return _totalSalery;
        }
        public override string ExtraThings()
        {
            Console.WriteLine($"Total Salary: {CalcSalary()}");
            return string.Empty;
        }
    }
}
