using System;


namespace ProxyDesignPatternApp.ExpensiveClass
{
    class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            Console.WriteLine("Loading "+fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying "+_fileName);
        }
    }
}
