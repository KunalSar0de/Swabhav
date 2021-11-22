using FactoryMethodLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    
    public class JaguarFactory : IAutoFactory
    {
        private static JaguarFactory _jaguarInstance ;
        
        public static IAutoFactory GetInstance()
        {
            if (_jaguarInstance == null)
            {
                _jaguarInstance = new JaguarFactory();
            }
            return _jaguarInstance;
        }
       
        public IAuto Make()
        {
            return new Jaguar(); ;
        }
    }
}
