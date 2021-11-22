using System;


namespace AccountPolymorphismApp.Model
{
    class CurrentAccount : Account
    {
        private double _amount;
        public CurrentAccount(int accno,string name,double amount) : base(accno,name,amount)
        {
            Console.WriteLine("Current Account");
        }
        public override void WithdrowAmount(double amount)
        {
            int MIN_BALANCE = -5000;
            _amount = amount;
            double currentAmount = _balance;
            currentAmount -= amount;
            if (currentAmount < MIN_BALANCE)
            {

                Console.WriteLine("\nYou cant withdrow amount ");
            }
            else
            {
                _balance -= amount;
            }
        }

       
    }
}
