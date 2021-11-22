using System;


namespace EmployeePolymorphismApp.Model
{
    class Developer:Employee
    {
        public Developer(int empno,string name,double basicsalary) : base(empno,name,basicsalary)
        {

        }


        public override void PerkCalculator(double abasicsalary)
        {
            _pa = _basicSalary*40/100;
            _ot = _basicSalary*30/100;

            _finalSalary =_basicSalary + _pa + _ot;
        }
        public override string ExtraPerksDetailsPrint()
        {
            Console.WriteLine("-->PA:{0}", _pa);
            Console.WriteLine("-->OT:{0}", _ot);
            return string.Empty;
        }
    }
}
