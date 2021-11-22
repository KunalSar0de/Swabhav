using System;


namespace InheritanceConstructorV1App.Model
{
    class ChildClass:ParentClass
    {
        public ChildClass():base()
        {
            Console.WriteLine( "Child created...");
        }
    }
}
