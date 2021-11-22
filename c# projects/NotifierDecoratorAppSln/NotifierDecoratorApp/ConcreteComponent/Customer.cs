
namespace NotifierDecoratorApp.ConcreteComponent
{
    class Customer
    {
        private int _id;
        private string _name;
        private string _mobNumber;
        private string _wpNumber;
        private string _fbId;
        public Customer(int id,string name,string mobileNumber, string wpNumber,string fbId)
        {
            _id = id;
            _name = name;
            _mobNumber=mobileNumber;
            _wpNumber = wpNumber;
            _fbId = fbId;
        }
        public int CustomerId
        {
            get { return _id; }
        }
        public string CustomerName
        {
            get { return _name; }
        }
        public string CustomerMobNum
        {
            get { return _mobNumber; }
        }
        public string CustomerWpNum
        {
            get { return _wpNumber; }
        }
        public string CustomerFbId
        {
            get { return _fbId ; }
        }
    }
}
