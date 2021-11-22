using DecoratorPatternApp.Component;
using DecoratorPatternApp.Decorator;

namespace DecoratorPatternApp.ConcreteDecorator
{
    class RibbonHat:HatDecorator
    {
        public IHat _hat;

        public RibbonHat(IHat hat) : base(hat)
        {
            _hat = hat;
        }

        public override string GetDiscription()
        {
            string hatType = base.GetDiscription();
            hatType += " Ribbon";
            return hatType;
        }
        public override double GetPrice()
        {
            double price = base.GetPrice();
            price += 100;
            return price;
        }
    }
}
