using System;


namespace CustomAnnotationApp
{
    [AttributeUsage( AttributeTargets.Class)]
    class MyUnitTestClass:Attribute
    {
        public string Name { get; set; }
    }
}
