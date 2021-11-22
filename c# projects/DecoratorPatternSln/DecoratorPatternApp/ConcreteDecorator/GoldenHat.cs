using DecoratorPatternApp.Component;
using DecoratorPatternApp.Decorator;

namespace DecoratorPatternApp.ConcreteDecorator
{
    class GoldenHat:HatDecorator
    {
        
        public GoldenHat(IHat hat):base(hat){}

        public override string GetDiscription()
        {
            string hatType = base.GetDiscription();
            hatType += " Golden";
            return hatType;              
        }
        public override double GetPrice()
        {
            double price = base.GetPrice();
            price += 200;
            return price;
        }
    }
}
