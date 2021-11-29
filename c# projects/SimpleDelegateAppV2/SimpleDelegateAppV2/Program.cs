using System;

namespace SimpleDelegateAppV2
{
    class Program
    {
        delegate void DPrintMessege(string name);
        static void Main() 
        {
            DPrintMessege m;
            m = (n) =>
            {
                Console.WriteLine("Inside Lambda Function");
                Console.WriteLine("Kunal Saya " + n);
            };
            m("Hello");

            m = (n) =>Console.WriteLine("Ola says "+n);  
            m("Hello");

            Console.ReadKey();
        }
    }
}
