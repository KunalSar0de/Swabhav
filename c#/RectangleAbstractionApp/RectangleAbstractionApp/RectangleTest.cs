using System;
using RectangleAbstractionApp.Model;
namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle smallRect;
            Rectangle bigRect;
            //object creation
            smallRect = new Rectangle();
            bigRect = new Rectangle();
            //value assignment
            smallRect.widthRect = 5;
            smallRect.heightRect = 6;
            bigRect.widthRect = 120;
            bigRect.heightRect = 6;

            Rectangle temp = smallRect;
            Console.WriteLine(temp.widthRect);
            Console.WriteLine(smallRect.widthRect);
            temp.widthRect = temp.widthRect + 7;
            
            Console.WriteLine("Temp rectangle value: {0}",temp.widthRect);
            Console.WriteLine("small rectangle value: {0}", smallRect.widthRect);

            /*Console.WriteLine("Small rectangle\nWidth={0}\nHeight={1}\narea={2}",smallRect.widthRect,smallRect.heightRect,smallRect.CalculateArea());
            Console.WriteLine("\n\nBig rectangle\nWidth={0}\nHeight={1}\narea={2}", bigRect.widthRect, bigRect.heightRect, bigRect.CalculateArea());*/
            
            Console.WriteLine("\nHashcode for small rect:{0}",smallRect.GetHashCode());
            Console.WriteLine("Hashcode for big rect:{0}", bigRect.GetHashCode());
            Console.WriteLine("Hashcode for temp rect:{0}", temp.GetHashCode());
            Console.ReadLine();
        }
    }
}
