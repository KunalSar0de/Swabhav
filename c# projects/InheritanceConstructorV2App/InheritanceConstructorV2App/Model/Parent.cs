using System;


namespace InheritanceConstructorV2App.Model
{
    class Parent
    {
        private int _foo;
        public Parent(int foo)
        {
            _foo = foo;
        }
        public int GetFoo
        {      
            get
            {
                return _foo;
            }
        }
    }
}
