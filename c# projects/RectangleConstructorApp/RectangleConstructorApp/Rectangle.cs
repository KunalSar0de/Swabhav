using System;

namespace RectangleConstructorApp
{
    class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private readonly string _color;
        private readonly string _borderColor;
 
        public int CalculateArea()
        {
            return _width * _height;
        }
        public  Rectangle(int width, int height, string borderColor)
        {
            _width = width;
            _height = height;
            _borderColor =borderColor;
        }

        public Rectangle(int width1, int height1)
        {
            _width = width1;
            _height = height1;
        }

        public int GetWidth()
        {
              return _width;
        }
        public int GetHeight()
        {
               return _height;
        }
        public string GetColor()
        {
               return _color;
        }

        public string GetBorderColor()
        {
            return _borderColor;
        }
    }
}
