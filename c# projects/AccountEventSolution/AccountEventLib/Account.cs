using System;


namespace AccountEventLib
{
    public delegate void DBalanceChange(Account account);

    public class Account
    {
        private int _id;
        private string _name;
        private double _balance;
        public Account(int id,string name,double balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }
        public void DepositAmount(double amt)
        {
            _balance += amt;
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(this);
            }
        }
        public void WithrowAmount(double amt)
        {
            if (_balance < 500)
            {
                Console.WriteLine("cant withdrow");
            }
            else
            {
                _balance -= amt;
            }
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(this);
            }
        }
        public event DBalanceChange OnBalanceChanged = null;

        public int AccNo
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double AccBalance
        {
            get
            {
                return _balance;
            }
        }
    }
}
