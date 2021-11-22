using System;
using NotifierDecoratorApp.Component;

namespace NotifierDecoratorApp.Decorator
{
    class FacebookNotifier : INotifier
    {
        private INotifier _notifier;
        private string _msg;
        public FacebookNotifier(INotifier notifier)
        {
            _notifier = notifier;
        }

        public string GetMessege()
        {
            return _notifier.GetMessege()+" facebook";
        }

        public string SendMessege(string msg)
        {
            _msg = msg;
            return $"SMS notification : {_msg}";
        }
    }
}
