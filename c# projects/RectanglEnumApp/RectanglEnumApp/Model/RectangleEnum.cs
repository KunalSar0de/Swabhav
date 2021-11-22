using System;
namespace RectanglEnumApp.Model
{
    class RectangleEnum
    {

        private int _width;
        private int _height;
        private ColorType _borderColor;

      
        public  RectangleEnum()
        {
            _borderColor = ColorType.Red;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 1)
                {
                    _width = 1;
                }
                else if (value > 100)
                {
                    _width = 100;
                }
                else
                {
                    _width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 1)
                {
                    _height = 1;
                }
                else if (value > 100)
                {
                    _height = 100;
                }
                else
                {
                    _height = value;
                }
            }
        }

        public ColorType BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor= value;
            }
        }

    }
}
