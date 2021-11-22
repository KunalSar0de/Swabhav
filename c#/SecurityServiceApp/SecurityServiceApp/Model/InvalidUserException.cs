using System;

namespace SecurityServiceApp.Model
{
    class InvalidUserException:Exception
    {
        private string _messege;
        public InvalidUserException(string id)
        {
            _messege = "Wrong User Credentials!!Retry Again!!";
        }
        public override string Message
        {
            get
            {
                return _messege;
            }
        }
    }
}
