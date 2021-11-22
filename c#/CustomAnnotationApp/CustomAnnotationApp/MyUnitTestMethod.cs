using System;


namespace CustomAnnotationApp
{
    [AttributeUsage(AttributeTargets.Method)]
    class MyUnitTestMethod:Attribute
    {
        public string Name { get; set; }
    }
}
