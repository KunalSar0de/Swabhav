
namespace SecurityServiceApp.Model
{
    class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;

        public User(int id,string fname,string lname,string email,string password)
        {
            _id=id;
            _firstName = fname;
            _lastName = lname;
            _email = email;
            _password = password;
        }
        public int Id
        {           
            get { return _id; }
            set { _id = value; }
        }
       public string FName
       {
            get { return _firstName; }
       }
        public string LName
        {
            get { return _lastName; }
        }
        public string Email
        {
            get { return _email; }
        }
        public string Password
        {
            get { return _password; }
        }
     
    }
}
