using System;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            
            //object creation
            Rectangle smallRect = new Rectangle();


            //value setter
            //smallRect.SetWidth(10);
            //smallRect.SetHeight(150);
            Console.WriteLine("Enter Width:");
            int x=Convert.ToInt32(Console.ReadLine());
            smallRect.SetWidth(x);
            Console.WriteLine("Enter Height:");
            int y = Convert.ToInt32(Console.ReadLine());
            smallRect.SetHeight(y);
            Console.WriteLine("Width set: {0}",smallRect.GetWidth());
            Console.WriteLine("Height set: {0}", smallRect.GetHeight());
            Console.WriteLine("Area of rectangle is: {0} ",smallRect.CalculateArea());

            Console.ReadLine();
        }
    }
}
