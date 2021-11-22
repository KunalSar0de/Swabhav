using FactoryMethodLib.Product;


namespace FactoryMethodLib.Factory
{
    public class AudiFactory : IAutoFactory
    {
        private static AudiFactory _instance;       
        private AudiFactory() { }
        public static IAutoFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AudiFactory();
            }
            return _instance;
        }
        
        public IAuto Make()
        {
            return new Audi();
        }
    }
}
