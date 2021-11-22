using System;
using CircleEncapTestApp.Model;

namespace CircleEncapTestApp
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        public static void CaseStudy3()
        {
            Circle c1 = new Circle();
            c1.SetRedius(5.7f);
            c1.SetFillColor("green");

            Circle[] manyCircles = new Circle[3];
            manyCircles[0]=c1;
            manyCircles[1] = new Circle();
            manyCircles[1].SetRedius(6.9f);
           PrintDetails(manyCircles);
        }
        public static void CaseStudy2()
        {
            //Anonymus Object//Refrence will not store on stack
            Console.WriteLine("Area of anonymus circle object is: {0}",new Circle().CalculateArea());
            Console.WriteLine("border color of anonymus circle object is: {0}", new Circle().GetBorderColor());
            //PrintDetails(new Circle());
            Console.ReadLine();
        }
        public static void CaseStudy1()
        {
            Circle c1 = new Circle();

            //value setter
            c1.SetRedius(5.5f);
            c1.SetBorderColor("BLue");
            c1.SetFillColor("green");
            PrintDetails(c1);                   
            Console.ReadLine();
        }
        static void PrintDetails(Circle c)
        {
            Console.WriteLine("\nRadius set: {0}", c.GetRadius());
            Console.WriteLine("Border Color set: {0}", c.GetBorderColor());
            Console.WriteLine("Fill Color set: {0}", c.GetFillColor());
            Console.WriteLine("Area of circle is: {0} ", c.CalculateArea());
        }
        static void PrintDetails(Circle[] c)
        {
            Console.WriteLine("Displaying Circle Array:\n");
            for (int i = 0; i < c.Length; i++)
            {
                PrintDetails(c[i]);
            }
        }

    }
}
