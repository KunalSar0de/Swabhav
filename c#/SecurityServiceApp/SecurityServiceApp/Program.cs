using System;
using SecurityServiceApp.Model;

namespace SecurityServiceApp
{
    class Program
    {
        static void Main()
        {
            SecurityService s = new SecurityService();
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                s.Login("k103", "sonu@123");
            }
            catch (InvalidUserException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
