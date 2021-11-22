using System;
using RectanglEnumApp.Model;
namespace RectanglEnumApp
{
    class Program
    {
        static void Main()
        {
            RectangleEnum r1 = new RectangleEnum();
            r1.Width = -15;
            r1.Height = 120;
            r1.BorderColor =ColorType.Green;

            Console.WriteLine("Width set: {0}",r1.Width);
            Console.WriteLine("Height set: {0}", r1.Height);
            Console.WriteLine("Border Color set: {0}", r1.BorderColor);
            Console.WriteLine("Area: {0}", r1.CalculateArea());
            Console.ReadLine();
        }
    }
}
