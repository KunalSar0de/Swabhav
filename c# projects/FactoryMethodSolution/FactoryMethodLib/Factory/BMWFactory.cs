using FactoryMethodLib.Product;
using System;

namespace FactoryMethodLib.Factory
{

    public class BMWFactory : IAutoFactory
    {
        private static BMWFactory _instance ;
        
        public static IAutoFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BMWFactory();
            }
            return _instance;
        }    
            

        public IAuto Make()
        {
            return new Bmw();
        }
    }
}
