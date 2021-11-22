

namespace StudentProfessorApp.Model
{
    abstract class Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;

        public Person(int id,string add,string dob)
        {
            _id = id;
            _address = add;
            _dateOfBirth = dob;
        }
        public Person(int id, string add, string dob, string branch)
        {
            _id = id;
            _address = add;
            _dateOfBirth = dob;
        }
        public Person(int id, string add, string dob, double basicSalery)
        {
            _id = id;
            _address = add;
            _dateOfBirth = dob;
        }
        public int Id
        {
            get { return _id; }
        }
        public string Address
        {
            get { return _address; }
        }
        public string DOB
        {
            get { return _dateOfBirth; }
        }
        public abstract string ExtraThings();
    }

}
