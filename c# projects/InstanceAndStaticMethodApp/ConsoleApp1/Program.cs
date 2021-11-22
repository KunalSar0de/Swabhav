using System;


namespace InstanceAndStaticMethodApp
{
    class Program
    {
        //static method:this method will share copy of data for all objects
        public static void LineCountDisplay(int countNum) 
        {
            Console.WriteLine($"Total count is :{countNum}");
        }
        //instance method
        public void PaintLine(int x,int y) 
        {
            Console.WriteLine($"Line is drown from co-ordinate {x} to co-ordinate {y}");
        }
        static void Main(string[] args)
        {
            Program.LineCountDisplay(2);
            //here we cant access paint method directly we have to create object of it 
            Program p1 = new Program();
            p1.PaintLine(4, 6);
            Console.ReadLine();
        }
    }
}
