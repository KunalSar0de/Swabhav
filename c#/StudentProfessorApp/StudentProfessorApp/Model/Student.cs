using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp.Model
{
    class Student : Person
    {
        private string _branch;

        public Student(int id,string add,string dob,string branch):base(id,add,dob,branch) {
            _branch = branch;
        }
        public string Branch
        {
            get { return _branch; }
        }

        public override string ExtraThings()
        {
            Console.WriteLine($"Branch: {_branch}");
            return string.Empty;
        }
    }
}
