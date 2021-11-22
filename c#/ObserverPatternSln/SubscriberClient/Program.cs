using System;
using PublisherLib.Publisher;
using SubscriberClient.Subscriber;

namespace SubscriberClient
{
    class Program
    {
        static void Main()
        {
            Account acc1 = new Account(101, "kunal", 5000);
            acc1.AddNotifier(new SmsNotifier());           
            acc1.AddNotifier(new EmailNotifier());
            acc1.AddNotifier(new WpNotifier());
            acc1.DepositAmt(1000);
            //acc1.WithdrowAmt(5501);
            Console.ReadKey();
        }
    }
}
