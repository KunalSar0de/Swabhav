using NotifierDecoratorApp.Component;

namespace NotifierDecoratorApp.Decorator
{
    class WpNotifier : INotifier
    {
        private INotifier _notifier;
        private string _msg;
        public WpNotifier(INotifier notifier)
        {
            _notifier = notifier;
        }

        public string GetMessege()
        {
            return _notifier.GetMessege() + " Whatsapp";
        }

        public string SendMessege(string msg)
        {
            _msg = msg;
            return $"SMS notification : {_msg}";
        }
    }
}
