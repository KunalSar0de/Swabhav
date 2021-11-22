using System;


namespace AccountSerializationApp.Model
{
    [Serializable]
    class Account
    {
        private readonly string _name;
        private readonly int _accountNum;
        private double _accountBalance = 0;
        private double _amount;
        private bool _isWithdrowError = false;

        public Account(string userName, int userAccNum, double userAccBal)
        {
            _name = userName;
            _accountNum = userAccNum;
            _accountBalance = userAccBal;
        }

        

        public double DepositAmt
        {
            set
            {
                _accountBalance += value;
            }
        }

        public double WithdrowAmt
        {
            set
            {
                _amount = value;
                double currentAmount = _accountBalance;
                currentAmount -= value;
                if (currentAmount < 500)
                {

                    _isWithdrowError = true;
                }
                else
                {
                    _accountBalance -= value;
                }
            }
        }

        public void WithdrowError()
        {
            Console.WriteLine("\nHey {0}...",GetName);
            Console.WriteLine("Amount {0} cannot be withdrow from your account!!", _amount);
            Console.WriteLine("Your Minimun account balance should be 500");
            Console.WriteLine("You can withdrow {0} only", GetBalance - 500);
        }

        public string GetName
        {
            get 
            { 
                return _name;
            }
        }

        public int GetAccountNum
        {
            get
            {
                return _accountNum; ;
            }           
        }

        public double GetBalance
        {
            get
            {
                return _accountBalance;
            }            
        }
        public bool GetWithdrowError
        {
            get
            {
                return _isWithdrowError;
            }
        }
    }
}
