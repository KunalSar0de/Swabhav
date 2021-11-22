using System;


namespace InheritanceConstructorV2App.Model
{
    class Child:Parent
    {
        public Child():base(100)
        {
            
        }
        public Child(int foo) :base(foo)
        {

        }
    }
}
