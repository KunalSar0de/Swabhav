using System;

namespace AccountCustomExceptionApp.Model
{
   
    class InsufficientFundsException:Exception
    {
        private string _messege;
        public InsufficientFundsException(Account acc,double withdrowamount)
        {
            _messege=$"Insuffucient funds in account { acc.AccNo}!!\n You are trying to withdrow {withdrowamount}\nyou can withdrow {acc.Balance-500} only \nTransaction Declined!!";
        }
        public override string Message
        {
            get
            {
                return _messege;
            }
        }
    }
}
