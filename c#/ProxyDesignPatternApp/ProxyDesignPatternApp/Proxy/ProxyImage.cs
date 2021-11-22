using ProxyDesignPatternApp.ExpensiveClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternApp.Proxy
{
    class ProxyImage : IImage
    {
        private string _fileName;
        private RealImage _realImage;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }
        public void Display()
        {
            if (_realImage == null)
                _realImage= new RealImage(_fileName);
            _realImage.Display();

        }
    }
}
