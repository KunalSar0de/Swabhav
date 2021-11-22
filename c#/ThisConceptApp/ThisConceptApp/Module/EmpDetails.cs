using System;

namespace ThisConceptApp.Module
{
    class EmpDetails
    {
        private string name;
        private int age;
 

        public EmpDetails(EmpDetails e)
        {
            name = e.name;
            age = e.age;
        }

        public EmpDetails(string name, int age)
        {
            this.name = name;
            this.age= age;
        }

        public string Details
        {
            get
            {
                return "Emp name:" + this.name + " and Emp age:"+this.age;
            }
        }

    }
}
