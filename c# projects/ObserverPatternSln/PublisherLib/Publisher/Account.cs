using System;
using System.Collections.Generic;


namespace PublisherLib.Publisher
{
    public class Account
    {
        private string _name;
        private int _accNumber;
        private double _accBalance;
        private List<INotifier> _notifiers = new List<INotifier>();

        public Account(int userAccNum, string userName , double userAccBal)
        {
            _name = userName;
            _accNumber = userAccNum;
            _accBalance = userAccBal;
        }

        public void DepositAmt(double amount)
        {
            _accBalance += amount;
            NotifySubscriber();
        }

        public void WithdrowAmt(double amount)
        {            
            double currentAmount = _accBalance;
            currentAmount -= amount;
            if (currentAmount < 500)
            {
                throw new Exception();                  
            }
            else
            {
                _accBalance -= amount;
                NotifySubscriber();
            }
        }
        public void AddNotifier(INotifier notifier)
        {
            _notifiers.Add(notifier);
        }
        private void NotifySubscriber()
        {
            foreach (var notifier in _notifiers)
            {
                notifier.Notify(this);
            }
        }

        public int AccNo
        {
            get { return _accNumber; }
        }
        public string AccName
        {
            get { return _name; }

        }
        public double AccBalance
        {
            get { return _accBalance; }
        }
    }
}
