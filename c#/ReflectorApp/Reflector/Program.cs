using System;


namespace Reflector
{
    class Program
    {
        static void Main()
        {
            Account account = new Account();
            Employe emp = new Employe();
            //DoReflection Method call
            Reflector r = new Reflector();
            r.DoReflection(typeof(Account));
        }     
    }
}
