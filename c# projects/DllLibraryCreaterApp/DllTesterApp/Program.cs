using System;
using Ownlibrary;

namespace DllTesterApp
{
    class Program
    {
        static void Main()
        {
            int a = 400, b = 300;
            Console.WriteLine("Library Check:");
            double add = Functions.Add(a, b);
            Console.WriteLine("Addition of two no: {0}", add);
            double sub = Functions.Subtract(a, b);
            Console.WriteLine("Subtraction of two no: {0}", sub);
            string oddOrEven = Functions.IsEvenOrOdd(19);
            Console.WriteLine("Odd or even check: {0}", oddOrEven);
            string primeOrNot = Functions.IsPrimeOrNonPrime(19);
            Console.WriteLine("Prime or Non prime check: {0}", primeOrNot);
            float rem = Functions.Remainder(a, b);
            Console.WriteLine("Remainder of number: {0}", rem);
            Console.ReadLine();
        }
    }
}
