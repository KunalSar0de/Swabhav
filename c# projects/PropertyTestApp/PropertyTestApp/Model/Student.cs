using System;


namespace PropertyTestApp.Model
{
    //ReadWrite Properties
    class Student
    {
        private string _code;
        private string _name;
        private int _age;

        public Student(string userCode, string userName, int userAge)
        {
            Code = userCode;
            Name = userName;
            Age = userAge;
        }

        //property of type string for code
        public string Code
        {           
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        //property of type string for name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }                       
        }

        //property of type int for age
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

    }
//ReadOnly Properties
    class Student1
    {
        public readonly string _code;
        public readonly string _name;
        public readonly int _age;

        public Student1()
        {
            _code = "102";
            _name = "sohan";
            _age = 20;
        }      
    }
}
