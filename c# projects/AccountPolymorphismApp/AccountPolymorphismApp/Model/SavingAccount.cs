using System;


namespace AccountPolymorphismApp.Model
{
    class SavingAccount : Account
    {
        private double _amount;
        public SavingAccount(int accno,string name,double amount) : base(accno, name, amount)
        {
            Console.WriteLine("Saving Account");
        }
        public override void WithdrowAmount(double amount)
        {
            int MIN_BALANCE = 500;
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
