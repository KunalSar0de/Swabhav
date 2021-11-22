using System;


namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int widthRect;
        private int heightRect;
        

        public int CalculateArea()
        {
            return widthRect * heightRect;
        }

        public void SetWidth(int pwidth) {
            widthRect= GetCorrectDimension(pwidth);
        }
        public int GetWidth()
        {
            return widthRect;
        }

        public void SetHeight(int pheight)
        {
            heightRect=GetCorrectDimension(pheight);

        }
        public int GetHeight()
        {
            return heightRect;
        }

        private int GetCorrectDimension(int dimension)
        {
           
            if (dimension < 1)
            {
                return 1;
            }
            else if (dimension > 100)
            {
                return 100;
            }
            else
            {           
                return dimension;              
            }
        }
    }
}
