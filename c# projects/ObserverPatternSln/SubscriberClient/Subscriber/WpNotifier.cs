using System;
using PublisherLib.Publisher;

namespace SubscriberClient.Subscriber
{
    class WpNotifier : INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("\nWhatsapp Notification Send...");
            Console.WriteLine("Acc no : {0}\nName : {1}" +
                "\nAcc Balance : {2} ",account.AccNo,account.AccName,account.AccBalance);
        }
    }
}
