using System;


namespace EmployeePolymorphismApp.Model
{
    class Manager : Employee
    {
        public Manager(int accno, string name, double basicsalary) : base(accno, name, basicsalary)
        {
        }
        public override void PerkCalculator(double abasicsalary)
        {
            _hra = _basicSalary * 50 / 100;
            _ta = _basicSalary * 40 / 100;
            _da = _basicSalary * 30 / 100;
            _finalSalary = _hra + _ta + _da + _basicSalary;
        }
        public override string ExtraPerksDetailsPrint()
        {
            Console.WriteLine("-->HRA:{0}", _hra);
            Console.WriteLine("-->TA:{0}", _ta);
            Console.WriteLine("-->DA:{0}", _da);
            return string.Empty;
        }
    }
}
