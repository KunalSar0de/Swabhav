using System;


namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        protected int _accNo;
        protected string _name;
        protected double _balance;

        public Account (int accno,string name,double balance)
        {
            _accNo = accno;
            _name = name;
            _balance = balance;
        }
        public void DepositAmount(double amount)
        {
            _balance += amount;
        }
        public abstract void WithdrowAmount(double amount);
        
        public  int AccNo
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
