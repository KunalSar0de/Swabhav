using DecoratorPatternApp.Component;
using System;

namespace DecoratorPatternApp.ConcreteComponent
{
    class StandardHat : IHat
    {
        public string GetDiscription()
        {
            return "Standard";
        }

        public string GetName()
        {
            return "Standard Hat";
        }

        public double GetPrice()
        {
            return 100;
        }
    }
}
