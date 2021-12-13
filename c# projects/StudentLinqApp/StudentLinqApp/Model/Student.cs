using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqApp.Model
{
    class Student
    {
        public Student()
        {}

        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double CGPA{ get; set; }       
        
    }
}
