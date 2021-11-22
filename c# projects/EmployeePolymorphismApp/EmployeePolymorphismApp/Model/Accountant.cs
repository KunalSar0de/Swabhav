using System;

namespace EmployeePolymorphismApp.Model
{
    class Accountant:Employee
    {
        public Accountant(int empno, string name, double basicsalary) : base(empno, name, basicsalary)
        {

        }


        public override void PerkCalculator(double abasicsalary)
        {
            _perks =  _basicSalary*30 / 100;
            _finalSalary = _basicSalary + _perks;
        }
        public override string ExtraPerksDetailsPrint()
        {
            Console.WriteLine("-->Perk:{0}", _perks);
            return string.Empty;
        }
    }
}
