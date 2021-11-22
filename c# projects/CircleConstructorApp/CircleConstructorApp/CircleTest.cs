using System;
using CircleConstructorApp.Model;

namespace CircleConstructorApp
{
    class CircleTest
    {
        static void Main()
        {
                   
                //construction creation
                Circle c1 = new Circle(5.5f, "red", "bLue");//rgb
                Circle c2 = new Circle(10.5f, "Black", "grEEn");
                Circle c3 = new Circle(6.5f, "Purple", "GreEn");
           
                //Printing details 
                PrintDetails(c1);
                PrintDetails(c2);
            PrintDetails(c3);
            Console.ReadLine();
                      
        }
       
        static void PrintDetails(Circle c)
        {
            Console.WriteLine("\nRadius set: {0}", c.GetRadius());
            Console.WriteLine("Border Color set: {0}", c.GetBorderColor());
            Console.WriteLine("Fill Color set: {0}", c.GetFillColor());
            Console.WriteLine("Area of circle is: {0} ", c.CalculateArea());
        }
    }
}
