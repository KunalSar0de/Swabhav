using NotifierDecoratorApp.Component;
using NotifierDecoratorApp.ConcreteComponent;
using NotifierDecoratorApp.Decorator;
using System;

namespace NotifierDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(101,"kunu","9769529896","9284948669","sohansar99");
            INotifier notifier = new FacebookNotifier(new SmsNotifier(new WpNotifier(new StandardNotifier(c))));
            notifier.SendMessege("Hello World");
            Console.WriteLine(notifier.GetMessege());
            Console.ReadKey();

        }
    }
}
