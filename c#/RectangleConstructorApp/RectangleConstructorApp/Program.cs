using System;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
         }

        public static void CaseStudy1()
        {
            Rectangle r1 = new Rectangle(30, 20, "red");
            PrintDetails(r1);
            Console.ReadLine();
        }

        public static void CaseStudy2()
        {
            Rectangle r2 = new Rectangle(50, 60);
            PrintDetailsCase2(r2);
            Console.ReadLine();
        }
        static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("\nWidth set: {0}", r.GetWidth());
            Console.WriteLine("Height set: {0}", r.GetHeight());
            Console.WriteLine("Border Color set: {0}", r.GetBorderColor());
            Console.WriteLine("Area of circle is: {0} ", r.CalculateArea());           
        }
        static void PrintDetailsCase2(Rectangle r)
        {
            Console.WriteLine("\nWidth set: {0}", r.GetWidth());
            Console.WriteLine("Height set: {0}", r.GetHeight());           
            Console.WriteLine("Area of circle is: {0} ", r.CalculateArea());
        }
    }
}
