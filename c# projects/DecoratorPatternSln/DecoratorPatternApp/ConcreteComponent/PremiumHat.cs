using DecoratorPatternApp.Component;

namespace DecoratorPatternApp.ConcreteComponent
{
    class PremiumHat : IHat
    {
        public string GetDiscription()
        {
            return "premium";
        }
        public string GetName()
        {
            return "Premium Hat";
        }
        public double GetPrice()
        {
            return 200;
        }
    }
}
