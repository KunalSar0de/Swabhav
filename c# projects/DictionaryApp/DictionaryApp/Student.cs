using System;


namespace DictionaryApp
{
    class Student
    {
        private int _roll;
        private int _std;
        private string _name;
        private string _location;
        public Student(int roll,int std,string name,string location)
        {
            _roll = roll;
            _std = std;
            _name = name;
            _location = location;
        }
        public int Roll
        {
            get { return _roll; }
        }
        public int Std
        {
            get { return _std; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Location
        {
            get { return _location; }
        }

        public override int GetHashCode()
        {
            string hash = Convert.ToString(_roll) + Convert.ToString(_std);
            return int.Parse(hash);
        }
        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._roll == studentObj._roll && this._std == studentObj._std)
                return true;
            return false;
        }
    }
}
