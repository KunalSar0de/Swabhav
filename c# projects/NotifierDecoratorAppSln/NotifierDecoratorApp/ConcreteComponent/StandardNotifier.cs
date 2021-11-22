using NotifierDecoratorApp.Component;
using System;


namespace NotifierDecoratorApp.ConcreteComponent
{
    class StandardNotifier : INotifier
    {
        private Customer _customer;
        private INotifier _notifier;
        private string _msg;

        public StandardNotifier(Customer customer)
        {
            _customer = customer;
        }

        public string GetMessege()
        {
            return $"Notification send via";
        }

        public string SendMessege(string msg)
        {
            _msg = msg;
            return _msg;
        }
    }
}
