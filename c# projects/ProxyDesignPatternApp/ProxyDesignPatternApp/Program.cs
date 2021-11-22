using System;
using ProxyDesignPatternApp.ExpensiveClass;
using ProxyDesignPatternApp.Proxy;
using ProxyDesignPatternApp.Proxy;

namespace ProxyDesignPatternApp
{
    class Program
    {
        static void Main()
        {
            Case2();
            Console.ReadKey();
        }
        public static void Case1()
        {
            Console.WriteLine("Case1:");
            IImage image = new RealImage("img1.png");
            IImage image2 = new RealImage("img2.png");
            image.Display();
        }
        public static void Case2()
        {
            Console.WriteLine("Case2:");
            IImage image1 = new ProxyImage("img1.png");
            IImage image2 = new ProxyImage("img2.png");
            IImage image3 = new ProxyImage("img3.png");
            image1.Display();
            image3.Display();
        }
    }
}
