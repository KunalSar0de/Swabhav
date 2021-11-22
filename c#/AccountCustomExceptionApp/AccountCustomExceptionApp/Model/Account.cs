using System;


namespace AccountCustomExceptionApp.Model
{
    class Account
    {
        private int _accNo;
        private string _name;
        private double _balance;
        public Account(int accNo,string name,double amount)
        {
            _accNo = accNo;
            _name = name;
            _balance = amount;
        }

        public void DepositAmt(double amount)
        {
            _balance += amount;
        }

        public void WithdrowAmt(double amount)
        {
            
            if (_balance - amount < 500)
                throw new InsufficientFundsException(this,amount);
            _balance -= amount;
        }
        public int AccNo
        {
            get { return _accNo; }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Balance
        {
            get { return _balance; }
        }

    }
}
