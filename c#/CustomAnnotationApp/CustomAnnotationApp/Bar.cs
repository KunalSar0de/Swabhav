using System;


namespace CustomAnnotationApp
{
    [MyUnitTestClass]
    class Bar
    {
        [MyUnitTestMethod]
        public bool B1()
        {
            return false;
        }
  
        public bool B2()
        {
            return false;
        }
        
        public bool B3()
        {
            return false;
        }
    }
}
