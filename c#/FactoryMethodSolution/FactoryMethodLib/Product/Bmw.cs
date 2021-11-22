using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class Bmw : IAuto
    {
        public void Start()
        {
            Console.WriteLine("BMW started");
        }

        public void Stop()
        {
            Console.WriteLine("BMW stop");
        }
    }
}
