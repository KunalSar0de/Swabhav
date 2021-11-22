using System;


namespace IdApp.Model
{    
    class Customer
    {
        private string _id;
        private string _name;
        private float _amt;
        private static int _instanceCount;
        
        
        static Customer()
        {
            _instanceCount = 1001; 
        }
        public Customer(string name, float amt)
        {
            _name = name;
            _amt = amt;
            _id = "c" + _instanceCount;
            _instanceCount += 1;
        }

        public string InstanceCount
        {
            get
            {                             
                return _id;
            }
        }
        public string GetName
        {
            get
            {
                return _name;
            }
        }
        public float GetAmt
        {
            get
            {
                return _amt;
            }
        }
    }
}
