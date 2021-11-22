using FactoryMethodLib.Product;
using System;
namespace FactoryMethodLib.Factory
{
    public class TeslaFactory : IAutoFactory
    {
        private static TeslaFactory _instance;
        private TeslaFactory() { }

        public  static IAutoFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TeslaFactory();
            }
            return _instance;
        }
        
        public IAuto Make()
        {
            return new Tesla();
        }    }
}
