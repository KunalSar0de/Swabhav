using System;


namespace CustomAnnotationApp
{
   [MyUnitTestClass]
    class Foo
    {
        [MyUnitTestMethod]
        public bool M1()
        {
            return true;
        }
        public bool M2()
        {
            return true;
        }
        [MyUnitTestMethod]
        public bool M3()
        {
            return true;
        }
        public bool M4()
        {
            return true;
        }
        
        public bool M5()
        {
            return true;
        }
        
        public bool M6()
        {
            return false;
        }

    }
}
 