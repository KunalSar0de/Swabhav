using System;


namespace StudentProfessorApp.Model
{
   abstract class SalariedEmp:Person
   {
        private double _basicSalary;
        public SalariedEmp(int id,string add,string dob, double basicsalary):base(id,add,dob,basicsalary)
        {
            _basicSalary = basicsalary;
        }
        public abstract double CalcSalary();
        

    }
}
