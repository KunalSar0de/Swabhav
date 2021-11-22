using System;


namespace SetGEnericApp.Model
{
    class Students
    {
        private int _roll;
        private string _name;
        private string _location;
        public Students(int rollno,string name,string location)
        {
            _roll = rollno;
            _name = name;
            _location = location;
        }
        public int Roll
        {
            get { return _roll; }
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
            return _roll;
        }
        public override bool Equals(object obj)
        {
            Students studentsObj = (Students)obj;
            if (this._roll == studentsObj._roll)
                return true;
            return false;
        }
        
    }
}
