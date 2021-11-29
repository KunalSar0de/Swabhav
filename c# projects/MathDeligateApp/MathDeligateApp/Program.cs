using System;


namespace MathDeligateApp
{
    delegate void DMathOperation(int a, int b);
    class Program
    {
        static void Main()
        {
            DMathOperation m1;
            m1 = Add;
            m1 += Subtract;
            m1 += Mul;
            m1 += Div;
            m1(5, 3);

            Console.ReadKey();

        }
        public static void  Add(int a,int b)
        {
            Console.WriteLine("Addition is : "+(a + b));
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Sybtract is : " + (a - b));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication is : " + (a * b));
        }
        public static void Div(int a, int b)
        {
            float result = a / b;

            Console.WriteLine("Division is : " + result);
        }
    }
}
