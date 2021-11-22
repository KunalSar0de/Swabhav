using System;
using System.Reflection;

namespace Reflector
{
    class Reflector
    {
        public void DoReflection(Type t)
        {
            Type T = Type.GetType(t.ToString());
            Console.WriteLine("==>Full Name: {0}", T.FullName);
            Console.WriteLine("==>Class Name: {0}", T.Name);
            //For fields
            FieldInfo[] fields = T.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("\n==>Fields:");
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.FieldType.Name + " : " + field.Name);
            }
            //For Constructor
            ConstructorInfo[] constructors = T.GetConstructors();
            Console.WriteLine("\n==>Constructor:");
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            //For Methods
            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine("\n==>Methods:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " : " + method.Name);
            }
            //For Property
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine("\n==>Properties:");
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.PropertyType.Name + " : " + prop.Name);
            }
            Console.ReadKey();
        }
    }
}
