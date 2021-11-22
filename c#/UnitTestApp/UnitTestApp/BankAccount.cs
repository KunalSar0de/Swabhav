using System;

namespace UnitTestApp
{
    public class BankAccount
    {

        public void IsPositiveNumber(double num)
        {
            if (num < 0 || num > 100)
            {
                throw new Exception("Number is Out of range");
            }
        }
    }
}
