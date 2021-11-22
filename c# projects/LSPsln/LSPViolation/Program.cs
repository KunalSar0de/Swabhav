using System;
using LSPViolation.Model;

namespace LSPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(20, 30));
            Console.WriteLine("\nSquare:");
            ShouldNotChangeWidthIfHeightIsModified(new Square(5));
            Console.ReadKey();
        }
        public static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.GetWidth();
            rectangle.SetHeight(rectangle.GetHeight() + 10);
            var after = rectangle.GetWidth();
            Console.WriteLine(before == after);
            Console.WriteLine(before);
            Console.WriteLine(after);
        }
    }
}
