using DecoratorPatternApp.Component;

namespace DecoratorPatternApp.Decorator
{
    abstract class HatDecorator:IHat
    {
        private IHat _hat;
        public HatDecorator(IHat hat)
        {
            _hat= hat;
        }
        public virtual string GetDiscription()
        {
            return _hat.GetDiscription();
        }
        public string GetName()
        {
            return _hat.GetName();
        }
        public virtual double GetPrice()
        {
            return _hat.GetPrice();
        }
    }
}
