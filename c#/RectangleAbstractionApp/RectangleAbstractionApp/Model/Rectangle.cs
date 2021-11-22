using System;

namespace RectangleAbstractionApp.Model
{
    class Rectangle
    {
        public int widthRect;
        public int heightRect;

        public int CalculateArea()
        {
            return widthRect * heightRect;
        }
    }
}
