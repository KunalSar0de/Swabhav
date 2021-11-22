using System;
using SimpleFactoryLib.Product;

namespace SimpleFactoryLib.Factory
{
    public class AutomobileFactory
    {
        private static AutomobileFactory _instance = null;
        private AutomobileFactory()
        {

        }
        public IAuto Make(AutoType autoType)
        {
            if (autoType == AutoType.BMW)
            {
                return new Bmw();
            }else if (autoType == AutoType.AUDI)
            {
                return new Audi();
            }
            else
            {
                return new Tesla();
            }
        }

        public static AutomobileFactory GetInstance()
        {
            
             if (_instance == null)
             {
                 _instance = new AutomobileFactory();
             }
             return _instance;
        }      
    
    }
}
