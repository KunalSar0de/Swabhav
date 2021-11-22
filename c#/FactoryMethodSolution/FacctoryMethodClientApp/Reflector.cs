using System;
using FactoryMethodLib.Factory;
using FactoryMethodLib.Product;
using System.Reflection;
using System.Configuration;

namespace FacctoryMethodClientApp
{
    class Reflector
    {
        public  IAutoFactory GetFactory()
        {
            string AppConfigInput = ConfigurationManager.AppSettings["factory"];
            string[] libAndClassName = AppConfigInput.Split(',');
            Assembly assembly = Assembly.Load(libAndClassName[0]);
            Type type = assembly.GetType(libAndClassName[1]);
            IAutoFactory factory = type.InvokeMember("GetInstance",BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public  , null, null, null) as IAutoFactory;
            return factory;
        }
    }
}
