using System;
using System.Linq;
using System.Reflection;

namespace CustomAnnotationApp
{
    class Program
    {
        static void Main()
        {   
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyUnitTestClass>().Count() > 0);
            Console.WriteLine("Test Classes: {0}",types.Count());
            Console.WriteLine("----------------------------------");
            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
                var methods = t.GetMethods().Where(m => m.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
                Object DynamicObj = Activator.CreateInstance(t);
                Console.WriteLine("Test Cases: {0}",methods.Count());
                foreach (var m in methods)
                {
                    var foo = m.Invoke(DynamicObj, null);
                    if (foo.Equals(true))
                    {
                        Console.WriteLine("  "+m.ReturnType.Name + " : " + m.Name + "--> Passed");
                    }
                    else
                    {
                        Console.WriteLine("  "+m.ReturnType.Name + " : " + m.Name + "--> failed");
                    }
                    
                }
                Console.WriteLine("----------------------------------");
            }
              Console.ReadLine();
        }     
    }
}


