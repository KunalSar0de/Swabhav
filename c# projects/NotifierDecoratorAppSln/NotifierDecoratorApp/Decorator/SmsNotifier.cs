using System;
using NotifierDecoratorApp.Component;
namespace NotifierDecoratorApp.Decorator
{
    class SmsNotifier : INotifier
    {
        private INotifier _notifier;
        private string _msg;

        public SmsNotifier(INotifier notifier)
        {
            _notifier = notifier;
        }

        public string GetMessege()
        {
            return _notifier.GetMessege() + " SMS";
        }

        public string SendMessege(string msg)
        {
            _msg = msg;
            return $"SMS notification : {_msg}";
        }       
    }
}
