using System;


namespace AccountEqualityApp.Model
{
    class Account
    {
        private int _accNo;
        private string _name;
        private double _amt;
     


        static Account()
        {
          
        }
        public Account(int accno,string name, double amt)
        {
            _accNo = accno;
            _name = name;
            _amt = amt;                  
        }

        public int GetAccNo
        {
            get
            {
                return _accNo;
            }
        }
        public string GetName
        {
            get
            {
                return _name;
            }
        }
        public double GetAmt
        {
            get
            {
                return _amt;
            }
        }

        public override string ToString()
        {            
            string reString ="Child--> Name: " + this.GetName + ", Acc No: " + this.GetAccNo + ", Amount: " + this.GetAmt;
            return reString+"\nParent-->"+ base.ToString();
        }
        public override bool Equals(object obj)
        {                
            return (obj is Account) && ((Account)obj)._accNo == _accNo;             
        }
    }
}

